using MVC_Cliente.Models;
using MVC_Producto.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Cliente.Models
{
    public class Cliente
    {

     [key]

     public int ClienteId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Correo { get; set; }
    }
}