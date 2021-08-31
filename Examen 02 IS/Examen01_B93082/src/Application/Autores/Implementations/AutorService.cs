using System.Collections.Generic;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Autores.Entities;
using Examen01_B93082.Domain.Autores.Repositories;


namespace Examen01_B93082.Application.Autores.Implementations
{
    internal class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public Task AddAutorAsync(Autor autor)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAutor(Autor autor)
        {
            _autorRepository.DeleteAutor(autor);
        }

        public async Task<Autor> GetAutorByApellidoAsync(string apellido)
        {
            return await _autorRepository.GetByApellidoAsync(apellido);
        }

        public async Task<Autor> GetAutorByNombreAsync(string nombre)
        {
            return await _autorRepository.GetByApellidoAsync(nombre);
        }

        public async Task<List<Autor>> GetAutoresAsync()
        {
            return await _autorRepository.GetAllAsync();
        }
    }
}
