using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HIMSWebApp.DAL;
using HIMSWebApp.Models;

namespace HIMSWebApp.Controllers
{
    public class  StaffController : Controller
    {
        StaffDAL ObjStaffDAL = new StaffDAL();

        // GET: Staff
        public ActionResult Index()
        {
            var stafflist = ObjStaffDAL.GetAllStaffs();
            return View(stafflist);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            var staff = ObjStaffDAL.GetStaffByID(id).FirstOrDefault();
            return View(staff);
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(Staff objStaff)
        {
            try
            {
                // TODO: Add insert logic here
                ObjStaffDAL.InsertStaffs(objStaff);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            var staff = ObjStaffDAL.GetStaffByID(id).FirstOrDefault();
            return View(staff);
        }

        // POST: Staff/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Staff ObjStaff)
        {
            try
            {
                // TODO: Add update logic here
                ObjStaffDAL.UpdateStaffs(ObjStaff);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            var staff = ObjStaffDAL.GetStaffByID(id).FirstOrDefault();
            return View(staff);
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteStaff(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ObjStaffDAL.DeleteStaffs(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
