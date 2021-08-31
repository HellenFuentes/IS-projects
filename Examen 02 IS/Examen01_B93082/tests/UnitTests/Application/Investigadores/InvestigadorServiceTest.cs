using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Examen01_B93082.Application.Investigadores.Implementations;
using Examen01_B93082.Domain.Investigadores.Entities;
using Examen01_B93082.Domain.Investigadores.Repositories;
using Moq;
using Xunit;

namespace Examen01_B93082.UnitTests.Application.Investigadores
{
    public class InvestigadorServiceTest
    {
        private static IEnumerable<Investigador> GetCoordinadores()
        {
            const int investigadores = 10000;
            for (int i = 0; i < investigadores; i++)
            {
                yield return new Investigador();
            }
        }
        [Fact]
        public async Task GetCoordinadoresAsyncShouldReturnCoordinadores()
        {// arrange
            var coorInfo = GetCoordinadores().ToList();
            var mockTeamRepository = new Mock<IInvestigadorRepository>();
            mockTeamRepository.Setup(repo =>
            repo.GetAllAsync()).ReturnsAsync(coorInfo);
            var teamService = new InvestigadorService(mockTeamRepository.Object);
            // act
            var results = await teamService.GetInvestigadoresAsync();
            // assert
            results.Should().BeEquivalentTo(coorInfo);
        }
    }
}
