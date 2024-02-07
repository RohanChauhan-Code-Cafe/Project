using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HIMSWebApp.DAL;
using HIMSWebApp.Models;

namespace HIMSWebApp.Controllers
{
    public class AppointmentController : Controller
    {
        AppointmentDAL ObjAppointmentDAL = new AppointmentDAL();

        // GET: Appointment
        public ActionResult Index()
        {
            var Appointmentlist = ObjAppointmentDAL.GetAllAppointments();
            return View(Appointmentlist);
        }

        // GET: Appointment/Details/5
        public ActionResult Details(int id)
        {
            var Appointment = ObjAppointmentDAL.GetAppointmentByID(id).FirstOrDefault();
            return View(Appointment);
        }

        // GET: Appointment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Appointment/Create
        [HttpPost]
        public ActionResult Create(Appointment objAppointment)
        {
            try
            {
                // TODO: Add insert logic here
                ObjAppointmentDAL.InsertAppointments(objAppointment);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointment/Edit/5
        public ActionResult Edit(int id)
        {
            var Appointment = ObjAppointmentDAL.GetAppointmentByID(id).FirstOrDefault();
            return View(Appointment);
        }

        // POST: Appointment/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Appointment ObjAppointment)
        {
            try
            {
                // TODO: Add update logic here
                ObjAppointmentDAL.UpdateAppointments(ObjAppointment);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Appointment/Delete/5
        public ActionResult Delete(int id)
        {
            var Appointment = ObjAppointmentDAL.GetAppointmentByID(id).FirstOrDefault();
            return View(Appointment);
        }

        // POST: Appointment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteAppointment(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ObjAppointmentDAL.DeleteAppointments(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
