using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Examen01_B93082.Application.Coordinadores.Implementations;
using Examen01_B93082.Domain.Coordinadores.Entities;
using Examen01_B93082.Domain.Coordinadores.Repositories;
using Moq;
using Xunit;

namespace Examen01_B93082.UnitTests.Application.Coordinadores
{
    public class CoordinadorServiceTest
    {
        private static IEnumerable<Coordinador> GetCoordinadores()
        {
            const int coordinadores = 10000;
            for (int i = 0; i < coordinadores; i++)
            {
                yield return new Coordinador();
            }
        }
        [Fact]
        public async Task GetCoordinadoresAsyncShouldReturnCoordinadores()
        {// arrange
            var coorInfo = GetCoordinadores().ToList();
            var mockTeamRepository = new Mock<ICoordinadorRepository>();
            mockTeamRepository.Setup(repo =>
            repo.GetAllCoordinadoresAsync()).ReturnsAsync(coorInfo);
            var teamService = new CoordinadorService(mockTeamRepository.Object);
            // act
            var results = await teamService.GetAllCoordinadoresAsync();
            // assert
            results.Should().BeEquivalentTo(coorInfo);
        }
    }
}
