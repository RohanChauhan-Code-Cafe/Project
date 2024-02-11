using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HIMSWebApp.DAL;
using HIMSWebApp.Models;

namespace HIMSWebApp.Controllers
{
    public class SpecialityController : Controller
    {
        SpecialityDAL ObjSpecialityDAL = new SpecialityDAL();

        // GET: Speciality
        public ActionResult Index()
        {
            var Specialitylist = ObjSpecialityDAL.GetAllSpecialitys();
            return View(Specialitylist);
        }

        // GET: Speciality/Details/5
        public ActionResult Details(int id)
        {
            var Speciality = ObjSpecialityDAL.GetSpecialityByID(id).FirstOrDefault();
            return View(Speciality);
        }

        // GET: Speciality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speciality/Create
        [HttpPost]
        public ActionResult Create(Speciality objSpeciality)
        {
            try
            {
                // TODO: Add insert logic here
                ObjSpecialityDAL.InsertSpecialitys(objSpeciality);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Speciality/Edit/5
        public ActionResult Edit(int id)
        {
            var Speciality = ObjSpecialityDAL.GetSpecialityByID(id).FirstOrDefault();
            return View(Speciality);
        }

        // POST: Speciality/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(Speciality ObjSpeciality)
        {
            try
            {
                // TODO: Add update logic here
                ObjSpecialityDAL.UpdateSpecialitys(ObjSpeciality);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Speciality/Delete/5
        public ActionResult Delete(int id)
        {
            var Speciality = ObjSpecialityDAL.GetSpecialityByID(id).FirstOrDefault();
            return View(Speciality);
        }

        // POST: Speciality/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteSpeciality(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                ObjSpecialityDAL.DeleteSpecialitys(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
