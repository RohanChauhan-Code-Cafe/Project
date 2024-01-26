using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIMSWebApp.DAL;
using SIMSWebApp.Models;

namespace SIMSWebApp.Controllers
{
    public class StudentController : Controller
    {
        StudentDAL ObjStudentDAL = new StudentDAL();
        // GET: Student
        public ActionResult Index()
        {
            var studentlist = ObjStudentDAL.GetAllStudents();
            return View(studentlist);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var student = ObjStudentDAL.GetStudentByID(id).FirstOrDefault();
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student ObjStudent)
        {
            try
            {
                // TODO: Add insert logic here
                ObjStudentDAL.InsertStudents(ObjStudent);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var student = ObjStudentDAL.GetStudentByID(id).FirstOrDefault();
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Student ObjStudent)
        {
            try
            {
                // TODO: Add update logic here
                ObjStudentDAL.UpdateStudents(ObjStudent);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var student = ObjStudentDAL.GetStudentByID(id).FirstOrDefault();
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStudent(int id)
        {
            try
            {
                // TODO: Add delete logic here
                ObjStudentDAL.DeleteStudents(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
