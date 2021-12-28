using ef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ef.Controllers
{
    public class PatientController : Controller

    {
      
       
        // GET: Patient
        [HttpGet]
        [Route("Patient")]
        public ActionResult Index()
        {
            using (Model1 model = new Model1())
            {
                var Getall = model.Patientdetails.ToList();
                return View(Getall);
            }
        }
        // GET: Patient/Details/5
        public ActionResult Details(int id)
        {
            using (Model1 model = new Model1())
            {
                var detail = model.Patientdetails.Where(x => x.Id == id).First();
                return View(detail);
            }
        }

        // GET: Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patient/Create
        [HttpPost]
        public ActionResult Create(Patientdetail values)
        {
            using (Model1 model = new Model1())
            {
                model.Patientdetails.Add(values);
                model.SaveChanges();
                ViewBag.Message = "Data Insert Successfully";
                return View();
            }
           
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            using (Model1 model = new Model1())
            {
                var edit = model.Patientdetails.Where(x => x.Id == id).First();
                return View(edit);
            }
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Patientdetail pd)
        {
            try
            {
                using (Model1 model = new Model1())
                {
                    var data = model.Patientdetails.Where(x => x.Id == pd.Id).First();
                    if (data != null)
                    {
                        data.Name = pd.Name;
                        data.Age = pd.Age;
                        data.Contact = pd.Contact;
                        model.SaveChanges();

                    }

                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)

        {
            using (Model1 model = new Model1())
            {
                var detail = model.Patientdetails.Where(x => x.Id == id).First();
                return View(detail);
            }
        }
        // POST: Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Patientdetail pd)
        {
            try
            {
                // TODO: Add delete logic here
                using (Model1 model = new Model1())
                {
                    var data = model.Patientdetails.Where(x => x.Id == id).First();
                    model.Patientdetails.Remove(data);
                    model.SaveChanges();
                    ViewBag.Messsage = "Succussfully Deleted";
                    return RedirectToAction("index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
