using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SAT.DATA;

namespace SAT.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ScheduledClassStatusController : Controller
    {
        private SATEntities db = new SATEntities();

        // GET: ScheduledClassStatus
        public ActionResult Index()
        {
            return View(db.ScheduledClassStatus.ToList());
        }

        // GET: ScheduledClassStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledClassStatu scheduledClassStatu = db.ScheduledClassStatus.Find(id);
            if (scheduledClassStatu == null)
            {
                return HttpNotFound();
            }
            return View(scheduledClassStatu);
        }

        // GET: ScheduledClassStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduledClassStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SCID,SCName,SCDescription")] ScheduledClassStatu scheduledClassStatu)
        {
            if (ModelState.IsValid)
            {
                db.ScheduledClassStatus.Add(scheduledClassStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scheduledClassStatu);
        }

        // GET: ScheduledClassStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledClassStatu scheduledClassStatu = db.ScheduledClassStatus.Find(id);
            if (scheduledClassStatu == null)
            {
                return HttpNotFound();
            }
            return View(scheduledClassStatu);
        }

        // POST: ScheduledClassStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SCID,SCName,SCDescription")] ScheduledClassStatu scheduledClassStatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduledClassStatu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scheduledClassStatu);
        }

        // GET: ScheduledClassStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduledClassStatu scheduledClassStatu = db.ScheduledClassStatus.Find(id);
            if (scheduledClassStatu == null)
            {
                return HttpNotFound();
            }
            return View(scheduledClassStatu);
        }

        // POST: ScheduledClassStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScheduledClassStatu scheduledClassStatu = db.ScheduledClassStatus.Find(id);
            db.ScheduledClassStatus.Remove(scheduledClassStatu);
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
