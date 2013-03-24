using System.Security.Principal;

namespace __NAME__.Components.Security
{
    public interface ICustomPrincipal : IPrincipal
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}