using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP4.EntityFrameWork.Web.Models
{
    public class ShippersView
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [StringLength(25, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "telefono")]
        public string telefono { get; set; }
    }
}