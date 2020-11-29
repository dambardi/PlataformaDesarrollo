using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entidades;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet("TareaId/{id}")]

        public List<Detalle> GetAll(int id)
        {
            return _context.Detalle.Include(i => i.Tarea).Where(i => i.TareaId == id).ToList();
        }

        [HttpGet("{id}")]

        public Detalle GetDetalle(int id)
        {
            Detalle detalle = _context.Detalle.Where(i => i.Id == id).FirstOrDefault();
            return detalle;
        }

        [HttpPut]
        public Detalle EditDetalle(Detalle value)
        {
            Detalle detalleeditar = _context.Detalle.Find(value.Id);
            detalleeditar.Fecha = value.Fecha;
            detalleeditar.Tiempo = value.Tiempo;
            detalleeditar.RecursoId = value.RecursoId;
            detalleeditar.TareaId = value.TareaId;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Detalle CreateDetalle(Detalle value)
        {
            _context.Detalle.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Detalle DeleteDetalle(int id)
        {
            Detalle detalleborrar = _context.Detalle.Find(id);
            _context.Detalle.Remove(detalleborrar);
            _context.SaveChanges();
            return detalleborrar;
        }


    }
}
