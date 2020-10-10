using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Recursos
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }

    }
}