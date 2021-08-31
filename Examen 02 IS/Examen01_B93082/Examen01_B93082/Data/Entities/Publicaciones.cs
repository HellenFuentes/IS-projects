using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen01_B93082.Data.Entities
{
    public class Publicaciones
    {
        [Key]
        public int Doi { set; get; }
        public int Ref { set; get; }
        public string Resumen { set; get; }
        public string Tipo { set; get; }
        public string Nombre { set; get; }
    }
}
