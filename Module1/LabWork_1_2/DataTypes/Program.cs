using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true;
            char ch = 'c';
            byte b = 1;
            sbyte sb = 100;
            short sh = 250;
            ushort ush = 150;
            int i = 10000;
            uint ui = 25;
            long l = -223L;
            ulong ul = 300UL;
            decimal de = 100000.6M;
            float fl = 8F;
            double d0 = -33.1;

            //2) declare constants of int and double. Try to change their values.

            const int number1 = 147;
            const double number2 = 46436.565D;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var variable1 = 20.5;
            var variable2 = 20;

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            System.Int32 var1 = i;
            System.Double var2 = d0;

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                int var_1 = i;
                char var_2 = ch;
                double var_3 = d0;

                // 6) change values of variables from 1)

                boo = false;
                ch = 'b';
                b = 23;
                sb = -100;
                sh = -32768;
                ush = 65535;
                i = 511;
                ui = 4294967295;
                l = -1000L;
                ul = 4500UL;
                de = 100000.123M;
                fl = 121F;
                d0 = -47.7;


            }

            // 7)check values of variables from 1). Are they changed? Think, why

            //Yes, they have been changed
            //Console.WriteLine(boo);
            //Console.WriteLine(ch);
            //Console.WriteLine(b);
            //Console.WriteLine(sb);
            //Console.WriteLine(sh);
            //Console.WriteLine(ush);
            //Console.WriteLine(i);
            //Console.WriteLine(ui);
            //Console.WriteLine(l);
            //Console.WriteLine(ul);
            //Console.WriteLine(de);
            //Console.WriteLine(fl);
            //Console.WriteLine(d0);


            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).

            // int -> char
            //ch = i; - not possible;
            ch = (char)i;

            // bool -> short
            //sh = boo; - not possible;
            //sh = (short)boo; - not possible;

            // double -> long
            //l = d0; - not possible;
            l = (long)d0;

            // float -> char 
            //ch = fl; - not possible
            ch = (char)fl;

            // int to char
            //ch = i; - not possible;
            ch = (char)i;

            // decimal -> double
            //d0 = de; -> not possible
            d0 = (double)de;


            // byte -> uint
            ui = b;
            ui = (byte)b;

            // ulong -> sbyte
            //sb = ul; - not possible;
            sb = (sbyte)ul;


            // 9) and reverse conversion with fixing compilation errors.

            // char -> int
            i = ch;

            // short -> bool
            //boo = sh; - not possible
            //boo = (bool)sh; - not possible;

            // long -> double
            d0 = l;

            // char -> float
            fl = ch;

            // char -> int
            i = ch;

            // double -> decimal
            //de = d0; - not possible
            de = (decimal)d0;

            // uint -> bool
            //b = ui; - not possible
            b = (byte)ui;

            // sbyte -> ulong
            //ul = sb; - not possible
            ul = (ulong)sb;

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

            //int nullableValue = null; - not possible;
            //i = null; - not possible;

            Console.ReadKey();
        }
    }
}
