using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Producto.Models
{
    public class DataContext:DbContext 

    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Producto.Models.Producto> Productoes { get; set; }

        
    }
}