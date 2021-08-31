using System.ComponentModel.DataAnnotations;
using System;

namespace Examen01_B93082.Domain.Investigadores.Entities
{
    public class Investigador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string MaximoGrado { get; set; }

        public Investigador(string nombre, string maximoGrado)
        {
            this.Nombre = nombre;
            this.MaximoGrado = maximoGrado;
        }
        public Investigador(string nombre, string maximoGrado, int id)
        {
            this.Nombre = nombre;
            this.MaximoGrado = maximoGrado;
            this.Id = id;
        }
        public Investigador()
        {
            this.Nombre = null;
            this.MaximoGrado = null;
            this.Id = 0;
        }
        public void CambiarNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public void CambiarGrado(string grado)
        {
            this.MaximoGrado = grado;
        }
    }
}