using Microsoft.AspNetCore.Mvc;
using PetCare.Apis.Models;


namespace PetCare.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> PostCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.IdCliente }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, Cliente cliente)
        {
            var existingCliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (existingCliente == null) return NotFound();

            existingCliente.Nombre = cliente.Nombre;
            existingCliente.Telefono = cliente.Telefono;
            existingCliente.Email = cliente.Email;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null) return NotFound();

            clientes.Remove(cliente);
            return NoContent();
        }
    }
}
