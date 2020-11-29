using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int Id, string User, string Clave)
        {
            this.Id = Id;
            this.User = User;
            this.Clave = Clave;
        }
        public int Id { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }
    }
}
