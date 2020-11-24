using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCE_Server
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("conString")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
    }

   
}
