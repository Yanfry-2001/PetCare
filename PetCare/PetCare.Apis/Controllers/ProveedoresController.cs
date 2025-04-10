using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private static List<Proveedor> proveedores = new List<Proveedor>();

        [HttpGet]
        public ActionResult<IEnumerable<Proveedor>> GetProveedores() => Ok(proveedores);

        [HttpGet("{id}")]
        public ActionResult<Proveedor> GetProveedor(int id)
        {
            var proveedor = proveedores.FirstOrDefault(p => p.IdProveedor == id);
            if (proveedor == null) return NotFound();
            return Ok(proveedor);
        }

        [HttpPost]
        public ActionResult<Proveedor> PostProveedor(Proveedor proveedor)
        {
            proveedores.Add(proveedor);
            return CreatedAtAction(nameof(GetProveedor), new { id = proveedor.IdProveedor }, proveedor);
        }

        [HttpPut("{id}")]
        public IActionResult PutProveedor(int id, Proveedor proveedor)
        {
            var existing = proveedores.FirstOrDefault(p => p.IdProveedor == id);
            if (existing == null) return NotFound();

            existing.Nombre = proveedor.Nombre;
            existing.Telefono = proveedor.Telefono;
            existing.Email = proveedor.Email;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProveedor(int id)
        {
            var proveedor = proveedores.FirstOrDefault(p => p.IdProveedor == id);
            if (proveedor == null) return NotFound();

            proveedores.Remove(proveedor);
            return NoContent();
        }
    }
}
