using System.Text;

namespace ServiceStation.AuthExtensions
{
    public static class PasswordExtensions
    {
        public static string EncryptPassword(this string hashPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(hashPassword);
        }

        public static bool VerifyPassword(this string hashPassword, string storedPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(hashPassword, storedPassword);
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static string ComputeHash(this string input)
        {
            using var sha256Hash = System.Security.Cryptography.SHA256.Create();

            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            foreach (var t in bytes)
            {
                builder.Append(t.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
