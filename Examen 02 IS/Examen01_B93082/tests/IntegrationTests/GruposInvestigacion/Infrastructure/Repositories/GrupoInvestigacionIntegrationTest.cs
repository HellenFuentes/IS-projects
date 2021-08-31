using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Examen01_B93082.Domain.GruposInvestigacion.Entities;
using Examen01_B93082.Domain.GruposInvestigacion.Repositories;
using Examen01_B93082.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Examen01_B93082.IntegrationTests.GruposInvestigacion.Infrastructure.Repositories
{
    public class GrupoInvestigacionIntegrationTest : IClassFixture<GrupoInvestigacionWebApplicationFactory<Startup>>
    {

        private readonly GrupoInvestigacionWebApplicationFactory<Startup> _factory;
        public
        GrupoInvestigacionIntegrationTest(GrupoInvestigacionWebApplicationFactory<Startup>
        factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAllAsyncShouldReturnAllGruposInvestigacion()
        {
            const int teamCount = 3;
            // arrange
            var repository =
            _factory.Server.Services.GetRequiredService<IGrupoInvestigacionRepository>();
            // act
            var teams = await repository.GetAllAsync();
            // assert
            teams.Should().HaveCount(teamCount);
        }

        [Fact]
        public async Task GetByIdForInvalidIdShouldReturnNull()
        {
            const int teamId = 300;
            // arrange
            var repository =
            _factory.Server.Services.GetRequiredService<IGrupoInvestigacionRepository>();
            // act
            var team = await repository.GetByIdAsync(teamId);
            // assert
            team.Should().BeNull();
        }

        [Fact]
        public async Task GetByIdForValidIdShouldReturnTeamWithRelatedData()
        {
            // arrange
            const string nombre = "Grupo02";
            const string descripcion = "Estudian Gusanos";
            const int coordinador = 2;
            const int teamId = 22;
            var repository =
            _factory.Server.Services.GetRequiredService<IGrupoInvestigacionRepository>();
            // act
            var team = await repository.GetByIdAsync(teamId);
            // assert
            team.Should().NotBeNull();
            team!.Nombre.Should().Be(nombre);
            team!.Descripcion.Should().Be(descripcion);
            team!.Coordinador.Should().Be(coordinador);
        }

    }
}
