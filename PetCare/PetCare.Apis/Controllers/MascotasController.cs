using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotasController : ControllerBase
    {
        private static List<Mascota> mascotas = new List<Mascota>();

        [HttpGet]
        public ActionResult<IEnumerable<Mascota>> GetMascotas()
        {
            return Ok(mascotas);
        }

        [HttpGet("{id}")]
        public ActionResult<Mascota> GetMascota(int id)
        {
            var mascota = mascotas.FirstOrDefault(m => m.IdMascota == id);
            if (mascota == null) return NotFound();
            return Ok(mascota);
        }

        [HttpPost]
        public ActionResult<Mascota> PostMascota(Mascota mascota)
        {
            mascotas.Add(mascota);
            return CreatedAtAction(nameof(GetMascota), new { id = mascota.IdMascota }, mascota);
        }

        [HttpPut("{id}")]
        public IActionResult PutMascota(int id, Mascota mascota)
        {
            var existingMascota = mascotas.FirstOrDefault(m => m.IdMascota == id);
            if (existingMascota == null) return NotFound();

            existingMascota.Nombre = mascota.Nombre;
            existingMascota.Especie = mascota.Especie;
            existingMascota.Raza = mascota.Raza;
            existingMascota.Edad = mascota.Edad;
            existingMascota.IdCliente = mascota.IdCliente;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMascota(int id)
        {
            var mascota = mascotas.FirstOrDefault(m => m.IdMascota == id);
            if (mascota == null) return NotFound();

            mascotas.Remove(mascota);
            return NoContent();
        }
    }
}
