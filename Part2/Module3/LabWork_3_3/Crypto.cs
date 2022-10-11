using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3_3
{
    class Crypto
    {
        // 1) Change parameters in method and returned type
        public void Crypting(string text)
        {
            // 2) Create crypto provider object
            // use class MD5CryptoServiceProvider
            MD5 mdProvider = MD5CryptoServiceProvider.Create();

            // 3) Create crypto hash by invoking method ComputeHash() of class MD5CryptoServiceProvider
            byte[] bytes = mdProvider.ComputeHash(Encoding.ASCII.GetBytes(text));

            // 4) Add encrypted data to new string in hexadesimal form
            string newStr = string.Join(" ", bytes.Select(x => x.ToString("x2")));

            // Note1: use array of bytes as encrypted value (convert string to byte and vise versa)

            // Note2: use numeric format "x" to represent data in hexadesimal form. 
            // Number of digits in in the result string must be 2 (use precision)


            // 5) Save encrypted data to file
            string path = @"D:\EncreptedText.txt";
            File.WriteAllText(path, newStr);
        

        }


        // 6) Change parameters in method and returned type

        public bool Check(string path, string text)
        {
            // 7) Create crypto provider object
            // use class MD5CryptoServiceProvider
            MD5 mdProvider = MD5CryptoServiceProvider.Create();

            // 8) Create crypto hash by invoking method ComputeHash() of class MD5CryptoServiceProvider
            byte[] bytes = mdProvider.ComputeHash(Encoding.ASCII.GetBytes(text));

            // 9) Add encrypted data to new string in hexadesimal form
            string newStr = string.Join(" ", bytes.Select(x => x.ToString("x2")));

            // Note1: use array of bytes as encrypted value (convert string to byte and vise versa)

            // Note2: use numeric format "x" to represent data in hexadesimal form. 
            // Number of digits in in the result string must be 2 (use precision)

            // 10) Read data from the file
            //string path = @"D:\EncreptedText.txt";
            string textFromTheFile = File.ReadAllText(path);

            // 11) compare crypted data and file data

            return newStr == textFromTheFile;
        }

        // 12) Change parameters in method and returned type
        public byte[] Signaturing(CngAlgorithm value, string text, ref byte[] publKey)
        {
            // 13) use class CngKey to create signature key (declare object and invoke method Create())
            // use as parameter of method Create() some value of class CngAlgorithm (any algorythm)
            CngKey signatureKey = CngKey.Create(value);

            // 14) Create public key as array of bytes. Use method Export() of class CngKey, which will return byte array
            // use CngKeyBlobFormat.GenericPublicBlob as parameter
            publKey = signatureKey.Export(CngKeyBlobFormat.GenericPublicBlob);

            // 15) Create signatere. Save it to array of bytes.
            //  Declare object of class ECDsaCng. Use declared object of CngKey as parameter of constructor.
            // Save to byte array result of method SignData() of class ECDsaCng with value of public key as parameter 
            ECDsaCng mySignAlg = new ECDsaCng(signatureKey);
            byte[] mySign = mySignAlg.SignData(Encoding.ASCII.GetBytes(text));
            mySignAlg.Clear();



            return mySign;

        // Note: don't forget to clear with method Clear() of class ECDsaCng

        }

        // 16) Change parameters in method and returned type
        // method must use created signature public key and signature 
        public bool VerifySignature(byte[] data, byte[] sign, byte[] pubKey)
        {
            bool flag = false;
            // 17) Use class CngKey to create new signature key to check data (declare object and invoke method Import());
            // use as parameter of method Import() values of signature public key, and the same format as in creating of signature key
            // (use CngKeyBlobFormat.GenericPublicBlob)
            using(CngKey key = CngKey.Import(pubKey, CngKeyBlobFormat.GenericPublicBlob))
            {
                // 18) Verify input data. Declare new object of class ECDsaCng with created signature key on prevous step
                var sign_Alg = new ECDsaCng(key);
                
                // 19) Invoke method VerifyData() to verify input data;
                // 1st parameter - input data (as byte array)
                // 2nd parameter - created aerlier signature (in method Signaturing())
                flag = sign_Alg.VerifyData(data, sign);
                // Note: don't forget to clear with method Clear() of class ECDsaCng
                sign_Alg.Clear();
            }
            return flag;            
            
        }
    }
}
