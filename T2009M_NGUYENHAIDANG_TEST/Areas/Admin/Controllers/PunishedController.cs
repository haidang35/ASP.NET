using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using T2009M_NGUYENHAIDANG_TEST.Data;
using T2009M_NGUYENHAIDANG_TEST.Models;

namespace T2009M_NGUYENHAIDANG_TEST.Areas.Admin.Controllers
{
    public class PunishedController : Controller
    {
        private TestDbContext db = new TestDbContext();

        // GET: Admin/Punished
        public ActionResult Index()
        {
            var punishedList = db.PunishedPersons.ToList();
            return View(punishedList);
        }

        // GET: Admin/Punished/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PunishedPerson punishedPerson = db.PunishedPersons.Find(id);
            if (punishedPerson == null)
            {
                return HttpNotFound();
            }
            return View(punishedPerson);
        }

        // GET: Admin/Punished/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Punished/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PunishedPerson punishedPerson)
        {
            if (ModelState.IsValid)
            {
                punishedPerson.CreatedAt = DateTime.Now;
                db.PunishedPersons.Add(punishedPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(punishedPerson);
        }

        // GET: Admin/Punished/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PunishedPerson punishedPerson = db.PunishedPersons.Find(id);
            if (punishedPerson == null)
            {
                return HttpNotFound();
            }
            return View(punishedPerson);
        }

        // POST: Admin/Punished/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentCode,Formality,Date")] PunishedPerson punishedPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(punishedPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(punishedPerson);
        }

        // GET: Admin/Punished/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PunishedPerson punishedPerson = db.PunishedPersons.Find(id);
            if (punishedPerson == null)
            {
                return HttpNotFound();
            }
            return View(punishedPerson);
        }

        // POST: Admin/Punished/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PunishedPerson punishedPerson = db.PunishedPersons.Find(id);
            db.PunishedPersons.Remove(punishedPerson);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
