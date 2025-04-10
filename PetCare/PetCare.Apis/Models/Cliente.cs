using System.ComponentModel.DataAnnotations;

namespace PetCare.Apis.Models;

public class Cliente
{
    [Key]
    public int IdCliente { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public List<Mascota> Mascotas { get; set; } = new();
}

