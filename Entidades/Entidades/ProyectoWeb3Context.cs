using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entidades.Entidades
{
    public partial class ProyectoWeb3Context : DbContext
    {
        public ProyectoWeb3Context()
        {
        }

        public ProyectoWeb3Context(DbContextOptions<ProyectoWeb3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Grupo> Grupos { get; set; } = null!;
        public virtual DbSet<Partido> Partidos { get; set; } = null!;
        public virtual DbSet<Seleccion> Seleccions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=ProyectoWeb3;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("Grupo");

                entity.Property(e => e.Grupo1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Grupo")
                    .IsFixedLength();

                entity.HasOne(d => d.IdSeleccion1Navigation)
                    .WithMany(p => p.GrupoIdSeleccion1Navigations)
                    .HasForeignKey(d => d.IdSeleccion1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeleccionGrupo1");

                entity.HasOne(d => d.IdSeleccion2Navigation)
                    .WithMany(p => p.GrupoIdSeleccion2Navigations)
                    .HasForeignKey(d => d.IdSeleccion2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeleccionGrupo2");

                entity.HasOne(d => d.IdSeleccion3Navigation)
                    .WithMany(p => p.GrupoIdSeleccion3Navigations)
                    .HasForeignKey(d => d.IdSeleccion3)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeleccionGrupo3");

                entity.HasOne(d => d.IdSeleccion4Navigation)
                    .WithMany(p => p.GrupoIdSeleccion4Navigations)
                    .HasForeignKey(d => d.IdSeleccion4)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeleccionGrupo4");
            });

            modelBuilder.Entity<Partido>(entity =>
            {
                entity.HasKey(e => e.IdPartido);

                entity.ToTable("Partido");

                entity.HasOne(d => d.IdSeleccion1Navigation)
                    .WithMany(p => p.PartidoIdSeleccion1Navigations)
                    .HasForeignKey(d => d.IdSeleccion1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seleccion1");

                entity.HasOne(d => d.IdSeleccion2Navigation)
                    .WithMany(p => p.PartidoIdSeleccion2Navigations)
                    .HasForeignKey(d => d.IdSeleccion2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seleccion2");
            });

            modelBuilder.Entity<Seleccion>(entity =>
            {
                entity.HasKey(e => e.IdSeleccion);

                entity.ToTable("Seleccion");

                entity.Property(e => e.Confederacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Seleccion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Seleccion");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
