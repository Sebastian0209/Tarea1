using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Cliente.Models
{
    public class DataContext:DbContext 

    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Cliente.Models.Cliente> Clientes { get; set; }
    }
}