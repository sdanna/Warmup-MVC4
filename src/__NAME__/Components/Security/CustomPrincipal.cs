using System.Security.Principal;

using Newtonsoft.Json;

namespace __NAME__.Components.Security
{
    public class CustomPrincipal : ICustomPrincipal
    {
        public CustomPrincipal(string email)
        {
            this.Identity = new CustomIdentity(email);
            this.Email = email;
        }

        public bool IsInRole(string role)
        {
            return false;
        }

        [JsonIgnore]
        public IIdentity Identity { get; private set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}