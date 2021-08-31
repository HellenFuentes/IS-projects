using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Autores.Entities;

namespace Examen01_B93082.Application.Autores
{
    public interface IAutorService
    {
        public Task<Autor?> GetAutorByNombreAsync(string nombre);
        public Task<Autor?> GetAutorByApellidoAsync(string apellido);
        public Task<List<Autor>> GetAutoresAsync();
        public Task AddAutorAsync(Autor autor);
        public void DeleteAutor(Autor autor);
    }
}
