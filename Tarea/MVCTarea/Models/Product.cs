using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{


    public enum UnitType
    {
        Botella,
        Litro,
        Caja,
        Kilogramos
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [Required]
        public UnitType Unidad { get; set; }

       


    }
}