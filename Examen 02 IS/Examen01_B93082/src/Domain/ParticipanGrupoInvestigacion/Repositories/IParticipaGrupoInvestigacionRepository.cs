using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;

namespace Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Repositories
{
    public interface IParticipaGrupoInvestigacionRepository
    {
        Task SaveAsync(ParticipaGrupoInvestigacion participaGrupoInvestigacion);
        Task<List<ParticipaGrupoInvestigacion>> GetAllAsync();
        Task<ParticipaGrupoInvestigacion> GetByPrimaryKeysAsync(int investigadorId, int grupoInvestigacionId);
        void DeleteParticipaGrupoInvestigacion(ParticipaGrupoInvestigacion participaGrupoInvestigacion);
        IEnumerable<ParticipaGrupoInvestigacion> GetListOfParticipaGrupoInvestigacionByGrupoId(int grupoInvestigacionId);
    }
}
