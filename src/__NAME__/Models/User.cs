using System.Collections.Generic;

namespace __NAME__.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }

        public virtual List<Role> Roles { get; set; }
    }
}