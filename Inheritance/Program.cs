using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           var bird1= new Bird()
           {
               Age=4,
               IsAlive=true,
               Limbs=2,
               LandSeaAir="air",
               CanFly=true,
               WingColor="red",
               DoMigrate=false,
               BeakLength=3.4,
           };

            var alligator = new Reptile()
            {
                IsColdBlooded = true,
                ShedsSkin = false,
                CanRegrowTail = true,
                NumberOfTeeth = 55,
            };

            var myAnimals= new List<Animal> {alligator,bird1};

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age}");
                Console.WriteLine($"Number of limbs:{animal.Limbs}");
                Console.WriteLine($"It lives in/on:{animal.LandSeaAir}");
                Console.WriteLine();
                Console.WriteLine("*****************************************");
                Console.WriteLine();
                
            }
            


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
