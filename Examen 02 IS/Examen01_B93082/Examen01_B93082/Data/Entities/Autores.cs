using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen01_B93082.Data.Entities
{
    public class Autores
    {
        [Key]
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
    }
}
