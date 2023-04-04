using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashLogin
{

    
    internal class HashInput //hashing algorithm from code-maze.com
    {
        DatabaseConnection db = new DatabaseConnection();
        const int keySize = 64;
        const int iterations = 350000;
        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        
        public string hashInput(TextBox username, TextBox password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password.Text),
                salt,
                iterations,
                hashAlgorithm,
                keySize);


            db.addUser(username, password, Convert.ToHexString(hash), salt);
            //store username, salt, and hashed password

            return Convert.ToHexString(hash);
        }

        public bool VerifyPassword(string password, string hash, byte[] salt)//hashing algorithm from code-maze.com
        {
            //use salt and old hash to verify password
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgorithm, keySize);
            return hashToCompare.SequenceEqual(Convert.FromHexString(hash));
        }
    }

}