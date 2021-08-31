using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen01_B93082.Data.Entities
{
    public class GruposInvestigacion
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Coordinador { get; set; }
        public int Investigadores { get; set; }
    }
}
