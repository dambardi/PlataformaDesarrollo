using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        class TareasDbContext : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlite("Data Source=tareas.db");

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Usuarios>().ToTable("Usuario");
                modelBuilder.Entity<Usuarios>().Property(p => p.Id).ValueGeneratedOnAdd();
                modelBuilder.Entity<Usuarios>().Property(p => p.Nombre).HasMaxLength(30);
                modelBuilder.Entity<Usuarios>().Property(p => p.Clave).IsRequired();

                modelBuilder.Entity<Tareas>().ToTable("Tarea");
                modelBuilder.Entity<Tareas>().Property(p => p.Id).ValueGeneratedOnAdd();
                modelBuilder.Entity<Tareas>().Property(p => p.Titulo).HasMaxLength(20);
                modelBuilder.Entity<Tareas>().Property(p => p.Vencimiento).IsRequired();

                modelBuilder.Entity<Detalles>().ToTable("Detalle");
                modelBuilder.Entity<Detalles>().Property(p => p.Id).ValueGeneratedOnAdd();
                modelBuilder.Entity<Detalles>().Property(p => p.Fecha).IsRequired();
                modelBuilder.Entity<Detalles>().Property(p => p.Tiempo).IsRequired();

                modelBuilder.Entity<Recursos>().ToTable("Recurso");
                modelBuilder.Entity<Recursos>().Property(p => p.Id).ValueGeneratedOnAdd();
                modelBuilder.Entity<Recursos>().Property(p => p.Nombre).HasMaxLength(20);

            }

            public DbSet<Detalles> Detalle { get; set; }
            public DbSet<Tareas> Tarea { get; set; }
            public DbSet<Recursos> Recurso { get; set; }
            public DbSet<Usuarios> Usuario { get; set; }
        }

}