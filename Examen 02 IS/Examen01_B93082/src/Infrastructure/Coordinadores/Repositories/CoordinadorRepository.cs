using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Core.Repositories;
using Examen01_B93082.Domain.Coordinadores.Entities;
using Examen01_B93082.Domain.Coordinadores.Repositories;
using Examen01_B93082.Infrastructure.Coordinadores;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Infrastructure.Coordinadores.Repositories
{
    internal class CoordinadorRepository : ICoordinadorRepository
    {
        private readonly CoordinadoresDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public CoordinadorRepository(CoordinadoresDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        public async Task<bool> InsertCoordinadores(Coordinador coordinador)
        {
            await _dbContext.Coordinador.AddAsync(coordinador);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Coordinador> GetCoordinadoresAsync(int Id)
        {
            Coordinador coordinador = await _dbContext.Coordinador.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return coordinador;
        }

        public async Task<bool> DeleteCoordinadoresAsync(Coordinador coordinador)
        {
            _dbContext.Remove(coordinador);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCoordinadoresAsync(Coordinador coordinador)
        {
            _dbContext.Coordinador.Update(coordinador);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<List<Coordinador>> GetAllCoordinadoresAsync()
        {
            return await _dbContext.Coordinador.ToListAsync();
        }
        public string getNameById(int id)
        {
            return _dbContext.Coordinador.Where(c => c.Id.Equals(id)).FirstOrDefault().Nombre;
        }
    }
}
