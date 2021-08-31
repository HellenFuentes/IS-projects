using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Domain.Investigadores.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen01_B93082.Application.Investigadores.Implementations
{
    public class InvestigadorService : IInvestigadorService
    {
        private readonly IInvestigadorRepository _investigadorRepository;
        public InvestigadorService(IInvestigadorRepository investigadorRepository)
        {
            _investigadorRepository = investigadorRepository;
        }
        public async Task AddInvestigadorAsync(Investigador investigador)
        {
            await _investigadorRepository.SaveAsync(investigador);
        }

        public void DeleteInvestigador(Investigador investigador)
        {
            _investigadorRepository.DeleteInvestigador(investigador);
        }

        public async Task<Investigador?> GetInvestigadorByNombreAsync(string nombre)
        {
           return await _investigadorRepository.GetByNombreAsync(nombre);
        }

        public async Task<List<Investigador>> GetInvestigadoresAsync()
        {
            return await _investigadorRepository.GetAllAsync();
        }

        public IEnumerable<Investigador?> GetInvestigadoresByMaximoGrado(string maximoGrado)
        {
            return _investigadorRepository.GetByMaximoGrado(maximoGrado);
        }
    }
}
