namespace Administrador.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Top_Goleadores
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "text")]
        public string nombre { get; set; }

        public long? id_equipo { get; set; }

        public int? goles { get; set; }
    }
}
