using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;
public class Servicio
{
    [Key]
    public int IdServicio { get; set; }
    public string Nombre { get; set; }
    public float Precio { get; set; }

    public List<Cita> Citas { get; set; } = new();
}
