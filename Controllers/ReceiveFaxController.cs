using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlineFaxServer.Data;
using PlineFaxServer.Models;
using PlineFaxServer.Models.Users;
using PlineFaxServer.Tools;

namespace PlineFaxServer.Controllers
{
    [Authorize]
    public class ReceiveFaxController : Controller
    {
        private readonly FaxServerContext _context;
        private readonly UserManager<TblUser> _userManager;

        public ReceiveFaxController(FaxServerContext context, UserManager<TblUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ReceiveFax
        public async Task<IActionResult> Index(Globals.FaxStatus? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "ReceiveFax", new {id = Globals.FaxStatus.Received});
            }

            var user = await _userManager.GetUserAsync(User);
            var faxs = await _context.TblReceiveFax
                .Where(m => m.Status == Globals.FaxStatus.NewFaxReceive && m.UserId == user)
                .ToListAsync<TblReceiveFax>();
            foreach (var tbl in faxs)
            {
                tbl.Status = Globals.FaxStatus.Received;
                _context.Update(tbl);
            }

            await _context.SaveChangesAsync();

            if (id == Globals.FaxStatus.Received)
            {
                return View(_context.TblReceiveFax
                    .Where(m => m.Status == Globals.FaxStatus.Received
                                || m.Status == Globals.FaxStatus.NewFaxReceive
                                && m.UserId == user)
                    .AsQueryable<TblReceiveFax>());
            }

            return View(_context.TblReceiveFax
                .Where(m => m.Status == id && m.UserId == user).AsQueryable<TblReceiveFax>());
        }

        // POST: ReceiveFax/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblReceiveFax = await _context.TblReceiveFax.FindAsync(id);
            _context.TblReceiveFax.Remove(tblReceiveFax);
            await _context.SaveChangesAsync();
            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot",
                tblReceiveFax.FileName);
            System.IO.File.Delete(path);
            return RedirectToAction(nameof(Index));
        }

        private bool TblReceiveFaxExists(int id)
        {
            return _context.TblReceiveFax.Any(e => e.Id == id);
        }

        [HttpPost]
        public async Task<IActionResult> NewFaxs()
        {
            var user = await _userManager.GetUserAsync(User);
            var faxs = await _context.TblReceiveFax
                .Where(m => m.Status == Globals.FaxStatus.NewFaxReceive && m.UserId == user)
                .ToListAsync();
            foreach (var tbl in faxs)
            {
                tbl.Status = Globals.FaxStatus.Received;
                _context.Update(tbl);
            }

            await _context.SaveChangesAsync();
            var faxsRec = await _context.TblReceiveFax
                .Where(m => m.Status == Globals.FaxStatus.Received && m.UserId == user)
                .CountAsync();
            return Json(new {newFax = faxs.Count, rec = faxsRec});
        }

        public async Task<FileResult> DownloadFile(int? id)
        {
            var model = await _context.TblReceiveFax.FindAsync(id);
            if (model == null) return null;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", model.FullPath);
            var bytes = await System.IO.File.ReadAllBytesAsync(path);
            return File(bytes, "application/octet-stream", model.FileName);
        }

        [HttpPost, ActionName("Status")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetStatus(Globals.FaxStatus status, int id)
        {
            var tblReceive = await _context.TblReceiveFax.FindAsync(id);
            if (tblReceive == null)
            {
                return Json(new {r = false, error = "خطا در حذف. لطفا با راهبر سیستم تماس بگیرید"});
            }

            tblReceive.Status = status;
            _context.TblReceiveFax.Update(tblReceive);
            await _context.SaveChangesAsync();
            return Json(new {r = true, error = string.Empty});
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetNewFax(string filename, string callerId, string did)
        {
            var curUser = await _userManager.Users.Where(t => t.UserName == did).FirstOrDefaultAsync();
            var date = $"{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "FaxFiles",
                did, "receive", date);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fn = Globals.GenerateId() + ".pdf";
            System.IO.File.Move(filename, path + "/" + fn);

            TblReceiveFax fax = new TblReceiveFax()
            {
                Date = date,
                Line = did,
                CallerId = callerId,
                Status = Globals.FaxStatus.NewFaxReceive,
                Time = DateTime.Now.ToString("hh:mm"),
                FileName = fn,
                UserId = curUser,
                FullPath = path + "/" + fn ,
            };
            _context.Add(fax);
            var result = await _context.SaveChangesAsync();
            return Json(new {r = result});
        }
    }
}