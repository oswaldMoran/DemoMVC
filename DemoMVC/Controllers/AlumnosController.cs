using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            //return View();
            var alumnos = from a in RecuperarAlumnos()
                          orderby a.idAlumno
                          select a;
            return View(alumnos);
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Alumno> RecuperarAlumnos()
        {
            return new List<Alumno>
            {
                new Alumno
                {
                    idAlumno=1,
                    Nombre="Oswaldo",
                    ApPaterno="Moran",
                    ApMaterno="Giron",
                    FecAlta=DateTime.Parse(DateTime.Now.ToString()),
                    Edad=40
                },
                new Alumno
                {
                    idAlumno=1,
                    Nombre="Luis",
                    ApPaterno="garcia",
                    ApMaterno="Perez",
                    FecAlta=DateTime.Parse(DateTime.Now.ToString()),
                    Edad=30
                }
            };
        }
    }
}
