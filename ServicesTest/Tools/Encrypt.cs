using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ServicesTest.Tools
{
    public static class Encrypt
    {
        public static string encryptPass(String message) {
            byte[] hashValue;

            //Convierto desde codificación UTF8
            UTF8Encoding ue = new UTF8Encoding();

            //Convierto el string a un flujo de bytes
            byte[] messageBytes = ue.GetBytes(message);

            //Utilizo SHA256 para calcular un hash
            SHA256 shHash = SHA256.Create();


            //Calculo el hash del mensaje en bytes...
            hashValue = shHash.ComputeHash(messageBytes);
            //var bytesEncrypted = Cipher.Encrypt(messageBytes, hashValue);
            string passEncrypted = Convert.ToBase64String(hashValue);
            return passEncrypted;
        }


        public static decimal DVHCalculate(string message) {
            byte[] hashValue;
            //Convierto desde codificación UTF8
            UTF8Encoding ue = new UTF8Encoding();

            //Convierto el string a un flujo de bytes
            byte[] messageBytes = ue.GetBytes(message);

            //Utilizo SHA256 para calcular un hash
            SHA256 shHash = SHA256.Create();

            //Calculo el hash del mensaje en bytes...
            hashValue = shHash.ComputeHash(messageBytes);

            decimal valor = hashValue.Sum(o => o);
            return valor;


        }

        public static decimal DVVCalculate(decimal DVH)
        {
            
            return 1;


        }



    }
}
