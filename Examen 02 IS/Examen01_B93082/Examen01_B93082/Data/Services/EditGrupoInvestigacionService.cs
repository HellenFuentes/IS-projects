using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Data.Entities;
using Examen01_B93082.Data.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Data.Services
{
    public class EditGrupoInvestigacionService : PageModel
    {
        private readonly Examen01_B93082.Data.Context.AppDbContext _context;

        public EditGrupoInvestigacionService(Examen01_B93082.Data.Context.AppDbContext context)
        {
            _context = context;
        }

        public async Task<GruposInvestigacion> GetGrupoAsync(int Id)
        {
            GruposInvestigacion grupo = await _context.GrupoInvestigacion.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return grupo;
        }

        public async Task<bool> UpdateGrupoAsync(GruposInvestigacion grupo)
        {
            _context.GrupoInvestigacion.Update(grupo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
