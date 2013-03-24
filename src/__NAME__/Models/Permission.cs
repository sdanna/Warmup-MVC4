using System.Collections.Generic;

namespace __NAME__.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Role> Roles { get; set; }
    }
}