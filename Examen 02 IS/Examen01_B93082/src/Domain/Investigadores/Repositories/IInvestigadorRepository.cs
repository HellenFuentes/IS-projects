using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Investigadores.Entities;

namespace Examen01_B93082.Domain.Investigadores.Repositories
{
    public interface IInvestigadorRepository
    {
        Task SaveAsync(Investigador investigador);
        Task<List<Investigador>> GetAllAsync();
        Task<Investigador> GetByNombreAsync(string name);
        IEnumerable<Investigador> GetByMaximoGrado(string maximoGrado);
        void DeleteInvestigador(Investigador investigador);
        Task<Investigador> GetInvestigadorByIdAsync(int investigadorId);
        Investigador? GetInvestigadorById(int investigadorId);
    }
}
