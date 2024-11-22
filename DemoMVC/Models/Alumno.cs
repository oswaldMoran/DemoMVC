using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Alumno
    {
        public int idAlumno { get; set; }
        public string Nombre { get;set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FecAlta { get; set; }
        public int Edad { get; set; }

    }
}