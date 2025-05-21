namespace Administrador.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jugadores_sancionados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? id_jugador { get; set; }

        public int? Targeta_amarilla { get; set; }

        public int? Targeta_roja { get; set; }

        public virtual Jugadore Jugadore { get; set; }
    }
}
