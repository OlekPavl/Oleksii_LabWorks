using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_4
{
    //Define interface IMorse_crypt wicth two methods  
    //crypt - to crypt the string
    //decrypt - to decrypt array of strings
    interface IMorse_crypt
    {
        public string Crypt(string word);
        public string Decrypt(string[] signal);
    }
}
