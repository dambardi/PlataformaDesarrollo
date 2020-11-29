using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Recurso
    {
        public Recurso() { }
        public Recurso(int Id, string Nombre, Usuario Usuario)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Usuario = Usuario;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}

