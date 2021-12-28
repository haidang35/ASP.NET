using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using T2009M_NGUYENHAIDANG_PRACTICAL.Data;
using T2009M_NGUYENHAIDANG_PRACTICAL.Models;

namespace T2009M_NGUYENHAIDANG_PRACTICAL.Controllers
{
    public class ExamController : Controller
    {
        private DataDbContextContext db = new DataDbContextContext();

        // GET: Exam
        public ActionResult Index()
        {
            return View(db.Exams.ToList());
        }

        // GET: Exam/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                var now = DateTime.Now;
                var startTimeExam = TimeSpan.Parse(exam.StartTime);
                exam.ExamDate = exam.ExamDate.Date + startTimeExam;
                exam.ExamDate.AddMinutes(exam.Duration);
                Debug.WriteLine(exam.ExamDate);
                if (DateTime.Compare(now, exam.ExamDate) < 0)
                {
                    exam.Status = ExamStatus.UpComing;
                }else if(DateTime.Compare(now, exam.ExamDate) > 0)
                {
                    exam.Status = ExamStatus.Done;
                }else if(DateTime.Compare(now, exam.ExamDate) == 0)
                {
                    exam.Status = ExamStatus.OnGoing;
                }
                db.Exams.Add(exam);
                db.SaveChanges();
                TempData["Message"] = new Message { 
                    Type = MessageType.Success,
                    Content = "Create new exam successful",
                };
                return RedirectToAction("Index");
            }
            TempData["Message"] = new Message
            {
                Type = MessageType.Failed,
                Content = "Create new exam failed, please try again !",
            };
            return View(exam);
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exam);
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exam exam = db.Exams.Find(id);
            db.Exams.Remove(exam);
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
