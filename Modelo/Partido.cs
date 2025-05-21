namespace Administrador.Modelo
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
            Jornadas = new HashSet<Jornada>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? id_equipo_local { get; set; }

        public long? id_equipo_visitante { get; set; }

        public int? Goles_local { get; set; }

        public int? Goles_visitante { get; set; }

        public int? Jornada { get; set; }

        public int? Targeta_amarilla { get; set; }

        public int? Targeta_roja { get; set; }

        public long? id_jornada { get; set; }

        public virtual Equipos Equipos { get; set; }

        public virtual Equipos Equipos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jornada> Jornadas { get; set; }

        public virtual Jornada Jornada1 { get; set; }
    }
}
