using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;

namespace PetCare.Apis.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private static List<Cita> citas = new();
        private static int siguienteId = 1;

        // GET: api/citas
        [HttpGet]
        public ActionResult<IEnumerable<Cita>> Get()
        {
            return Ok(citas);
        }

        // GET: api/citas/{id}
        [HttpGet("{id}")]
        public ActionResult<Cita> Get(int id)
        {
            var cita = citas.FirstOrDefault(c => c.IdCita == id);
            if (cita == null)
                return NotFound();
            return Ok(cita);
        }

        // POST: api/citas
        [HttpPost]
        public ActionResult<Cita> Post([FromBody] Cita nuevaCita)
        {
            nuevaCita.IdCita = siguienteId++;
            citas.Add(nuevaCita);
            return CreatedAtAction(nameof(Get), new { id = nuevaCita.IdCita }, nuevaCita);
        }

        // PUT: api/citas/{id}
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cita citaActualizada)
        {
            var cita = citas.FirstOrDefault(c => c.IdCita == id);
            if (cita == null)
                return NotFound();

            cita.FechaHora = citaActualizada.FechaHora;
            cita.IdMascota = citaActualizada.IdMascota;
            cita.Mascota = citaActualizada.Mascota;
            cita.IdServicio = citaActualizada.IdServicio;
            cita.Servicio = citaActualizada.Servicio;
            cita.CitaProductos = citaActualizada.CitaProductos;

            return NoContent();
        }

        // DELETE: api/citas/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cita = citas.FirstOrDefault(c => c.IdCita == id);
            if (cita == null)
                return NotFound();

            citas.Remove(cita);
            return NoContent();
        }
    }
}
