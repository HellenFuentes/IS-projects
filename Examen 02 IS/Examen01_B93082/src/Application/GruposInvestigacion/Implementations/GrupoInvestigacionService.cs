using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Examen01_B93082.Domain.GruposInvestigacion.Repositories;

namespace Examen01_B93082.Application.GruposInvestigacion.Implementations
{
    internal class GrupoInvestigacionService : IGrupoInvestigacionService
    {
        private readonly IGrupoInvestigacionRepository _grupoInvestigacionRepository;
        public GrupoInvestigacionService(IGrupoInvestigacionRepository grupoInvestigacionRepository)
        {
            _grupoInvestigacionRepository = grupoInvestigacionRepository;
        }
        public async Task AddGrupoInvestigacionAsync(GrupoInvestigacion grupoInvestigacion)
        {
           await _grupoInvestigacionRepository.SaveAsync(grupoInvestigacion);
        }

        public void DeleteGrupoInvestigacion(GrupoInvestigacion grupo)
        {
            _grupoInvestigacionRepository.DeleteGrupoInvestigacion(grupo);
        }

        public async Task<GrupoInvestigacion?> GetGrupoInvestigacionByNombreAsync(string nombre)
        {
            return await _grupoInvestigacionRepository.GetByNombreAsync(nombre);
        }

        public async Task<List<GrupoInvestigacion>> GetGruposInvestigacionAsync()
        {
            return await _grupoInvestigacionRepository.GetAllAsync();
        }

        public IEnumerable<GrupoInvestigacion> GetGruposInvestigacionByCoordinador(int coordinadorID)
        {
            return _grupoInvestigacionRepository.GetGruposByCoordinador(coordinadorID);
        }

        public async Task<GrupoInvestigacion> GetGrupoInvestigacionByIDAsync(int id)
        {
            return await _grupoInvestigacionRepository.GetByIdAsync(id);
        }
    }
}
