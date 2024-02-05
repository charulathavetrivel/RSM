using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RSM.Data
{
    public class RSMDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RSMDbContext() : base("name=RSMDbContext")
        {
        }

        public System.Data.Entity.DbSet<RSM.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<RSM.Models.Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<RSM.Models.Class> Classes { get; set; }
    }
}
