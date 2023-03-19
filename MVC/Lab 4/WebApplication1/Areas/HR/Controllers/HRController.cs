using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.HR.Controllers
{
    [HandleError(View = "myErrorPage")]

    public class HRController : Controller
    {
        // GET: HR/HR
        public ActionResult Index()
        {
            string str = null;
            ViewBag.strLength = str.Length;
            return View();
        }

        // GET: HR/HR/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HR/HR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HR/HR/Create
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

        // GET: HR/HR/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HR/HR/Edit/5
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

        // GET: HR/HR/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HR/HR/Delete/5
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
