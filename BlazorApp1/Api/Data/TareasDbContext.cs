using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=tareas.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuario>().Property(p => p.User).HasMaxLength(20);
            modelBuilder.Entity<Usuario>().Property(p => p.Clave).IsRequired();
            
            modelBuilder.Entity<Tarea>().ToTable("Tarea");
            modelBuilder.Entity<Tarea>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tarea>().Property(p => p.Titulo).HasMaxLength(20);
            modelBuilder.Entity<Tarea>().Property(p => p.Vencimiento).IsRequired();

            modelBuilder.Entity<Recurso>().ToTable("Recurso");
            modelBuilder.Entity<Recurso>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Recurso>().Property(p => p.Nombre).HasMaxLength(20);

            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Detalle>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Detalle>().Property(p => p.Fecha).IsRequired();
            modelBuilder.Entity<Detalle>().Property(p => p.Tiempo).IsRequired();
        
        }
        

    
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
    }
}
