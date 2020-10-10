using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1
{

    class Detalles
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public String Tiempo { get; set; }
        public int TareaId { get; set; }
        public Tareas Tarea { get; set; }
        public int RecursoId { get; set; }
        public Recursos Recurso { get; set; }

    }
}