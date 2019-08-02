using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] abc = GetNames();
            Console.WriteLine(abc[2]);
            
            

        }

        public static string[] GetNames()
        {

          string[] xyz= new string[] { "Sunday", "Monday", "Tuesday" };
            return xyz;
        }

    }
}
