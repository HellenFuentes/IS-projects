using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Core.Repositories;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Repositories;
using Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion.Repositories
{
    internal class ParticipaGrupoInvestigacionRepository : IParticipaGrupoInvestigacionRepository
    {

        private readonly ParticipaGrupoInvestigacionDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public ParticipaGrupoInvestigacionRepository(ParticipaGrupoInvestigacionDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }
        public void DeleteParticipaGrupoInvestigacion(ParticipaGrupoInvestigacion participaGrupoInvestigacion)
        {
            _dbContext.Remove(participaGrupoInvestigacion);
            _dbContext.SaveChanges();
        }

        public async Task<List<ParticipaGrupoInvestigacion>> GetAllAsync()
        {
            return await _dbContext.ParticipaGrupoInvestigacion.ToListAsync();
        }

        public async Task<ParticipaGrupoInvestigacion> GetByPrimaryKeysAsync(int investigadorId, int grupoInvestigacionId)
        {
            return await _dbContext.ParticipaGrupoInvestigacion.FindAsync(investigadorId,grupoInvestigacionId);
        }

        public async Task SaveAsync(ParticipaGrupoInvestigacion participaGrupoInvestigacion)
        {
            _dbContext.Update(participaGrupoInvestigacion);
            await _dbContext.SaveEntitiesAsync();
        }

        public IEnumerable<ParticipaGrupoInvestigacion> GetListOfParticipaGrupoInvestigacionByGrupoId(int grupoInvestigacionId)
        {
            return _dbContext.ParticipaGrupoInvestigacion.Where(p => p.GrupoInvestigacionId.Equals(grupoInvestigacionId));
        }
    }
}
