using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Examen01_B93082.Domain.GruposInvestigacion.Entities
{
    public class GrupoInvestigacion
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get;set; }
        public DateTime FechaCreacion { get; set; }
        public int? Coordinador { get; set; }

        public GrupoInvestigacion(int id, string nombre, string? descripcion, DateTime fechaCreacion, int? coordinador)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.FechaCreacion = fechaCreacion;
            this.Coordinador = coordinador;

        }
        public GrupoInvestigacion()
        {
            this.Id = 0;
            this.Nombre = null;
            this.Descripcion = null;
            this.FechaCreacion = DateTime.Now;
            this.Coordinador = 0;
        }


    }
}
