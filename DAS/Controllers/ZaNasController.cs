using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAS.Controllers
{
    public class ZaNasController : Controller
    {
        // GET: ZaNas
        public ActionResult Index()
        {
            return View("View1");
        }

        // GET: ZaNas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZaNas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZaNas/Create
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

        // GET: ZaNas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZaNas/Edit/5
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

        // GET: ZaNas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZaNas/Delete/5
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
