using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SampleMvc.Models;

namespace SampleMvc.Controllers
{
    public class employeesController : Controller
    {
        private TmsDbModel db = new TmsDbModel();

        // GET: employees
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }

        

        // GET: Drivers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,EmployeeName,Password,Gender,DateOfBirth,DateOfJoining,PhoneNo")] employee employee)
        {
            if (ModelState.IsValid)
            {
                db.employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Drivers/Edit/5
        [HttpGet]
        public ActionResult Edit(employee employee)
        {
            
            return View(employee);
        }

        // POST: Drivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost([Bind(Include = "EmployeeId,EmployeeName,Password,Gender,DateOfBirth,DateOfJoining,PhoneNo")] employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        
        public ActionResult Delete(employee employee)
        {
            
            return View(employee);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string employeeId)
        {
            employee employee = db.employees.Find(employeeId);
            db.employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost, ActionName("login")]
        public ActionResult LoginPost(employee employee)
        {
            var obj = db.employees.Where(x => x.EmployeeName.Equals(employee.EmployeeName) && x.Password.Equals(employee.Password)).FirstOrDefault();
            if (obj != null)
            {
                return RedirectToAction("index", "Drivers");
            }
            else if(employee.EmployeeName=="Admin" && employee.Password == "Admin1234")
            {
                return RedirectToAction("index","employees");
            }
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("login");
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
