using System;
using System.Linq;
using System.Web;
using System.Web.Security;

using __NAME__.Models;

using Newtonsoft.Json;

namespace __NAME__.Components.Security
{
    public class AuthenticationProvider : IAuthenticationProvider<CustomPrincipal>, IDisposable
    {
        private Context _context;
        private IPasswordSalter _passwordSalter;

        private bool _disposed;

        public AuthenticationProvider(Context context,
                                      IPasswordSalter passwordSalter)
        {
            this._context = context;
            _passwordSalter = passwordSalter;
        }

        public CustomPrincipal ValidateCredentials(string username, string password)
        {
            /*
             1.  Retrieve the user's salt and hash from the database.
             2.  Prepend the salt to the given password and hash it using the same hash function.
             3.  Compare the hash of the given password with the hash from the database. If they match, the password is correct. Otherwise, the password is incorrect.
             */

            var user = this._context.Users.FirstOrDefault(x => x.Email == username);
            if (user == null)
                return null;

            bool passwordIsValid = _passwordSalter.ValidatePassword(password, user.Password);
            if (!passwordIsValid)
                return null;

            var principal = new CustomPrincipal(user.Email);
            principal.UserId = user.Id;
            principal.FirstName = user.FirstName ?? "";
            principal.LastName = user.LastName ?? "";
            principal.Email = user.Email;

            return principal;
        }

        public CustomPrincipal ValidateCredentials(string token)
        {
            return new CustomPrincipal(string.Empty);
        }

        public void Logon(CustomPrincipal principal, HttpResponseBase response)
        {
            string userData = JsonConvert.SerializeObject(principal);

            var authTicket = new FormsAuthenticationTicket(
                1,
                principal.Email,
                DateTime.Now,
                DateTime.Now.AddMinutes(15),
                false,
                userData
                );

            string ecryptedTicket = FormsAuthentication.Encrypt(authTicket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, ecryptedTicket);
            response.Cookies.Add(cookie);
        }

        public void Logoff()
        {
            FormsAuthentication.SignOut();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (this._context != null)
                    {
                        this._context.Dispose();
                        this._context = null;
                    }
                }
            }
            _disposed = true;
        }
    }
}