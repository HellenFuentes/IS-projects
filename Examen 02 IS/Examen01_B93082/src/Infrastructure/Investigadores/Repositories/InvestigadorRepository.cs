using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Core.Repositories;
using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Domain.Investigadores.Repositories;
using Examen01_B93082.Infrastructure.Investigadores;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Infrastructure.Investigadores.Repositories
{
    internal class InvestigadorRepository : IInvestigadorRepository
    {
        private readonly InvestigadoresDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public InvestigadorRepository(InvestigadoresDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
        public void DeleteInvestigador(Investigador investigador)
        {
            _dbContext.Remove(investigador);
            _dbContext.SaveChanges();
        }

        public async Task<List<Investigador>> GetAllAsync()
        {
            return await _dbContext.Investigador.ToListAsync();
        }

        public IEnumerable<Investigador> GetByMaximoGrado(string maximoGrado)
        {
            return _dbContext.Investigador.Where(i => i.MaximoGrado.Equals(maximoGrado));
        }

        public async Task<Investigador> GetByNombreAsync(string name)
        {
            return await _dbContext.Investigador.FirstOrDefaultAsync(i => i.Nombre.Equals(name));
        }

        public async Task SaveAsync(Investigador investigador)
        {
            _dbContext.Update(investigador);
            await _dbContext.SaveEntitiesAsync();
        }

        public async Task<Investigador> GetInvestigadorByIdAsync(int investigadorId)
        {
            return await _dbContext.Investigador.FirstAsync(i => i.Id.Equals(investigadorId));
        }
        public Investigador? GetInvestigadorById(int investigadorId)
        {
            return _dbContext.Investigador.Find(investigadorId);
        }
    }
}
