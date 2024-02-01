namespace StringManupulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, FullName;

            Console.WriteLine("Please enter the firstname");
            FirstName= Console.ReadLine();

            Console.WriteLine("please enter the last name");
            LastName= Console.ReadLine();   

            FullName= FirstName+" "+ LastName;

            Console.WriteLine(FullName);

        }


    }
}