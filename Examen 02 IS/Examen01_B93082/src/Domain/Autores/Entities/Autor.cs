using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Examen01_B93082.Domain.Autores.Entities
{
    public class Autor
    {
        [Key]
        public int Id { get;  set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Autor(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Autor()
        {
            this.Nombre = null;
            this.Apellido = null;
        }
        public void CambiarNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public void CambiarApellido(string apellido)
        {
            this.Apellido = apellido;
        }
    }
}
