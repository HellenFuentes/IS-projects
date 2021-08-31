using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen01_B93082.Data.Entities
{
    public class ProyectoInvestigacion
    {
        public string Nombre { get; set; }
        [Key]
        public int Id { get; set; }
        public int InvestigadorPrincipal { get; set; }
        public int Colaboradores { get; set; }
        public string FechaInicio{ get; set; }
        public string FechaFinal{ get; set; }
    }
}
