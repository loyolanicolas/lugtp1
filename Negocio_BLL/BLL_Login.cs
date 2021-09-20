using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using System.Security.Cryptography;

namespace Negocio_BLL
{
    public class BLL_Login
    {
        MPP_Login o_MPP_Login;

        public BLL_Login()
        {
            o_MPP_Login = new MPP_Login();
        }

        public bool Loguear(string oBEUsuario, string oBEPassEncriptado)
        {
            return o_MPP_Login.Loguear(oBEUsuario, oBEPassEncriptado);
        }

        public string AplicarHash(string Pass)
        {
            if (string.IsNullOrEmpty(Pass))
                return "";

            var Provider = new SHA1CryptoServiceProvider();
            var Encoding = new UnicodeEncoding();
            return Convert.ToBase64String(Provider.ComputeHash(Encoding.GetBytes(Pass)));
        }


        public string Encriptar(string Texto)
        {
            byte[] IV = ASCIIEncoding.ASCII.GetBytes("S3rCry21"); // La clave debe ser de 8 caracteres  
            byte[] EncryptionKey = Convert.FromBase64String("Jgas/asdflF3FJ4RAPt2GlkkyoaR4tTs"); // No se puede alterar la cantidad de caracteres pero si la clave  
            byte[] buffer = Encoding.UTF8.GetBytes(Texto);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;

            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }


        public string Desencriptar(string Texto)
        {
            byte[] IV = ASCIIEncoding.ASCII.GetBytes("S3rCry21"); // La clave debe ser de 8 caracteres  
            byte[] EncryptionKey = Convert.FromBase64String("Jgas/asdflF3FJ4RAPt2GlkkyoaR4tTs"); // No se puede alterar la cantidad de caracteres pero si la clave  
            byte[] buffer = Convert.FromBase64String(Texto);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;
            return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }
    }
}
