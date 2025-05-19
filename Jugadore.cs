namespace Administrador
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jugadore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jugadore()
        {
            Goles = new HashSet<Gole>();
            Sanciones = new HashSet<Sancione>();
        }

        [Key]
        public int JugadorID { get; set; }

        public int? EquipoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int Numero { get; set; }

        public virtual Equipos Equipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gole> Goles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sancione> Sanciones { get; set; }
    }
}
