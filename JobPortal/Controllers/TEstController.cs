using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Controllers
{
    public class TEstController : Controller
    {
        // GET: TEst
        public ActionResult Index()
        {
            return View();
        }

        // GET: TEst/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TEst/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TEst/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TEst/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TEst/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TEst/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TEst/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
