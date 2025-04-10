using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetCare.Apis.Models;
public class CitaProducto
{
    [Key]
    public int IdCitaProducto {  get; set; }
    [Required]
    [ForeignKey ("Cita")]
    public int IdCita { get; set; }
    public Cita Cita { get; set; }
    [Required]
    [ForeignKey("Producto")]
    public int IdProducto { get; set; }
    public int  Producto { get; set; }

    public int Cantidad { get; set; }
}
