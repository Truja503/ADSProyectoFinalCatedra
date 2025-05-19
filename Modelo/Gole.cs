namespace Administrador.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gole
    {
        [Key]
        public int GolID { get; set; }

        public int? PartidoID { get; set; }

        public int? JugadorID { get; set; }

        public virtual Jugadore Jugadore { get; set; }

        public virtual Partido Partido { get; set; }
    }
}
