﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DAS.Controllers
{
    public class MapaController : Controller
    {
        // GET: Mapa
        public ActionResult Index()
        {
            return View("View2");
        }

        // GET: Mapa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mapa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mapa/Create
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

        // GET: Mapa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mapa/Edit/5
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

        // GET: Mapa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mapa/Delete/5
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
