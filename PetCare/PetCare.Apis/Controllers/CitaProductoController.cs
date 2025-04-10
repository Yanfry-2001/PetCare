using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaProductosController : ControllerBase
    {
        private static List<CitaProducto> citaProductos = new List<CitaProducto>();

        [HttpGet]
        public ActionResult<IEnumerable<CitaProducto>> GetCitaProductos()
        {
            return Ok(citaProductos);
        }

        [HttpGet("{id}")]
        public ActionResult<CitaProducto> GetCitaProducto(int id)
        {
            var citaProducto = citaProductos.FirstOrDefault(cp => cp.IdCitaProducto == id);
            if (citaProducto == null) return NotFound();
            return Ok(citaProducto);
        }

        [HttpPost]
        public ActionResult<CitaProducto> PostCitaProducto(CitaProducto citaProducto)
        {
            citaProductos.Add(citaProducto);
            return CreatedAtAction(nameof(GetCitaProducto), new { id = citaProducto.IdCitaProducto }, citaProducto);
        }

        [HttpPut("{id}")]
        public IActionResult PutCitaProducto(int id, CitaProducto citaProducto)
        {
            var existing = citaProductos.FirstOrDefault(cp => cp.IdCitaProducto == id);
            if (existing == null) return NotFound();

            existing.IdCita = citaProducto.IdCita;
            existing.IdProducto = citaProducto.IdProducto;
            existing.Cantidad = citaProducto.Cantidad;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCitaProducto(int id)
        {
            var citaProducto = citaProductos.FirstOrDefault(cp => cp.IdCitaProducto == id);
            if (citaProducto == null) return NotFound();

            citaProductos.Remove(citaProducto);
            return NoContent();
        }
    }
}
