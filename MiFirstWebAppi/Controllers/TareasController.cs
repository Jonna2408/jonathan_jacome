using DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
//using MiFirstWebAppi.Data;
//using MiFirstWebAppi.Models;
using System.Threading;

namespace MiFirstWebAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private PruebaContext _context;

        public TareasController(PruebaContext context) { 
        
            _context = context;
        }

        [HttpGet]

        public IEnumerable<Tareas> Get() => _context.Tareas.ToList();

        [HttpGet("{idTarea}")]
        public async Task<IActionResult> Obtener(int idTarea)
        {
           
            Tareas tarea = _context.Tareas.Find(idTarea);
           
            return StatusCode(StatusCodes.Status200OK, tarea);
        }

       
        [HttpPost()]
        public async Task<IActionResult> Crear([FromBody] Tareas tarea)
        {
                      
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            
            _context.Tareas.Add(tarea);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status200OK, tarea);
        }

        [HttpPut("{idTarea}")]
        public async Task<IActionResult> Editar([FromBody] Tareas tarea, int idTarea)
        {
      

            if (idTarea != tarea.id)
            {
                return BadRequest(ModelState);
            }
            _context.Entry(tarea).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, tarea);
        }

        [HttpDelete("{idTarea}")]
        public async Task<IActionResult> Eliminar(int idTarea)
        {

            Tareas tarea = _context.Tareas.Find(idTarea);

            if (tarea == null) { 
            return NotFound();
            }
            _context.Tareas.Remove(tarea);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status200OK, tarea);
        }
    }
}
