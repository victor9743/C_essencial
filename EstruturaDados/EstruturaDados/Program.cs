using System;
// bibliotecas utilizadas para usar o HASH
using System.Security.Cryptography;
using System.Text;

namespace EstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* HASH */
            string SourceData;

            byte[] tmpSource;
            byte[] tmpHash;

            SourceData = "1234";
            tmpSource = ASCIIEncoding.ASCII.GetBytes(SourceData);

            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            Console.WriteLine(ByteArrayToString(tmpHash));
            static string ByteArrayToString(byte[] arrInput)
            {
                int i;
                StringBuilder sOutput = new StringBuilder(arrInput.Length);
                for (i = 0; i < arrInput.Length; i++)
                {
                    sOutput.Append(arrInput[i].ToString("X2"));
                }
                return sOutput.ToString();
            }


        }
    }
}
