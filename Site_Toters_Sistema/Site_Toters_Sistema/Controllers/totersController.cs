using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Site_Toters_Sistema.Data;
using Site_Toters_Sistema.Models;

namespace Site_Toters_Sistema.Controllers
{
    public class totersController : Controller
    {
        private Context db = new Context();

        // GET: toters
        public ActionResult Index()
        {
            return View(db.toters.ToList());
        }

        // GET: toters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toter toter = db.toters.Find(id);
            if (toter == null)
            {
                return HttpNotFound();
            }
            return View(toter);
        }

        // GET: toters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: toters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeCompleto,Nacionalidade,Cidade,ReleaseDate,Telefone,Email")] toter toter)
        {
            if (ModelState.IsValid)
            {
                db.toters.Add(toter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toter);
        }

        // GET: toters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toter toter = db.toters.Find(id);
            if (toter == null)
            {
                return HttpNotFound();
            }
            return View(toter);
        }

        // POST: toters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeCompleto,Nacionalidade,Cidade,ReleaseDate,Telefone,Email")] toter toter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toter);
        }

        // GET: toters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            toter toter = db.toters.Find(id);
            if (toter == null)
            {
                return HttpNotFound();
            }
            return View(toter);
        }

        // POST: toters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            toter toter = db.toters.Find(id);
            db.toters.Remove(toter);
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
