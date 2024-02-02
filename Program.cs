using System.Diagnostics.Metrics;

namespace StringManupulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string FirstName, LastName, FullName;

            //Console.WriteLine("Please enter the firstname");
            //FirstName= Console.ReadLine();

            //Console.WriteLine("please enter the last name");
            //LastName= Console.ReadLine();   

            //FullName= FirstName+" "+ LastName;

            //Console.WriteLine(FullName);

            // calcute length of the string

            Console.WriteLine("Please enter any string");

            string Str=Console.ReadLine();

             int Counter = 0;

            foreach (var item in Str)
            {
                Counter++;
            }
            Console.WriteLine("leanth of the string is =" + Counter);

        }


    }
}