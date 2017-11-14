using Dropdown2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dropdown2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            var res = db.Employees.ToList();
            return View(res);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            ViewBag.StateList = db.StateList;
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee model)
        {
            try
            {
                // TODO: Add insert logic here
                db.Employees.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
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

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
        public ActionResult FillCity(int state)
        {
          

            var cities = db.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}
