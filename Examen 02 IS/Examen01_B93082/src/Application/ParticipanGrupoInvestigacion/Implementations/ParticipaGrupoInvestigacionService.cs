using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Repositories;
using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Domain.Investigadores.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examen01_B93082.Application.ParticipanGrupoInvestigacion.Implementations
{
    internal class ParticipaGrupoInvestigacionService : IParticipaGrupoInvestigacionService
    {
        private readonly IParticipaGrupoInvestigacionRepository _participaGrupoRepository;
        private readonly IInvestigadorRepository _investigadorRepository;
        public ParticipaGrupoInvestigacionService(IParticipaGrupoInvestigacionRepository participaGrupoRepository,
            IInvestigadorRepository investigadorRepository)
        {
            _participaGrupoRepository = participaGrupoRepository;
            _investigadorRepository = investigadorRepository;
        }

        public async Task AddParticipaGrupoInvestigacionAsync(ParticipaGrupoInvestigacion participaGrupoInvestigacion)
        {
            await _participaGrupoRepository.SaveAsync(participaGrupoInvestigacion);
        }

        public void DeleteParticipaGrupoInvestigacion(ParticipaGrupoInvestigacion participaGrupoInvestigacion)
        {
            _participaGrupoRepository.DeleteParticipaGrupoInvestigacion(participaGrupoInvestigacion);
        }

        public IEnumerable<Investigador> GetInvestigadoresByGrupoInvestigacionId(int grupoInvestigacionId)
        {
            List<Investigador> listaInvestigadores = new();
            IEnumerable<ParticipaGrupoInvestigacion> participan = _participaGrupoRepository.GetListOfParticipaGrupoInvestigacionByGrupoId(grupoInvestigacionId);
            foreach (ParticipaGrupoInvestigacion p in participan)
            {
                listaInvestigadores.Add( _investigadorRepository.GetInvestigadorById(p.InvestigadorId));
            }
            return listaInvestigadores;
        }
        public async Task<ParticipaGrupoInvestigacion> GetParticipaInvestigacionByKeys(int investigadorId, int grupoInvestigacionId)
        {
           return await _participaGrupoRepository.GetByPrimaryKeysAsync(investigadorId, grupoInvestigacionId);
        }

        public async Task<List<ParticipaGrupoInvestigacion>> GetParticipanGruposInvestigacionAsync()
        {
            return await _participaGrupoRepository.GetAllAsync();
        }
    }
}
