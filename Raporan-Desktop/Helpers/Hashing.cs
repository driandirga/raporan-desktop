using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Raporan_Desktop.Helpers
{
    public class Hashing
    {
        public static string CheckPassword(string password, string salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20); // 20 is the size of the hash
                byte[] hashBytes = new byte[36]; // 16 for salt + 20 for hash

                // Combine the salt and hash bytes
                Array.Copy(Convert.FromBase64String(salt), 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // Convert the combined bytes to a base64 string
                return Convert.ToBase64String(hashBytes);
            }
        }
        
        public static (string hashedPassword, string salt) HashPasswordSalt(string password)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Create the Rfc2898DeriveBytes and get the hash value
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20); // 20 is the size of the hash
                byte[] hashBytes = new byte[36]; // 16 for salt + 20 for hash

                // Combine the salt and hash bytes
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                // Convert the combined bytes to a base64 string
                string base64Hash = Convert.ToBase64String(hashBytes);

                return (base64Hash, Convert.ToBase64String(salt));
            }
        }
    }
}
