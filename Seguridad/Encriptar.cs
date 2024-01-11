using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Seguridad
{
    public class Encriptar
    {
        public string GenerarMD5(string loginContraseña)
        {
            try
            {
                UnicodeEncoding codigosecreto = new UnicodeEncoding();

                byte[] ByteText = codigosecreto.GetBytes(loginContraseña);

                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

                byte[] ByteHash = MD5.ComputeHash(ByteText);

                return Convert.ToBase64String(ByteHash);
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
