using AR30Web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AR30Web.Controllers
{
    public class SellersController : Controller
    {
        private ApplicationDbContext dbContext;

        public SellersController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        // GET: SellersController
        public async Task<ActionResult> Index()
        {
            return View(await dbContext.Issuers.ToListAsync());
        }

        // GET: SellersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SellersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SellersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(include:"Name")] Issuer issuer)
        {
            if (ModelState.IsValid)
            {
                dbContext.Issuers.Add(issuer);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(issuer);
        }

        // GET: SellersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SellersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SellersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SellersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
