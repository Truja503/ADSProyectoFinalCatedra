namespace Administrador.Modelo
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
            Jugadores_sancionados = new HashSet<Jugadores_sancionados>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? id_equipo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int Numero { get; set; }

        public int? Goles { get; set; }

        public virtual Equipos Equipos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jugadores_sancionados> Jugadores_sancionados { get; set; }
    }
}
