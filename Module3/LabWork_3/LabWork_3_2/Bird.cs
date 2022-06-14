using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3_2
{
    //Create the Bird class with the fields, properties, constructors and the method
    //The public void FlyAway( int incrmnt ) method generates custom exception 
    class Bird
    {
        //Create fields and properties
        public int[] flySpeed = { 5, 15, 25, 35 };
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        private bool birdFlewAway;

        //Create constructors
        public Bird() { }
        public Bird(string name, int speed)
        {
            this.NormalSpeed = speed;
            this.Nick = name;
        }

        //Implement Method public void FlyAway( int incrmnt ) which check Bird state by reading field  BirdFlewAway
        // check BirdFlewAway
        public void FlyAway(int incrmnt)
        {
            // if true 
            if (birdFlewAway == true)
            {
                // write the message to console
                Console.WriteLine("Bird has flown away");
            }
            // else
            else
            {
                // increment the Bird speed by method argument
                NormalSpeed += incrmnt;
                // check the condition (NormalSpeed >= FlySpeed[3]) 
                // If it's true 
                if (NormalSpeed >= flySpeed[3])
                {
                    // BirdFlewAway = true and we generate custom exception    BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick), "Oh! Startle.", DateTime.Now)
                    // with HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse" else  console.writeline about Bird speed 
                    birdFlewAway = true;
                    BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick), "Oh! Startle.", DateTime.Now) with HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse";
                }
                //else  console.writeline about Bird speed 
                {
                    Console.WriteLine($"The bird`s speed = {NormalSpeed}");
                }

            }

        }
    }




}
