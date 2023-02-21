// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[]args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            DateTime myValue = now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            // from todays date add x amount of days and printout
            Console.WriteLine(myValue.AddDays(4).ToLongDateString());
            Console.WriteLine(myValue.AddHours(5).ToLongTimeString());

            //subtracting days n time 
            Console.WriteLine(myValue.AddDays(-4).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-5).ToLongTimeString());

            //month
            Console.WriteLine(myValue.Month);
            //
            DateTime myBirthDay = new DateTime(2000, 5, 6);
            Console.WriteLine(myBirthDay.ToShortDateString());

            // determing how long you have lived 
            DateTime lifeOnEarth = DateTime.Parse("12/7/2000");
            TimeSpan myAge = DateTime.Now.Subtract(lifeOnEarth);
            Console.WriteLine(myAge.ToString());
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}