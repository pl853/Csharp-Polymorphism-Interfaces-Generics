using System;
using Csharp_Polymorphism_Interfaces_Generics.Subjects;

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
            while(appRunning)
            {
                Console.Write("Select a subject: a for basics, b for polymorphism, c for interfaces, e to exit"+"\n");
			    string caseSwitch = Console.ReadLine();
                System.Console.WriteLine("\n");
                switch (caseSwitch)
                {
                    case "a":
                        Basics basics = new Basics();
                        basics.ToggleState(true);
                        if(basics.isRunning)
                        {
                        basics.AddMainLogic();
                        }else System.Console.WriteLine("Basics not running");
                        System.Console.WriteLine("\n");
                        break;

                    case "b":
                        Polymorphism polymorphism = new Polymorphism();
                        polymorphism.ToggleState(true);
                        if(polymorphism.isRunning)
                        {
                            polymorphism.AddMainLogic();
                        }else System.Console.WriteLine("Polymorphism not running");
                        System.Console.WriteLine("\n");
                        break;

                    case "c":
                        Interfaces interfaces = new Interfaces();
                        interfaces.ToggleState(true);
                        if(interfaces.isRunning)
                        {
                            interfaces.AddMainLogic();
                        }else System.Console.WriteLine("interfaces not running");
                        System.Console.WriteLine("\n");
                        break;

                    case "e":
                        System.Console.WriteLine("Shutting down");
                        appRunning = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
