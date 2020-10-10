using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Insertar();

            Consultar();

            //Actualizar();

            //Borrar();

            Console.WriteLine("Parcial 1");

        }


        static void Insertar()
        {
            var ctx = new TareasDbContext();
            ctx.Usuario.Add(new Usuarios { Id = 1, Nombre = "Damian", Clave = "12345" });

            ctx.Add(new Usuarios() { Id = 2, Nombre = "Gonzalo", Clave = "43215" });
            ctx.Add(new Usuarios() { Id = 3, Nombre = "Marcelo", Clave = "56785" });


            ctx.SaveChanges();
        }

        static void Actualizar()
        {

            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.Where(i => i.Id == 1).ToList();
            lista[0].Nombre = "Dante";

            ctx.SaveChanges();

        }

        static void Borrar()
        {
            var ctx = new TareasDbContext();

            var user = ctx.Usuario.Where(i => i.Id == 1).Single();
            ctx.Usuario.Remove(user);

            ctx.SaveChanges();
        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuario.ToList();
            foreach (var users in lista)
            {
                Console.WriteLine($"Nombre: {users.Nombre} ({users.Id})");
            }
        }
    }


}