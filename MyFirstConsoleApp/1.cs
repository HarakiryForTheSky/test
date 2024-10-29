using System;

namespace MyFirstConsoleApp
    {
    class Program
        {
    static void Main(string[] args)
            {
                while (true)
                {
                    Console.Write("Enter a numeric value: ");
                    string number = Console.ReadLine();
                    if (int.TryParse(number, out int kik))
                    {
                    Console.WriteLine("Successfully");
                    break;
                    }
                    else
                    {
                    Console.WriteLine("ERROR");
                    }
                    Console.WriteLine("GG");
                }
            }
        }
    }