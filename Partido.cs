namespace Administrador
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partidos")]
    public partial class Partido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partido()
        {
            Goles = new HashSet<Gole>();
            Sanciones = new HashSet<Sancione>();
        }

        public int PartidoID { get; set; }

        public int? JornadaID { get; set; }

        public int? EquipoLocalID { get; set; }

        public int? EquipoVisitanteID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public int? GolesLocal { get; set; }

        public int? GolesVisitante { get; set; }

        [StringLength(20)]
        public string Estado { get; set; }

        public virtual Equipos Equipos { get; set; }

        public virtual Equipos Equipos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gole> Goles { get; set; }

        public virtual Jornada Jornada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sancione> Sanciones { get; set; }
    }
}
