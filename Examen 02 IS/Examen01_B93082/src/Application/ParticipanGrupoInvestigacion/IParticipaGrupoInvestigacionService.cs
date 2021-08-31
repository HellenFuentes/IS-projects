using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;
using Examen01_B93082.Domain.Investigadores.Entities;

namespace Examen01_B93082.Application.ParticipanGrupoInvestigacion
{
    public interface IParticipaGrupoInvestigacionService
    {
        public Task<ParticipaGrupoInvestigacion> GetParticipaInvestigacionByKeys(int investigadorId, int grupoInvestigacionId);
        public IEnumerable<Investigador> GetInvestigadoresByGrupoInvestigacionId(int grupoInvestigacionId);
        public Task<List<ParticipaGrupoInvestigacion>> GetParticipanGruposInvestigacionAsync();
        public Task AddParticipaGrupoInvestigacionAsync(ParticipaGrupoInvestigacion participaGrupoInvestigacion);
        public void DeleteParticipaGrupoInvestigacion(ParticipaGrupoInvestigacion participaGrupoInvestigacion);
    }
}
