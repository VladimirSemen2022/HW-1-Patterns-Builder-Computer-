using HW_1_Patterns_Builder__Computer_.Builder;
using System;

namespace HW_1_Patterns_Builder__Computer_
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ComputerBuilder();
            director.Builder = builder;

            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Select configuration of computer wat you want:\n");
                Console.WriteLine("1. Low configuration computer");
                Console.WriteLine("2. Standard configuration computer");
                Console.WriteLine("3. High configuration computer");
                Console.WriteLine("4. Your configuration computer\n");
                Console.WriteLine("0. Exit\n");
                Console.Write("Input a number of yor choice - ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Low configuration computer:\n");
                        director.BuildLowConfiguration();
                        Console.WriteLine(builder.GetComputer().ListComponents());
                        Console.WriteLine("\n\nPush any key to exit");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Standard configuration computer:\n");
                        director.BuildMiddleConfiguration();
                        Console.WriteLine(builder.GetComputer().ListComponents());
                        Console.WriteLine("\n\nPush any key to exit");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("High configuration computer:\n");
                        director.BuildHighConfiguration();
                        Console.WriteLine(builder.GetComputer().ListComponents());
                        Console.WriteLine("\n\nPush any key to exit");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        //Console.WriteLine("Your configuration computer:\n");
                        director.BuildMyConfiguration();
                        Console.WriteLine(builder.GetComputer().ListComponents());
                        Console.WriteLine("\n\nPush any key to exit");
                        Console.ReadKey();
                        break;
                }   
            } while (choice != "0");
        }
    }
}
