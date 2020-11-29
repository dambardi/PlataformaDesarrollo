using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entidades
{
    public class Detalle
    {
        public Detalle() { }
        public Detalle(int Id, DateTime Fecha, DateTime Tiempo,Recurso Recurso, Tarea Tarea, int TareaId )
        {
            this.Id = Id;
            this.Fecha = Fecha;
            this.Tiempo = Tiempo;
            this.Recurso = Recurso;
            this.Tarea = Tarea;
            this.TareaId = TareaId;
        }


        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public int RecursoId { get; set; }
        public Tarea Tarea { get; set; }
        public int TareaId { get; set; }
    }
}
