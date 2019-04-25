using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public class Ventas
    {
        [Key]
        public int VentasID { get; set; }
        public int ClientID { get; set; }
        public int ProductId { get; set; }
        public string Fecha { get; set; }

    }
}