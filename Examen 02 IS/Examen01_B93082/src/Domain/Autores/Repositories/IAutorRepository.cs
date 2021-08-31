using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Autores.Entities;

namespace Examen01_B93082.Domain.Autores.Repositories
{
    public interface IAutorRepository
    {
        Task SaveAsync(Autor autores);
        Task<List<Autor>> GetAllAsync();
        Task<Autor?> GetByNombreAsync(string name);
        Task<Autor?> GetByApellidoAsync(string apellido);
        void DeleteAutor(Autor autor);
    }
}
