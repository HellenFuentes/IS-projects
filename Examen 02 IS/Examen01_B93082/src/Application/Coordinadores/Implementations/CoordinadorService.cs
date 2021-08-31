using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Coordinadores.Entities;
using Examen01_B93082.Domain.Coordinadores.Repositories;

namespace Examen01_B93082.Application.Coordinadores.Implementations
{
    public class CoordinadorService : ICoordinadorService
    {
        private readonly ICoordinadorRepository _coordinadorRepository;

        public CoordinadorService(ICoordinadorRepository coordinadorRepository)
        {
            _coordinadorRepository = coordinadorRepository;
        }
        public Task<bool> InsertCoordinadores(Coordinador coordinador)
        {
            return _coordinadorRepository.InsertCoordinadores(coordinador);
        }

        public Task<Coordinador> GetCoordinadoresAsync(int Id)
        {
            return _coordinadorRepository.GetCoordinadoresAsync(Id);
        }

        public Task<bool> DeleteCoordinadoresAsync(Coordinador coordinador)
        {
            return _coordinadorRepository.DeleteCoordinadoresAsync(coordinador);
        }

        public Task<bool> UpdateCoordinadoresAsync(Coordinador coordinador)
        {
            return _coordinadorRepository.UpdateCoordinadoresAsync(coordinador);
        }
        public Task<List<Coordinador>> GetAllCoordinadoresAsync()
        {
            return _coordinadorRepository.GetAllCoordinadoresAsync();
        }
        public string getNameById(int id)
        {
            return _coordinadorRepository.getNameById(id);
        }
    }
}
