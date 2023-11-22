using System.Text;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Fall_Protection.Extensions
{
    public static class BCryptExtension
    {
        private const int BCryptWorkFactor = 12;

        public static byte[] HashPassword(string password)
        {
            var stringHash = BCryptNet.HashPassword(password, BCryptWorkFactor);
            return Encoding.ASCII.GetBytes(stringHash);
        }

        public static bool Verify(string password, byte[] hashedPasswordBytes)
        {
            var stringHash = Encoding.ASCII.GetString(hashedPasswordBytes);
            return BCryptNet.Verify(password, stringHash);
        }
    }
}
