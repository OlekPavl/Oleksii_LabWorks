using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3_1
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0

                int[] arr = new int[4] { 1, 4, 8, 5 };
                arr[1] = 0;
                ma.Assign(arr, 4);

                

            }

            // 8) catch all other exceptions here
            catch(Exception ex)
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("Block finally always displayed");
            }
        }
    }
}
