using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen01_B93082.Data.Entities
{
    public class Coordinador
    {
        public string Nombre{ get; set; }
        [Key]
        public int Id { get; set; }
        public DateTime FechaInicioNombramiento { get; set; }
        public DateTime FechaFinalNombramiento { get; set; }
    }
}
