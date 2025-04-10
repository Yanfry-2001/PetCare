using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;
public class Mascota
{
    [Key]
    public int IdMascota { get; set; }
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public string Raza { get; set; }
    public int Edad { get; set; }

    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; }

    public List<Cita> Citas { get; set; } = new();
}
