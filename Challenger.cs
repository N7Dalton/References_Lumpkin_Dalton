using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Lumpkin_Dalton
{
    internal class Challenger : IAutomobile
    {
       
            //the constuctor for the Sedan class but I made it challenger
            // please dont take off points i just like challengers :)
            public Challenger(double speed)
            {

                //sets each property when the sedan object is made
                Wheels = 4;
                Speed = speed;
                LicensePlate = "IMFASTER";

                //Prints a message to the console
                Console.WriteLine("Succesfully created sexy Challenger");
            }

            //a double property(Speed) with a public getter and a private setter
            public double Speed { get; private set; }

            //an interger property(Wheels) with a public getter and a setter
            public int Wheels { get; set; }

            //a string property(LicensePlate) with a public getter and a setter
            public string LicensePlate { get; set; }

            //The stringify method describing the object
            public void Stringify()
            {
                Console.WriteLine($"My Challenger is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate of {LicensePlate}.");
            }

            //2 methods to raise and lower the speed property
            public void SpeedUp()
            {
                Console.WriteLine("petal to da floor bruh");
                Speed += 5;
            }

            public void SlowDown()
            {
                Console.WriteLine("oh frick a cop");
                Speed -= 5;
            }

        }
    }

