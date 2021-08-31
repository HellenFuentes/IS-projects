using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Core.Repositories;
using Examen01_B93082.Domain.Autores.Entities;
using Examen01_B93082.Domain.Autores.Repositories;
using Examen01_B93082.Infrastructure.Autores;
using Microsoft.EntityFrameworkCore;

namespace Examen01_B93082.Infrastructure.Autores.Repositories
{
    internal class AutorRepository : IAutorRepository
    {
        private readonly AutoresDbContext _dbContext;
        public IUnitOfWork UnitOfWork => _dbContext;
        public AutorRepository (AutoresDbContext unitOfWork)
        {
            _dbContext = unitOfWork;
        }

        public void DeleteAutor(Autor autor)
        {
            _dbContext.Remove(autor);
            _dbContext.SaveChanges();
        }

        public async Task<List<Autor>> GetAllAsync()
        {
            return await _dbContext.Autor.ToListAsync();
        }

        public async Task<Autor> GetByApellidoAsync(string apellido)
        {
            return await _dbContext.Autor.FirstOrDefaultAsync(a => a.Apellido.Equals(apellido));
        }

        public async Task<Autor?> GetByNombreAsync(string name)
        {
            return await _dbContext.Autor.FirstOrDefaultAsync(a => a.Nombre.Equals(name));
        }

        public async Task SaveAsync(Autor autores)
        {
            _dbContext.Update(autores);
            await _dbContext.SaveEntitiesAsync();
        }
    }
}