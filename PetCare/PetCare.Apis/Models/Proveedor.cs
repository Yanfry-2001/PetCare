using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;
public class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public List<Producto> Productos { get; set; } = new();
}
