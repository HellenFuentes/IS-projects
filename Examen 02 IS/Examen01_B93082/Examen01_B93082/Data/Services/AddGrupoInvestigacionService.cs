using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen01_B93082.Data.Entities;

namespace Examen01_B93082.Data.Services
{
    public class AddGrupoInvestigacionService : PageModel
    {
        private readonly Context.AppDbContext _context;
        public AddGrupoInvestigacionService(Context.AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertGrupoInvestigacion(GruposInvestigacion grupo)
        {
            await _context.GrupoInvestigacion.AddAsync(grupo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
