using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Administrador
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<Gole> Goles { get; set; }
        public virtual DbSet<Jornada> Jornadas { get; set; }
        public virtual DbSet<Jugadore> Jugadores { get; set; }
        public virtual DbSet<Partido> Partidos { get; set; }
        public virtual DbSet<Sancione> Sanciones { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Clasificacion> Clasificacions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipos>()
                .HasMany(e => e.Partidos)
                .WithOptional(e => e.Equipos)
                .HasForeignKey(e => e.EquipoLocalID);

            modelBuilder.Entity<Equipos>()
                .HasMany(e => e.Partidos1)
                .WithOptional(e => e.Equipos1)
                .HasForeignKey(e => e.EquipoVisitanteID);
        }
    }
}
