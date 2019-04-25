using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APItarea.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection2")
        {

        }

        public System.Data.Entity.DbSet<APItarea.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<APItarea.Models.Product> Products { get; set; }
    }
}