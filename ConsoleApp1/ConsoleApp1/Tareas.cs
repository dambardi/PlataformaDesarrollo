using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tareas
    {

        public Tareas() { }
       
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int ResponsableId { get; set; }
        public Recursos Responsable { get; set; }
        public Boolean Estado { get; set; }
        public int TipoId { get; set; }


    }
}