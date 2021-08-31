using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Core.Repositories;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Examen01_B93082.Domain.GruposInvestigacion.Repositories;
using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Infrastructure.GruposInvestigacion;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Infrastructure.GruposInvestigacion.Repositories
{
    internal class GrupoInvestigacionRepository : IGrupoInvestigacionRepository
    {
        private readonly GrupoInvestigacionDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public GrupoInvestigacionRepository(GrupoInvestigacionDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        public async Task<List<GrupoInvestigacion>> GetAllAsync()
        {

            return await _dbContext.GrupoInvestigacion.ToListAsync();
        }

        public async Task<GrupoInvestigacion?> GetByIdAsync(int id)
        {
            return await _dbContext.GrupoInvestigacion.FindAsync(id);
        }

        public async Task<GrupoInvestigacion?> GetByNombreAsync(string nombre)
        {
            return await _dbContext.GrupoInvestigacion.FirstOrDefaultAsync(g => g.Nombre.Equals(nombre));
        }


        public Task<IEnumerable<Investigador>> GetInvestigadoresDelGrupo()
        {
            throw new System.NotImplementedException();
        }

        public async Task SaveAsync(GrupoInvestigacion grupoInvestigacion)
        {
            _dbContext.Update(grupoInvestigacion);
            await _dbContext.SaveEntitiesAsync();
        }

        public void DeleteGrupoInvestigacion(GrupoInvestigacion grupoInvestigacion)
        {

            _dbContext.Remove(grupoInvestigacion);
            _dbContext.SaveChanges();
        }

        public IEnumerable<GrupoInvestigacion?> GetGruposByCoordinador(int coordinadorID)
        {
            return _dbContext.GrupoInvestigacion.Where(g => g.Coordinador.Equals(coordinadorID));
        }
    }
}
