using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>();

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos() => Ok(productos);

        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> PostProducto(Producto producto)
        {
            productos.Add(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = producto.IdProducto }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult PutProducto(int id, Producto producto)
        {
            var existing = productos.FirstOrDefault(p => p.IdProducto == id);
            if (existing == null) return NotFound();

            existing.Nombre = producto.Nombre;
            existing.Precio = producto.Precio;
            existing.Stock = producto.Stock;
            existing.IdProveedor = producto.IdProveedor;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto == null) return NotFound();

            productos.Remove(producto);
            return NoContent();
        }
    }
}
