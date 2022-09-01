using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineInfo
{
    internal class RunProgram
    {
        Menu menu;
        public RunProgram(Menu menu)
        {
            this.menu = menu;
            LaunchProgram();
        }

        public void LaunchProgram()
        {
            menu.GeneralDisplayMenu();

            Thread myThread1 = new Thread(BackgroundStatusUpdateMethod);
            myThread1.Start();
            //while (true)
            //{
            //    //menu.GeneralDisplayMenu();
            //    int num = 0;
            //    // устанавливаем метод обратного вызова
            //    TimerCallback tm = new TimerCallback(Method);
            //    Timer timer = new Timer(tm, num, 0, 100000);

            //}

        }
        public void BackgroundStatusUpdateMethod()
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Method);
            Timer timer = new Timer(tm, num, 0, 2000);
        }
        public void Method(object? state)
        {
            Console.WriteLine("Method works");
        }


    }
}
