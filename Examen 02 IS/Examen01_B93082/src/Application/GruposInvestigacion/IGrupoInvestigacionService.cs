using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;

namespace Examen01_B93082.Application.GruposInvestigacion
{
    public interface IGrupoInvestigacionService
    {
        public Task<GrupoInvestigacion?> GetGrupoInvestigacionByNombreAsync(string nombre);
        public Task<GrupoInvestigacion?> GetGrupoInvestigacionByIDAsync(int id);
        public Task<List<GrupoInvestigacion>> GetGruposInvestigacionAsync();
        public IEnumerable<GrupoInvestigacion> GetGruposInvestigacionByCoordinador(int coordinadorID);
        public Task AddGrupoInvestigacionAsync(GrupoInvestigacion grupo);
        public void DeleteGrupoInvestigacion(GrupoInvestigacion grupo);
    }
}
