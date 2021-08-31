using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECCI_IS_Lab01_WebApp.Models.Metadata
{
    public class MatriculaMetadata
    {
        [Range(4.0, 9.99)] 
        public Nullable<decimal> Nota;
    }
}