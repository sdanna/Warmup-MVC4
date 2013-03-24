namespace __NAME__.Components.Security
{
    public interface IPasswordSalter
    {
        string SaltPassword(string password, byte[] salt);
        bool ValidatePassword(string password, string goodHash);
    }
}