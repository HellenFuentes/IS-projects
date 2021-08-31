using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen01_B93082.Data.Entities;

namespace Examen01_B93082.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }

        public DbSet<Autores> Autores { get; set; }
        public DbSet<AutoresDePub> AutoresDePub { get; set; }
        public DbSet<Coordinador> Coordinador { get; set; }
        public DbSet<GruposInvestigacion> GrupoInvestigacion { get; set; }
        public DbSet<Investigador> Investigador { get; set; }
        public DbSet<ProyectoInvestigacion> ProyectoInvestigacion { get; set; }
        public DbSet<Publicaciones> Publicaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoresDePub>().HasKey(a => new { a.IdAutor, a.DoiPub });
            base.OnModelCreating(modelBuilder);
        }
    }
}
