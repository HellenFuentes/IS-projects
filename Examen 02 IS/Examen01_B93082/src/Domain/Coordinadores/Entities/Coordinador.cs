using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Examen01_B93082.Domain.Coordinadores.Entities
{
    public class Coordinador
    {
        public string Nombre { get; set; }
        [Key]
        public int Id { get; private set; }
        public DateTime FechaInicioNombramiento { get; set; }
        public DateTime FechaFinalNombramiento { get; set; }

        DateTime maxDate = DateTime.Today;

        public Coordinador(string nombre, DateTime FechaInicioNombramiento, DateTime FechaFinalNombramiento)
        {
            this.Nombre = nombre;
            this.FechaInicioNombramiento = FechaInicioNombramiento;
            this.FechaFinalNombramiento = FechaFinalNombramiento;
        }
        public Coordinador()
        {
            this.Nombre = null;
            this.FechaInicioNombramiento = DateTime.Now;
            this.FechaFinalNombramiento = DateTime.Now;
        }
        public bool setDate(DateTime date)
        {
            bool response = false;
            if (date > DateTime.MinValue && date <= maxDate)
            {
                response = true;
                this.FechaFinalNombramiento = date;
            }
            return response;
        }
    }
}
