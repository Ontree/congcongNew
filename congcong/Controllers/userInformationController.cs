using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using congcong.Models;

namespace congcong.Controllers
{
    public class userInformationController : Controller
    {
        private congcongEntities db = new congcongEntities();

        //
        // GET: /userInformation/

        public ActionResult Index()
        {
            return View(db.cc_user.ToList());
        }

        //
        // GET: /userInformation/Details/5

        public ActionResult Details(int id = 0)
        {
            cc_user cc_user = db.cc_user.Find(id);
            if (cc_user == null)
            {
                return HttpNotFound();
            }
            return View(cc_user);
        }

        //
        // GET: /userInformation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /userInformation/Create

        [HttpPost]
        public ActionResult Create(cc_user cc_user)
        {
            if (ModelState.IsValid)
            {
                db.cc_user.Add(cc_user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cc_user);
        }

        //
        // GET: /userInformation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            cc_user cc_user = db.cc_user.Find(id);
            if (cc_user == null)
            {
                return HttpNotFound();
            }
            return View(cc_user);
        }

        //
        // POST: /userInformation/Edit/5

        [HttpPost]
        public ActionResult Edit(cc_user cc_user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cc_user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cc_user);
        }

        //
        // GET: /userInformation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            cc_user cc_user = db.cc_user.Find(id);
            if (cc_user == null)
            {
                return HttpNotFound();
            }
            return View(cc_user);
        }

        //
        // POST: /userInformation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            cc_user cc_user = db.cc_user.Find(id);
            db.cc_user.Remove(cc_user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}