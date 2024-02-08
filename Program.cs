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

            //Console.WriteLine("Please enter any string");

            //string Str=Console.ReadLine();

            // int Counter = 0;

            //foreach (var item in Str)
            //{
            //    Counter++;
            //}
            //Console.WriteLine("leanth of the string is =" + Counter);

            //Console.WriteLine("pleaswe enter any sentance");
            //string str=Console.ReadLine();

            //int SpaceCouter = 0;

            //foreach (var item in str)
            //{
            //    if (item == ' ' ) 
            //    {
            //        SpaceCouter++;

            //    }

            //}
            //Console.WriteLine(" Total space count is =" + SpaceCouter);

            Console.WriteLine("please enter ant string");
            string Str = Console.ReadLine();

            int VowelesCounter = 0;

            foreach (var item in Str)
            {
                if (item == 'a'|| item == 'e' || item == 'i' || item == '0' || item == 'u'||
                    item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                {
                    VowelesCounter++;

                }

            }

            Console.WriteLine("total vowelescounter="+ VowelesCounter);
           

        }


    }
}