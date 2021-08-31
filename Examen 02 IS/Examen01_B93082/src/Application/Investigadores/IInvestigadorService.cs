using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen01_B93082.Domain.Investigadores.Entities;

namespace Examen01_B93082.Application.Investigadores
{
    public interface IInvestigadorService
    {
        public Task<Investigador> GetInvestigadorByNombreAsync(string nombre);
        public IEnumerable<Investigador> GetInvestigadoresByMaximoGrado(string maximoGrado);
        public Task<List<Investigador>> GetInvestigadoresAsync();
        public Task AddInvestigadorAsync(Investigador investigador);
        public void DeleteInvestigador(Investigador investigador);
    }
}
