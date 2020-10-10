using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{

    class Usuarios
    {

        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(4)]
        public String Nombre { get; set; }
        [Required]
        public String Clave { get; set; }



    }
}