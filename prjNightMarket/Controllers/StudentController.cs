using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjNightMarket.Models;

namespace prjNightMarket.Controllers
{
    public class StudentController : Controller
    {
        dbStudentEntities db = new dbStudentEntities();
        // GET: Student
        public ActionResult Index()
        {
            var students = db.tStudent.ToList();
            return View(students);
        }

        //GET:Create
        public ActionResult Create()
        {
            return View();
        }

        //POST:Create
        [HttpPost]
        public ActionResult Create(tStudent vStudent)
        {
            //通過驗證的話，就新增學生的資料
            if(ModelState.IsValid)
            {
                db.tStudent.Add(vStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vStudent);
        }

        //GET:Delete
        public ActionResult Delete(string id)
        {
            var student = db.tStudent.Where(m => m.fStuId == id).FirstOrDefault();
            db.tStudent.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}