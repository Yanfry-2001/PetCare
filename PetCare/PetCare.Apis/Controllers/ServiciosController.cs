using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private static List<Servicio> servicios = new List<Servicio>();

        [HttpGet]
        public ActionResult<IEnumerable<Servicio>> GetServicios() => Ok(servicios);

        [HttpGet("{id}")]
        public ActionResult<Servicio> GetServicio(int id)
        {
            var servicio = servicios.FirstOrDefault(s => s.IdServicio == id);
            if (servicio == null) return NotFound();
            return Ok(servicio);
        }

        [HttpPost]
        public ActionResult<Servicio> PostServicio(Servicio servicio)
        {
            servicios.Add(servicio);
            return CreatedAtAction(nameof(GetServicio), new { id = servicio.IdServicio }, servicio);
        }

        [HttpPut("{id}")]
        public IActionResult PutServicio(int id, Servicio servicio)
        {
            var existing = servicios.FirstOrDefault(s => s.IdServicio == id);
            if (existing == null) return NotFound();

            existing.Nombre = servicio.Nombre;
            existing.Precio = servicio.Precio;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteServicio(int id)
        {
            var servicio = servicios.FirstOrDefault(s => s.IdServicio == id);
            if (servicio == null) return NotFound();

            servicios.Remove(servicio);
            return NoContent();
        }
    }
}
