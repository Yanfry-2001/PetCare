using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;
public class Producto
{
    [Key]
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public float Precio { get; set; }
    public int Stock { get; set; }

    public int IdProveedor { get; set; }
    public Proveedor Proveedor { get; set; }

    public List<CitaProducto> CitaProductos { get; set; } = new();
}
