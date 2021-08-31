using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen01_B93082.Data.Entities;
using Examen01_B93082.Data.Services;

namespace Examen01_B93082.Data.Services
{
    public class DeleteGrupoInvestigacionService : PageModel
    {
        public DeleteGrupoInvestigacionService(Context.AppDbContext context)
        {
            _context = context;
        }

        private readonly Context.AppDbContext _context;

        public async Task<GruposInvestigacion> GetGrupoAsync(int Id)
        {
            GruposInvestigacion grupo = await _context.GrupoInvestigacion.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return grupo;
        }

        public async Task<bool> DeleteGrupoAsync(GruposInvestigacion grupo)
        {
            _context.Remove(grupo);
            await _context.SaveChangesAsync();
            return true;
        }


    }
}
