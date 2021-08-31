using System.Net.Mime;
using Examen01_B93082.Domain.Autores.Repositories;
using Examen01_B93082.Infrastructure.Autores.Repositories;
using Examen01_B93082.Infrastructure.Autores;
using Examen01_B93082.Domain.Investigadores.Repositories;
using Examen01_B93082.Infrastructure.Investigadores.Repositories;
using Examen01_B93082.Infrastructure.Investigadores;
using Examen01_B93082.Domain.Coordinadores.Repositories;
using Examen01_B93082.Infrastructure.Coordinadores.Repositories;
using Examen01_B93082.Infrastructure.Coordinadores;
using Examen01_B93082.Domain.GruposInvestigacion.Repositories;
using Examen01_B93082.Infrastructure.GruposInvestigacion.Repositories;
using Examen01_B93082.Infrastructure.GruposInvestigacion;
using Examen01_B93082.Domain.ParticipanGrupoInvestigacion.Repositories;
using Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion.Repositories;
using Examen01_B93082.Infrastructure.ParticipanGrupoInvestigacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Examen01_B93082.Infrastructure
{
    public static class DependencyInjection
    {
       public static IServiceCollection AddInfrastructureLayer(
       this IServiceCollection services,
       string connectionString) {
            services.AddDbContext<AutoresDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IAutorRepository, AutorRepository>();
            services.AddDbContext<InvestigadoresDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IInvestigadorRepository, InvestigadorRepository>();
            services.AddDbContext<CoordinadoresDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<ICoordinadorRepository, CoordinadorRepository>();
            services.AddDbContext<GrupoInvestigacionDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IGrupoInvestigacionRepository, GrupoInvestigacionRepository>();
            services.AddDbContext<ParticipaGrupoInvestigacionDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IParticipaGrupoInvestigacionRepository, ParticipaGrupoInvestigacionRepository>();
            return services;
        }
    }
}
