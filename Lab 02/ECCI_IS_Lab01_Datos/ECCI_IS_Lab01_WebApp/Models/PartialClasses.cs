using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECCI_IS_Lab01_WebApp.Models
{
    // Connection of EstudianteMetadata with Estudiante
    [MetadataType(typeof(Metadata.EstudianteMetadata))] 
    public partial class Estudiante { } 
    // Connection of MatriculaMetadata with Matricula
    [MetadataType(typeof(Metadata.MatriculaMetadata))] 
    public partial class Matricula { }
}