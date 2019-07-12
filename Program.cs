using System;
using Csharp_Polymorphism_Interfaces_Generics.Subjects;
using Csharp_Polymorphism_Interfaces_Generics.TheoreticalInfo;

namespace Csharp_Polymorphism_Interfaces_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        static void RunApp()
        {
            bool appRunning = true;
            Console.Clear();


            while (appRunning)
            {
                Console.Write("Select a subject: a for basics, b for polymorphism, c for interfaces, d for generics, z for jawed, e to exit" + "\n");
                string caseSwitch = Console.ReadLine();
                System.Console.WriteLine("\n");
                switch (caseSwitch)
                {
                    case "a":
                        Console.Clear();
                        Basics basics = new Basics();
                        basics.ToggleState(true);
                        if (basics.isRunning)
                        {

                            basics.AddMainLogic();
                        }
                        else System.Console.WriteLine("Basics not running");
                        System.Console.WriteLine("\n");
                        break;

                    case "b":
                        Console.Clear();
                        Polymorphism polymorphism = new Polymorphism();
                        polymorphism.ToggleState(true);
                        if (polymorphism.isRunning)
                        {
                            polymorphism.AddMainLogic();
                            System.Console.ResetColor();
                        }
                        else System.Console.WriteLine("Polymorphism not running");
                        System.Console.WriteLine("\n");
                        break;

                    case "c":
                        Console.Clear();
                        Interfaces interfaces = new Interfaces();
                        interfaces.ToggleState(true);
                        if (interfaces.isRunning)
                        {
                            interfaces.AddMainLogic();
                            System.Console.ResetColor();
                        }
                        else System.Console.WriteLine("interfaces not running");
                        System.Console.WriteLine("\n");
                        break;
                    case "d":
                        Console.Clear();
                        Generics generics = new Generics();
                        generics.ToggleState(true);
                        if (generics.isRunning)
                        {
                            generics.AddMainLogic();
                        }
                        break;
                    case "z":
                        Console.Clear();
                        Jawed jawed = new Jawed();
                        jawed.ToggleState(true);
                        if (jawed.isRunning)
                        {
                            jawed.AddMainLogic();
                        }
                        break;

                    case "e":
                        System.Console.WriteLine("Shutting down");
                        Console.Clear();
                        appRunning = false;
                        break;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("Not a valid option please try again.");
                        break;
                }
            }
        }
    }
}