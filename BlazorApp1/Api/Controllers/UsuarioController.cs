using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Model.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

       [HttpGet]

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

       
       [HttpGet("{id}")]

       public Usuario Get(int id)
       {
           Usuario usuario =  _context.Usuarios.Where(i => i.Id == id).SingleOrDefault();
           return usuario;
       }

       [HttpPut]
        public Usuario EditUsuario(Usuario value)
       {
           Usuario usuarioeditar = _context.Usuarios.Find(value.Id);
           usuarioeditar.Clave = value.Clave;
           usuarioeditar.User = value.User;
           _context.SaveChanges();
           return value;
       }

        [HttpPost]
        public Usuario CreateUsuario(Usuario value)
        {
            _context.Usuarios.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Usuario DeleteUsuario(int id)
        {
            Usuario usuarioborrar = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuarioborrar);
            _context.SaveChanges();
            return usuarioborrar;
        }
    }
}
