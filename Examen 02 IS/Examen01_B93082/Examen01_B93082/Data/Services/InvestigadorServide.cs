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
    public class InvestigadorServide
    {
        private readonly Context.AppDbContext _context;
        public InvestigadorServide(Context.AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> InsertInvestigador(Investigador investigador)
        {
            await _context.Investigador.AddAsync(investigador);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Investigador> GetInvestigadorAsync(int Id)
        {
            Investigador investigador = await _context.Investigador.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return investigador;
        }

        public async Task<bool> DeleteInvestigadorAsync(Investigador investigador)
        {
            _context.Remove(investigador);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateInvestigadorAsync(Investigador investigador)
        {
            _context.Investigador.Update(investigador);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Investigador>> GetAllInvestigadoresAsync()
        {
            return await _context.Investigador.ToListAsync();
        }
        public string getNameById(int id)
        {
            return _context.Investigador.Find(id).Nombre;
        }
    }
}
