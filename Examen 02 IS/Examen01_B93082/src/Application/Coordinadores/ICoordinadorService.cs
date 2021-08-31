using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Coordinadores.Entities;

namespace Examen01_B93082.Application.Coordinadores
{
    public interface ICoordinadorService
    {
        public Task<bool> InsertCoordinadores(Coordinador coordinador);
        public Task<Coordinador> GetCoordinadoresAsync(int Id);
        public Task<bool> DeleteCoordinadoresAsync(Coordinador coordinador);
        public Task<bool> UpdateCoordinadoresAsync(Coordinador coordinador);
        public Task<List<Coordinador>> GetAllCoordinadoresAsync();
        public string getNameById(int id);
    }
}
