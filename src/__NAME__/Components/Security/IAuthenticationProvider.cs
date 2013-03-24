using System;
using System.Security.Principal;
using System.Web;
using System.Web.Script.Serialization;

namespace __NAME__.Components.Security
{
    public interface IAuthenticationProvider<T> : IDisposable where T : IPrincipal
    {
        T ValidateCredentials(string username, string password);
        T ValidateCredentials(string token);
        void Logon(T principal, HttpResponseBase response);
        void Logoff();
    }
}