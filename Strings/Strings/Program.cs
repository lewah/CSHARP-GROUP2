// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // manipulating strings

            // back slash - \
            //string myString = "My \"so called\" life";

            // Add new line
            //string myString = "My first line \n My second line";

            // using Back slash as string - \\
            //string myString = "Go to your c:\\ drive";
            string myString = @"Go to your c:\ drive";

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }

}
