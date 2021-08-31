using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Examen01_B93082.Domain.Investigadores.Entities;

namespace Examen01_B93082.Domain.GruposInvestigacion.Repositories
{
    public interface IGrupoInvestigacionRepository
    {
        Task SaveAsync(GrupoInvestigacion grupoInvestigacion);
        Task<List<GrupoInvestigacion>> GetAllAsync();
        Task<GrupoInvestigacion?> GetByIdAsync(int id);
        Task<GrupoInvestigacion?> GetByNombreAsync(string nombre);
        IEnumerable<GrupoInvestigacion?> GetGruposByCoordinador(int coordinadorID);
        void DeleteGrupoInvestigacion(GrupoInvestigacion grupoInvestigacion);
        Task<IEnumerable<Investigador?>> GetInvestigadoresDelGrupo();
    }
}
