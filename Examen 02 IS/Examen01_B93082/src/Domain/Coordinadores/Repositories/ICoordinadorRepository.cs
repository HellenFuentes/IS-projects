using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Coordinadores.Entities;

namespace Examen01_B93082.Domain.Coordinadores.Repositories
{
     public interface ICoordinadorRepository
        {
            Task<bool> InsertCoordinadores(Coordinador coordinador);
            Task<Coordinador> GetCoordinadoresAsync(int Id);
            Task<bool> DeleteCoordinadoresAsync(Coordinador coordinador);
            Task<bool> UpdateCoordinadoresAsync(Coordinador coordinador);
            Task<List<Coordinador>> GetAllCoordinadoresAsync();
            public string getNameById(int id);
        }
}
