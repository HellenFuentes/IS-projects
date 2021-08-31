using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECCI_IS_Lab01_WebApp.Models.Metadata
{
    public class EstudianteMetadata
    {
        [Display(Name = "Fecha")]
        public Nullable<System.DateTime> FechaMatricula;
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        [Required] public string CorreoElectronico;
    }
}