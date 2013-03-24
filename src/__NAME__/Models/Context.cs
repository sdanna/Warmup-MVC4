using System;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace __NAME__.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}