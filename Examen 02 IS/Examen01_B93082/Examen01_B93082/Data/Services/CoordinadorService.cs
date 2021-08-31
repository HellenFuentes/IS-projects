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
    public class CoordinadorService
    {
        private readonly Context.AppDbContext _context;
        public CoordinadorService(Context.AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertCoordinadores(Coordinador coordinador)
        {
            await _context.Coordinador.AddAsync(coordinador);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Coordinador> GetCoordinadoresAsync(int Id)
        {
            Coordinador coordinador = await _context.Coordinador.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return coordinador;
        }

        public async Task<bool> DeleteCoordinadoresAsync(Coordinador coordinador)
        {
            _context.Remove(coordinador);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateCoordinadoresAsync(Coordinador coordinador)
        {
            _context.Coordinador.Update(coordinador);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Coordinador>> GetAllCoordinadoresAsync()
        {
            return await _context.Coordinador.ToListAsync();
        }
        public string getNameById(int id)
        {
            return _context.Coordinador.Where(c => c.Id.Equals(id)).FirstOrDefault().Nombre;
        }

    }
}
