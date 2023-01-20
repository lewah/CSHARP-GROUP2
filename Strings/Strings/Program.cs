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

            //----- back slash - \
            //string myString = "My \"so called\" life";

            //----- Add new line
            //string myString = "My first line \n My second line";

            //----- using Back slash as string - \\
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //----- Replacement code  and currency(C) and large number(N) and percentage(P) and Phone Number(###) 
            //string myString = String.Format("{0} = {1}", "First", "second");
            //string myString = String.Format("{0:C}", 123.45);
            //string myString = String.Format("{0:N}", 1234567890);
            //string myString = String.Format("Percentage : {0:P}", .199);
            //string myString = String.Format("Phone Number : {0.(###) ###-####}", 254767676767);

            //----- substring helper method
            /*
            string myString = " Every action you take is a vote for the person you wish to become. ";
            myString = myString.Trim();
            myString = myString.Substring(7);
            myString = myString.Substring(7, 13);
            myString = myString.ToUpper();
            myString = myString.Replace(" ", " --");
            myString = myString.Remove(4,10);
            myString = String.Format("length before : {0} -- Length after {1}", 
             myString.Length , myString.Trim().Length);
             */
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }

}
