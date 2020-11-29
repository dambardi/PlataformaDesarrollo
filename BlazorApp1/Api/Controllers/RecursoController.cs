using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Model.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public RecursoController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Recurso> GetAll()
        {
            return _context.Recurso.ToList();
        }

        [HttpGet("{id}")]

        public Recurso GetRecurso(int id)
        {
            Recurso recurso = _context.Recurso.Where(i => i.Id == id).SingleOrDefault();
            return recurso;
        }

        [HttpPut]
        public Recurso EditRecurso(Recurso value)
        {
            Recurso recursoeditar = _context.Recurso.Find(value.Id);
            recursoeditar.Nombre = value.Nombre;
            recursoeditar.UsuarioId = value.UsuarioId;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Recurso CreateTarea(Recurso value)
        {
            _context.Recurso.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Recurso DeleteRecurso(int id)
        {
            Recurso recursoborrar = _context.Recurso.Find(id);
            _context.Recurso.Remove(recursoborrar);
            _context.SaveChanges();
            return recursoborrar;
        }
    }
}
