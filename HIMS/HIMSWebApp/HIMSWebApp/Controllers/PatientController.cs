using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HIMSWebApp.DAL;
using HIMSWebApp.Models;

namespace HIMSWebApp.Controllers
{
    public class PatientController : Controller
    {
        PatientDAL ObjPatientDAL = new PatientDAL();

        // GET: Patient
        public ActionResult Index()
        {
            var patientlist = ObjPatientDAL.GetAllPatients();
            return View(patientlist);
        }

        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {
            var patient = ObjPatientDAL.GetPatientByID(id).FirstOrDefault();
            return View(patient);
        }

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient/Create
        [HttpPost]
        public ActionResult Create(Patient objPatient)
        {
            try
            {
                // TODO: Add insert logic here
                ObjPatientDAL.InsertPatients(objPatient);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            var patient = ObjPatientDAL.GetPatientByID(id).FirstOrDefault();
            return View(patient);
        }

        // POST: Patient/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Patient ObjPatient)
        {
            try
            {
                // TODO: Add update logic here
                ObjPatientDAL.UpdatePatients(ObjPatient);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            var patient = ObjPatientDAL.GetPatientByID(id).FirstOrDefault();
            return View(patient);
        }

        // POST: Patient/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePatient(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ObjPatientDAL.DeletePatients(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
