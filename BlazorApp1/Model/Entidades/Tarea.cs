using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class Tarea
    {
        public Tarea() { }
        public Tarea(int Id, string Titulo, DateTime Vencimiento, DateTime Estimacion, int ResponsableId, bool Estado)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.ResponsableId = ResponsableId;
            this.Estado = Estado;
        }

        

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime Estimacion { get; set; }
        public int ResponsableId { get; set; }
        public bool Estado { get; set; }
        
    }

}
