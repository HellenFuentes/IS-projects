﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECCI_IS_Lab01_WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ECCI_IS_Lab01_DatosEntities2 : DbContext
    {
        public ECCI_IS_Lab01_DatosEntities2()
            : base("name=ECCI_IS_Lab01_DatosEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Matricula> Matriculas { get; set; }
        public virtual DbSet<VistaMatricula> VistaMatriculas { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
    
        public virtual int Departamento_Insert(string nombre, Nullable<double> presupuesto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var presupuestoParameter = presupuesto.HasValue ?
                new ObjectParameter("Presupuesto", presupuesto) :
                new ObjectParameter("Presupuesto", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Insert", nombreParameter, presupuestoParameter);
        }
    }
}
