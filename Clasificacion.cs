namespace Administrador
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Clasificacion")]
    public partial class Clasificacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EquipoID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int? PJ { get; set; }

        public int? PG { get; set; }

        public int? PE { get; set; }

        public int? PP { get; set; }

        public int? GF { get; set; }

        public int? GC { get; set; }

        public int? DG { get; set; }

        public int? Puntos { get; set; }
    }
}
