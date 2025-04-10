using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;
public class Cita
{
    [Key]
    public int IdCita { get; set; }
    public DateTime FechaHora { get; set; }

    public int IdMascota { get; set; }
    public int  Mascota { get; set; }

    public int IdServicio { get; set; }
    public int Servicio { get; set; }

    public List<CitaProducto> CitaProductos { get; set; } = new();
}
