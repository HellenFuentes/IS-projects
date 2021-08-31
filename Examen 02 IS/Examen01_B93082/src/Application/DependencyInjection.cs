using Microsoft.Extensions.DependencyInjection;
using Examen01_B93082.Application.Autores;
using Examen01_B93082.Application.Autores.Implementations;
using Examen01_B93082.Application.Investigadores;
using Examen01_B93082.Application.Investigadores.Implementations;
using Examen01_B93082.Application.Coordinadores;
using Examen01_B93082.Application.Coordinadores.Implementations;
using Examen01_B93082.Application.GruposInvestigacion;
using Examen01_B93082.Application.GruposInvestigacion.Implementations;
using Examen01_B93082.Application.ParticipanGrupoInvestigacion;
using Examen01_B93082.Application.ParticipanGrupoInvestigacion.Implementations;

namespace Examen01_B93082.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IAutorService, AutorService>();
            services.AddTransient<ICoordinadorService, CoordinadorService>();
            services.AddTransient<IInvestigadorService, InvestigadorService>();
            services.AddTransient<IGrupoInvestigacionService, GrupoInvestigacionService>();
            services.AddTransient<IParticipaGrupoInvestigacionService, ParticipaGrupoInvestigacionService>();
            return services;
        }
    }
}
