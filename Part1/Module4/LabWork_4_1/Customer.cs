using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_4_1
{
    class Customer
    {
        // 6) declare private field name
        private string name;

        // 7) declare constructor to initialize name
        public Customer(string name)
        {
            this.name = name;
        }

        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type
        public void GotNewsGoods(object param1, GoodsInfoEventArgs param2)
        {
            Console.WriteLine("Method GotNewsGoods");
        }

    }
}
