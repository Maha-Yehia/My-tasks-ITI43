using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models; 

namespace WebApplication2.Controllers
{
    public class InstructorController : Controller
    {
        ITIEntities context = new ITIEntities();
        // GET: Instructor  

        public ActionResult Index()
        {
            ViewBag.depts = context.Departments.ToList();

            return View(context.Instructors.ToList());
        }
        [HttpPost]
        public ActionResult Index(int id)
        {          
            ViewBag.depts = context.Departments.ToList();
            return View(context.Instructors.Where(i => i.Dept_Id == id).ToList());
           
        }

        // GET: Instructor/Details/5
        public ActionResult Details(int id)
        {
            Instructor inst = context.Instructors.Find(id); 
            return View(inst);
        }

        // GET: Instructor/Create
        public ActionResult Create()
        {
            ViewBag.depts = context.Departments.ToList();


            return View();
        }

        // POST: Instructor/Create
        [HttpPost]
        public ActionResult Create(Instructor inst)
        {
            try
            {
                // TODO: Add insert logic here

                context.Instructors.Add(inst);
               context.SaveChanges();   
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Instructor/Edit/5
        public ActionResult Edit(int id)
        {
            Instructor inst = context.Instructors.Find(id);
            ViewBag.depts = context.Departments.ToList();
            return View(inst);
        }

        // POST: Instructor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Instructor inst = context.Instructors.Find(id);
                inst.Ins_Name = collection["Ins_Name"];
                inst.Salary = int.Parse( collection["Salary"]);
                inst.Ins_Degree = collection["Ins_Degree"];

                // TODO: Add update logic here
                context.SaveChanges(); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Instructor/Delete/5
        //public ActionResult Delete(int id)
        //{
           
        //    return View();
        //}

        //POST: Instructor/Delete/5
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            
                Instructor inst = context.Instructors.Find(id);
                context.Instructors.Remove(inst);
            context.SaveChanges(); 
                // TODO: Add delete logic here
                return RedirectToAction("Index");
    
          
        }
    }
}
