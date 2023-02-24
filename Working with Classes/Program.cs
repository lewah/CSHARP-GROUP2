// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimlpeClasses
{
    class Program
    {
        // classes, methods, properties, object      OOP
        static void Main(string[] args)
        {
            // creating an instance of the CarProperties class
            // object = mazda 
            CarProperties mazda = new CarProperties(); // constructore methode - when creating a new instance of a class  , puting mazda into a valid state 

            mazda.Make = "Mazda";
            mazda.Model = "Atenza";
            mazda.Year = "2015";
            mazda.Color = "Red";
            mazda.Cost = "2M";

            /*
            Console.WriteLine("Make of the car:");
            mazda.Make = Console.ReadLine();

            Console.WriteLine("Model of car: ");
            mazda.Model = Console.ReadLine();

            Console.WriteLine("Year of build: ");
            mazda.Year = Console.ReadLine();

            Console.WriteLine("Color of car: ");
            mazda.Color = Console.ReadLine();

            Console.WriteLine("Cost of Car: ");
            mazda.Cost = Console.ReadLine();
            */


            // creating a variable mazda that is only accessed with the Main method    (in scope)       
            // mazda.Model = "98";

            //object = null  the reference is removed 
            // mazda = null;

            Console.WriteLine("{0} {1} {2} {3} {4} ", 
                mazda.Make, 
                mazda.Year,
                mazda.Model, 
                mazda.Color, 
                mazda.Cost);

        }
    }

    // define class
    class CarProperties
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Cost { get; set; }

        // this 
    }
}