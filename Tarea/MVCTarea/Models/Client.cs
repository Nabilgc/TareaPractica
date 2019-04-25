using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public enum StatusType
    {
        Activo,
        Inactivo
    }

    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        [Display(Name = "Client Name")]

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public StatusType Status { get; set; }

    }
}