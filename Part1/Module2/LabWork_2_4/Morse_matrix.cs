using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2_4
{
    class Morse_matrix : String_matrix, IMorse_crypt
    {
        public const int Size_2 = Alphabet.Size;
        private int offset_key = 0;

        //Implement Morse_matrix constructor with the int parameter for offset
        //Use fd(Alphabet.Dictionary_arr) and sd() methods
        public Morse_matrix(int offset = 0)
        {
            offset_key = offset;
            fd(Alphabet.Dictionary_arr);
            sd();
        }

        //Implement Morse_matrix constructor with the string [,] Dict_arr and int parameter for offset
        //Use fd(Dict_arr) and sd() methods
        public Morse_matrix(string[,] Dict_arr, int offset = 0)
        {
            offset_key = offset;
            fd(Dict_arr);
            sd();
        }



        private void fd(string[,] Dict_arr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size_2; jj++)
                    this[ii, jj] = Dict_arr[ii, jj];
        }


        private void sd()
        {
            int off = Size_2 - offset_key;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offset_key];
            for (int jj = off; jj < Size_2; jj++)
                this[1, jj] = this[1, jj - off];
        }

        //Implement Morse_matrix operator +
        public static Morse_matrix operator +(Morse_matrix a, Morse_matrix b)
        {
            Morse_matrix[,] returnedMatrix = new Morse_matrix[this[].getlen,]; 
        }


        //Realize crypt() with string parameter
        //Use indexers
        public string Crypt(string word)
        {
            throw new NotImplementedException();
        }


        //Realize decrypt() with string array parameter
        //Use indexers
        public string Decrypt(string[] signal)
        {
            throw new NotImplementedException();
        }


        //Implement Res_beep() method with string parameter to beep the string

    }
}
