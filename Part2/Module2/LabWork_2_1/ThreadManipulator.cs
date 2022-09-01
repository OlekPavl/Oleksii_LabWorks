﻿using System;
using System.Threading;

namespace CSharp_Net_module1_6_1_lab
{
    class ThreadManipulator
    {
        //declare private ConsoleKey  _key  field
        private ConsoleKey _key;
        //In general, avoid locking on a public type, or instances beyond your code's control. The common constructs lock (this), lock (typeof (MyType)), and lock ("myLock") violate this guideline:
        //lock (this) is a problem if the instance can be accessed publicly.
        //lock (typeof (MyType)) is a problem if MyType is publicly accessible.
        //lock("myLock") is a problem because any other code in the process using the same string, will share the same lock.
        //Best practice is to define a private object to lock on, or a private static object variable to protect data common to all instances.

        //create static readonly object _block by new operator

        //private object _block = new object();    //lock
        private object _block = new object();

        //implement AddingOne(object raw) method
        public void AddingOne(object raw)
        {
           
            //var number = (int)raw;
            var number = (int)raw;
            //get ManagedThreadId
            int threadId = Thread.CurrentThread.ManagedThreadId;
            //use lock block with for loop for counter % number calculation

            //lock (_block)
            lock(_block)
            {
                //for (var counter = 0; counter < 100 && _key != ConsoleKey.Q; ++counter)
                for (var counter = 0; counter < 100 && _key != ConsoleKey.Q; ++counter)
                {

                    //use Console.ForegroundColor = ConsoleColor.Blue for output    
                    //simulate the long process with Thread.Sleep
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(counter % number);
                    Thread.Sleep(3000);
                }
            }
        }

        //implement AddingCustomValue(object args) method
        public void AddingCustomValue(object args)
        {
            //get ManagedThreadId
            int threadId = Thread.CurrentThread.ManagedThreadId;
            //define
            //var arr = (int[])args;
            var arr = (int[])args;
            //var number = arr[0];
            var number = arr[0];
            //var step = arr[1];
            var step = arr[1];

            //use for loop for counter % number calculation


            // for (var counter = 0; counter < 100 * step && _key != ConsoleKey.W; counter += step)
            for (var counter = 0; counter < 100 * step && _key != ConsoleKey.W; counter += step)
            {

                //use Console.ForegroundColor = ConsoleColor.Green for output
                //simulate the long process with Thread.Sleep
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(counter % number);
                Thread.Sleep(3000);
            }

        }

        //implement Stop() method
        public void Stop()
        {
            //get ManagedThreadId
            int threadId = Thread.CurrentThread.ManagedThreadId;

            //craete while loop to read key
            //use Console.ForegroundColor = ConsoleColor.Red for output
            while (_key != ConsoleKey.Q)
            {
                _key = Console.ReadKey().Key;
                if (_key == ConsoleKey.Q)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Thread stopped");
                    break;
                }
            }
        }

    }
}
    
