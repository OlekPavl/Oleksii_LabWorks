using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Step_1
{
    public  class Cl1
    {
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        public static extern Int32 GetComputerName(String Buffer, ref Int32 BufferLength);

        public void GetCompName()
        {
            Int32 bufferLength = 16;
            String comName = new string(' ', bufferLength);
            GetComputerName(comName, ref bufferLength);
            comName = comName.Trim();
            Console.WriteLine("Computer Name:");
            Console.WriteLine("  {0} ({1})", comName, bufferLength);
        }

    }

}
