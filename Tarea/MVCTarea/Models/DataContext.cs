﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection3")
        {

        }

        public System.Data.Entity.DbSet<MVCTarea.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<MVCTarea.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVCTarea.Models.Ventas> Ventas { get; set; }
    }
}