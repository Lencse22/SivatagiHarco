using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RFProjekt.Dnn.KeresoModulSivatagiHarco.Controllers
{
    public class SzurController : Controller
    {
        // GET: Szur
        public ActionResult Index(string Nem, string Kategória, string Terméktípús, string Név)
        {
            var NemLst = new List<string>();

            var NemQry = from d in 
                           orderby d.Genre
                           select d.Genre;

            var KatLst = new List<string>();

            var KatQry = from d in 
                         orderby d.Genre
                         select d.Genre;

            var TerLst = new List<string>();

            var TerQry = from d in 
                         orderby d.Genre
                         select d.Genre;

            NemLst.AddRange(NemQry.Distinct());
            ViewBag.movieGenre = new SelectList(NemLst);

            KatLst.AddRange(KatQry.Distinct());
            ViewBag.movieGenre = new SelectList(KatLst);

            TerLst.AddRange(TerQry.Distinct());
            ViewBag.movieGenre = new SelectList(TerLst);



            var movies = from m in 
                         select m;

            if (!String.IsNullOrEmpty(Név))
            {
                movies = movies.Where(s => s.Név.Contains(Név));
            }

            if (!string.IsNullOrEmpty(Terméktípús))
            {
                movies = movies.Where(x => x.Genre == Terméktípús);
            }

            if (!string.IsNullOrEmpty(Kategória))
            {
                movies = movies.Where(x => x.Genre == Kategória);
            }

            if (!string.IsNullOrEmpty(Nem))
            {
                movies = movies.Where(x => x.Genre == Nem);
            }

            return View(movies);
        }

        // GET: Szur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Szur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Szur/Create
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

        // GET: Szur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Szur/Edit/5
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

        // GET: Szur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Szur/Delete/5
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
