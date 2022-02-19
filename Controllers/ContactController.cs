using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlineFaxServer.Data;
using PlineFaxServer.Models;
using PlineFaxServer.Models.Users;

namespace PlineFaxServer.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly FaxServerContext _context;
        private readonly UserManager<TblUser> _userManager;

        public ContactController(FaxServerContext context, UserManager<TblUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Contact
        public IActionResult Index()
        {
            return View(_context.TblContact
                .Where(m => m.UserId == _userManager.GetUserAsync(User).Result)
            );
        }

        // GET: Contact/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblContact = await _context.TblContact
                .FirstOrDefaultAsync(m => m.Id == id && m.UserId == _userManager.GetUserAsync(User).Result);
            if (tblContact == null)
            {
                return NotFound();
            }

            return View(tblContact);
        }

        // GET: Contact/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "Id,Name,LastName,NickName,FaxNumber,FaxNumber2," +
                "FaxNumber3,PhoneNumber,PhoneNumber2,PhoneNumber3," +
                "MobileNumber,MobileNumber2,MobileNumber3," +
                "Email,Email2,Email3,Address,Notes")]
            TblContact tblContact)
        {
            if (ModelState.IsValid)
            {
                var curUser = await _userManager.GetUserAsync(User);
                var cnt = await _context.TblContact
                    .Where(m => m.Name == tblContact.Name
                                && m.UserId == curUser).CountAsync();
                if (cnt > 0)
                {
                    ModelState.AddModelError("Name", "نام وارد شده تکراری می باشد.");
                    return View(tblContact);
                }

                cnt = await _context.TblContact
                    .Where(m => m.LastName == tblContact.LastName
                                && m.UserId == curUser)
                    .CountAsync();
                if (cnt > 0)
                {
                    ModelState.AddModelError("LastName", "نام خانوادگی وارد شده تکراری می باشد.");
                    return View(tblContact);
                }

                tblContact.UserId = curUser;
                _context.Add(tblContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(tblContact);
        }

        // GET: Contact/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblContact = await _context.TblContact.FindAsync(id);
            if (tblContact == null)
            {
                return NotFound();
            }

            return View(tblContact);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind(
                "Id,Name,LastName,NickName,FaxNumber,FaxNumber2,FaxNumber3," +
                "PhoneNumber,PhoneNumber2,PhoneNumber3," +
                "MobileNumber,MobileNumber2,MobileNumber3," +
                "Email,Email2,Email3,Address,Notes")]
            TblContact tblContact)
        {
            if (id != tblContact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var curUser = await _userManager.GetUserAsync(HttpContext.User);
                    var cnt = await _context.TblContact
                        .Where(m => m.Name == tblContact.Name
                                    && m.Id != tblContact.Id
                                    && m.UserId == curUser).CountAsync();
                    if (cnt > 0)
                    {
                        ModelState.AddModelError("Name", "نام وارد شده تکراری می باشد.");
                        return View(tblContact);
                    }

                    cnt = await _context.TblContact
                        .Where(m => m.LastName == tblContact.LastName
                                    && m.Id != tblContact.Id
                                    && m.UserId == curUser)
                        .CountAsync();
                    if (cnt > 0)
                    {
                        ModelState.AddModelError("LastName", "نام خانوادگی وارد شده تکراری می باشد.");
                        return View(tblContact);
                    }

                    _context.Update(tblContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblContactExists(tblContact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(tblContact);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblContact = await _context.TblContact.FindAsync(id);
            if (tblContact == null) return Json(new {result = 0});
            _context.TblContact.Remove(tblContact);
            var cnt = await _context.SaveChangesAsync();
            return Json(new {result = cnt});
        }

        private bool TblContactExists(int id)
        {
            return _context.TblContact.Any(e => e.Id == id);
        }
        
    }
}