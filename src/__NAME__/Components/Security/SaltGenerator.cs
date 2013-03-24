using System.Security.Cryptography;
using System.Text;

namespace __NAME__.Components.Security
{
    public class SaltGenerator : ISaltGenerator
    {
        public byte[] GenerateSaltValue(int length)
        {
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[length];
                cryptoProvider.GetBytes(saltBytes);

                return saltBytes;
            }
        }
    }
}