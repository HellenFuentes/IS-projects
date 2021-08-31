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
    public class ViewGrupoInvestigacionService : PageModel
    {
        private readonly Context.AppDbContext _context;
        public ViewGrupoInvestigacionService(Context.AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<GruposInvestigacion>> GetAllGroupsAsync()
        {
            return await _context.GrupoInvestigacion.ToListAsync();
        }
    }
}
