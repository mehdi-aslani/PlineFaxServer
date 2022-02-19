using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PlineFaxServer.Data;
using PlineFaxServer.Models;
using PlineFaxServer.Models.Users;
using PlineFaxServer.Tools;

namespace PlineFaxServer.Controllers
{
    [Authorize]
    public class SendFaxController : Controller
    {
        private readonly FaxServerContext _context;
        private readonly UserManager<TblUser> _userManager;
        private readonly IConfiguration _iConfig;

        public SendFaxController(FaxServerContext context, UserManager<TblUser> userManager, IConfiguration iConfig)
        {
            _context = context;
            _userManager = userManager;
            _iConfig = iConfig;
        }

        // GET: SendFax
        public IActionResult Index(Globals.FaxStatus? id)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (id == null)
            {
                return RedirectToAction("Index", "SendFax", new {id = Globals.FaxStatus.InQueue});
            }

            return View(_context.TblSendFax
                .Where(m => m.Status == id && m.UserId == user)
                .AsQueryable<TblSendFax>());
        }

        // GET: SendFax/Create
        public IActionResult Create()
        {
            var pr = new PersianCalendar();
            var dt = DateTime.Now;
            return View(new TblSendFax()
            {
                Date =
                    $"{pr.GetYear(dt).ToString():00}/{pr.GetMonth(dt).ToString():00}/{pr.GetDayOfMonth(dt).ToString():00}",
                Time = DateTime.Now.ToString("HH:mm"),
                CallerId = HttpContext.User.Identity?.Name,
                Status = Globals.FaxStatus.InQueue
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile fileName, [Bind("Id,Date,Time,CallerId,Line,FileName,Status")]
            TblSendFax tblSendFax)
        {
            if (fileName == null || fileName.Length == 0)
            {
                ModelState.AddModelError("FileName", "لطفا فایل فکس را انتخاب کنید");
            }
            else if (ModelState.IsValid)
            {
                string extension = System.IO.Path.GetExtension(fileName.FileName);
                if (extension.ToLower() != ".pdf")
                {
                    ModelState.AddModelError("FileName", "فایل انتخاب شده باید فرمت PDF باشد");
                    return View(tblSendFax);
                }

                var curUser = HttpContext.User.Identity == null ? "Guest" : HttpContext.User.Identity.Name;
                curUser ??= "Guest";
                tblSendFax.FileName = fileName.FileName;

                var datePath = $"{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}";
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "FaxFiles",
                    curUser, "sends", datePath);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                var uniqueName = Globals.GenerateId() + extension;
                path = Path.Combine(path, uniqueName);
                await using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileName.CopyToAsync(stream);
                }

                tblSendFax.FullPath = Path.Combine("FaxFiles",
                    curUser, "sends", datePath, uniqueName).Replace("\\", "/");
                tblSendFax.Status = Globals.FaxStatus.InQueue;
                tblSendFax.CallerId = curUser;
                tblSendFax.UserId = _userManager.GetUserAsync(User).Result;
                _context.Add(tblSendFax);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(tblSendFax);
        }


        [HttpPost, ActionName("Status")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetStatus(Globals.FaxStatus status, int id)
        {
            var tblSendFax = await _context.TblSendFax.FindAsync(id);
            if (tblSendFax == null)
            {
                return Json(new {r = false, error = "خطا در حذف. لطفا با راهبر سیستم تماس بگیرید"});
            }

            tblSendFax.Status = status;
            _context.TblSendFax.Update(tblSendFax);
            await _context.SaveChangesAsync();
            return Json(new {r = true, error = string.Empty});
        }

        private bool TblSendFaxExists(int id)
        {
            return _context.TblSendFax.Any(e => e.Id == id);
        }

        public async Task<FileResult> DownloadFile(int? id)
        {
            var model = await _context.TblSendFax.FindAsync(id);
            if (model == null) return null;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", model.FullPath);
            var bytes = await System.IO.File.ReadAllBytesAsync(path);
            return File(bytes, "application/octet-stream", model.FileName);
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> GetContacts(string search)
        {
            search ??= "";
            var user = await _userManager.GetUserAsync(User);
            var data = _context.TblContact.Where(m =>
                    m.UserId == user && (EF.Functions.Like(m.Name, $"%{search}%") ||
                                         EF.Functions.Like(m.LastName, $"%{search}%") ||
                                         EF.Functions.Like(m.NickName, $"%{search}%"))
                )
                .OrderByDescending(m => m.LastName)
                .ThenByDescending(m => m.Name)
                .Skip(0).Take(25)
                .Select(contact => new string[]
                {
                    contact.Name,
                    contact.LastName,
                    contact.NickName,
                    contact.FaxNumber,
                    contact.FaxNumber2,
                    contact.FaxNumber3,
                });
            return Json(data);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SendFax(int id, Globals.FaxStatus status)
        {
            var data = await _context.TblSendFax.Where(t => t.Id == id).FirstOrDefaultAsync();
            data.Status = status;
            _context.Update(data);
            var result = await _context.SaveChangesAsync();
            return Json(new {result = result});
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> SendFaxQueue()
        {
            Console.WriteLine("Send...");
            var faxs = _context.TblSendFax.Where(t => t.Status == Globals.FaxStatus.InQueue);
            if (await faxs.LongCountAsync() == 0) return Json(new {result = 0});


            foreach (var fax in faxs)
            {
                string faxSpool = Directory.GetCurrentDirectory() + "/wwwroot";
                string sipTrunk = _iConfig.GetSection("Fax").GetValue<string>("SipTrunk");
                string callFile = $"Channel: SIP/{sipTrunk}/{fax.Line}\n" +
                                  $"CallerId: {fax.Line}\n" +
                                  $"Context: send-fax\n" +
                                  $"Extension: fax\n" +
                                  $"Priority: 1\n" +
                                  $"Setvar: FAXSPOOL={faxSpool}\n" +
                                  $"Setvar: FileName={fax.FullPath}\n\n";
                string file = Tools.Globals.GenerateId() + ".call";
                await System.IO.File.WriteAllTextAsync("/var/spool/asterisk/outgoing/" + file, callFile,
                    Encoding.ASCII);
                fax.Status = Globals.FaxStatus.Send;
                _context.Update(fax);
            }

            await _context.SaveChangesAsync();
            return Json(new {result = 1});
        }
    }
}