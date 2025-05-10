using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using RpgApi.Models;
=======
>>>>>>> b9b6d0615b1e88cc530d227234a60db90d7de33a

namespace RpgApi.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
<<<<<<< HEAD

        public static bool VerificarPasswordHash(string password, byte[] hash, byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var computedHash =
                hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        

    }       
}
=======
    }
}
>>>>>>> b9b6d0615b1e88cc530d227234a60db90d7de33a
