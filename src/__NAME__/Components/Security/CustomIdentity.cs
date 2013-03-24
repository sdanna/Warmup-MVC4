using System.Security.Principal;

namespace __NAME__.Components.Security
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string email)
        {
            this.IsAuthenticated = true;
            this.Name = email;
            this.AuthenticationType = "Forms";
        }

        public string Name { get; private set; }

        public string AuthenticationType { get; private set; }

        public bool IsAuthenticated { get; private set; }
    }
}