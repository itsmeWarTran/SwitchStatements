using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite school subject");
            String subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                
                
                case "math":
                Console.WriteLine("Your favorite subject is math");
                break;

                case "science":
                Console.WriteLine("Your favorite subject is science");
                break;

                case "english":
                Console.WriteLine("Your favorite subject is english");
                break;

                case "history":
                Console.WriteLine("Your favorite subject is history");
                break;

                case "spanish":
                Console.WriteLine("Your favorite subject is spanish");
                break;
                
                default:
                Console.WriteLine($"Your favorite subject is {subject}");
                break;
            }
        }
    }
}
