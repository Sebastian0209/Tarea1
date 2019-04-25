using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_venta.Models
{
    public class Venta
    {
        [key]

        public int VentaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ProductoId { get; set; }
        [Required]
        public int ClienteId { get; set; }
    }
}