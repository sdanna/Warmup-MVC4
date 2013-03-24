using System.Collections.Generic;

namespace __NAME__.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
        public virtual List<Permission> Permissions { get; set; }
    }
}