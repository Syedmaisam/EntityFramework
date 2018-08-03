using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            StudentViewModel svm = new StudentViewModel();
            List<Student> std = svm.getallstudent();
            ViewBag.create = std;

            return View(std);
        }

        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            StudentDatabaseContext sdc = new StudentDatabaseContext();
            sdc.students.Add(student);
            
            sdc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {

            return View();
        }

    }
}