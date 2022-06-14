using System;

namespace LabWork_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop object1 = new OnlineShop();
            object1.myEvent += Object1_myEvent;
            object1.NewGoods("Notebook");

            // 10) declare several objects of Customer

            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results

            Console.ReadKey();
        }

        private static void Object1_myEvent(object sender, GoodsInfoEventArgs e)
        {
            Console.WriteLine("Event " + e.GoodsName);
        }
    }
}
