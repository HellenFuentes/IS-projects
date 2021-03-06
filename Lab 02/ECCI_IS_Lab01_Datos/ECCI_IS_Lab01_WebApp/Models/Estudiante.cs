//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            this.Matriculas = new HashSet<Matricula>();
        }
    
        public int EstudianteID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaMatricula { get; set; }
        public string CorreoElectronico { get; set; }
        public string PaisId { get; set; }
        public string CiudadId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Matricula> Matriculas { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual Pai Pai { get; set; }
    }
}
