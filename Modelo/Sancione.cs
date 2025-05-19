namespace Administrador.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sancione
    {
        [Key]
        public int SancionID { get; set; }

        public int? PartidoID { get; set; }

        public int? JugadorID { get; set; }

        [StringLength(10)]
        public string Tipo { get; set; }

        public virtual Jugadore Jugadore { get; set; }

        public virtual Partido Partido { get; set; }
    }
}
