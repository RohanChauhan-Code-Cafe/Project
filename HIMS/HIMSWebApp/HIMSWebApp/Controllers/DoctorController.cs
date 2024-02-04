using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HIMSWebApp.DAL;
using HIMSWebApp.Models;

namespace HIMSWebApp.Controllers
{
    public class  DoctorController : Controller
    {
        DoctorDAL ObjDoctorDAL = new DoctorDAL();

        // GET: Doctor
        public ActionResult Index()
        {
            var Doctorlist = ObjDoctorDAL.GetAllDoctors();
            return View(Doctorlist);
        }

        // GET: Doctor/Details/5
        public ActionResult Details(int id)
        {
            var Doctor = ObjDoctorDAL.GetDoctorByID(id).FirstOrDefault();
            return View(Doctor);
        }

        // GET: Doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor/Create
        [HttpPost]
        public ActionResult Create(Doctor objDoctor)
        {
            try
            {
                // TODO: Add insert logic here
                ObjDoctorDAL.InsertDoctors(objDoctor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Edit/5
        public ActionResult Edit(int id)
        {
            var Doctor = ObjDoctorDAL.GetDoctorByID(id).FirstOrDefault();
            return View(Doctor);
        }

        // POST: Doctor/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Doctor ObjDoctor)
        {
            try
            {
                // TODO: Add update logic here
                ObjDoctorDAL.UpdateDoctors(ObjDoctor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctor/Delete/5
        public ActionResult Delete(int id)
        {
            var Doctor = ObjDoctorDAL.GetDoctorByID(id).FirstOrDefault();
            return View(Doctor);
        }

        // POST: Doctor/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteDoctor(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ObjDoctorDAL.DeleteDoctors(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
