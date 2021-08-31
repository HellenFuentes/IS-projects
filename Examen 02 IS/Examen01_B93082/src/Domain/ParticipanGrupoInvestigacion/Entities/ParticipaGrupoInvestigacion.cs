using System.ComponentModel.DataAnnotations;
using System;
namespace Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Entities
{
    public class ParticipaGrupoInvestigacion
    {
        [Key]
        public int InvestigadorId { get; set; }
        [Key]
        public int GrupoInvestigacionId { get; set; }

        public ParticipaGrupoInvestigacion(int investigadorId, int grupoInvestigacionId)
        {
            this.InvestigadorId = investigadorId;
            this.GrupoInvestigacionId = grupoInvestigacionId;
        }
        public ParticipaGrupoInvestigacion()
        {
            this.InvestigadorId = 0;
            this.GrupoInvestigacionId = 0;
        }
    }
}
