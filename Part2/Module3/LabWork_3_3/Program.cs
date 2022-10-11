using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20) Invoke methods and print results
            Crypto object1 = new Crypto();

            object1.Crypting("Crypting method");

            bool checkResult = object1.Check("D:\\EncreptedText.txt", "Crypting method");

            Console.WriteLine(checkResult);

            string text = "Text";
            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            byte[] publicKey = null;

            byte[] signature = object1.Signaturing(CngAlgorithm.ECDsaP256, text, ref publicKey);

            string sign = string.Join(" ", signature.Select(x => x.ToString("x2")));

            Console.WriteLine(sign);

            CngKey signatureKey = CngKey.Create(CngAlgorithm.ECDsaP256);

            

            byte[] signatureToBeChecked = signature;

            bool signVerify = object1.VerifySignature(textBytes, signature, publicKey);

            Console.WriteLine(signVerify);


            Console.ReadKey();
        }
    }
}