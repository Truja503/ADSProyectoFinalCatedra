using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Administrador.Modelo
{
    public partial class bddFutbol : DbContext
    {
        public bddFutbol()
            : base("name=bddFutbol")
        {
        }

        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<Jornada> Jornadas { get; set; }
        public virtual DbSet<Jugadore> Jugadores { get; set; }
        public virtual DbSet<Jugadores_sancionados> Jugadores_sancionados { get; set; }
        public virtual DbSet<Partido> Partidos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<most_sanctioned_view> most_sanctioned_view { get; set; }
        public virtual DbSet<Top_Goleadores> Top_Goleadores { get; set; }
        public virtual DbSet<Vista_Puntos_Equipos> Vista_Puntos_Equipos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Equipos>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Equipos>()
                .HasMany(e => e.Jugadores)
                .WithOptional(e => e.Equipos)
                .HasForeignKey(e => e.id_equipo);

            modelBuilder.Entity<Equipos>()
                .HasMany(e => e.Partidos)
                .WithOptional(e => e.Equipos)
                .HasForeignKey(e => e.id_equipo_local);

            modelBuilder.Entity<Equipos>()
                .HasMany(e => e.Partidos1)
                .WithOptional(e => e.Equipos1)
                .HasForeignKey(e => e.id_equipo_visitante);

            modelBuilder.Entity<Jornada>()
                .HasMany(e => e.Partidos)
                .WithOptional(e => e.Jornada1)
                .HasForeignKey(e => e.id_jornada);

            modelBuilder.Entity<Jugadore>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Jugadore>()
                .HasMany(e => e.Jugadores_sancionados)
                .WithOptional(e => e.Jugadore)
                .HasForeignKey(e => e.id_jugador);

            modelBuilder.Entity<Partido>()
                .HasMany(e => e.Jornadas)
                .WithOptional(e => e.Partido)
                .HasForeignKey(e => e.id_partidos);

            modelBuilder.Entity<most_sanctioned_view>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Top_Goleadores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Vista_Puntos_Equipos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
