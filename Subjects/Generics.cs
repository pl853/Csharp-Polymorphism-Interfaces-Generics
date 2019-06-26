using System;
using System.IO;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects

{
    class Generics : Subject
    {
        public Generics(string subjectName = "Generics") : base(subjectName)
        {
        }

        public override void AddMainLogic()
        {
            bool notExited = true;
            Console.Clear();
            System.Console.WriteLine(ReturnInfo());
            ReturnCode("./TheoreticalInfo/");
            while (notExited)
            {
                Console.Write("Select an assignment:\n \n1: BA-1\n2: BA-2\n3: BA-3\n4: BA-4\n5: BA-5\n6: BA-6\n7: BA-7\n8: BA-8\n9: BA-9\n\nb to go back\n");
                string caseSwitch = Console.ReadLine();
                System.Console.WriteLine("\n");
                switch (caseSwitch)
                {
                    case "1":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "2":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "3":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "4":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "5":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "6":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "7":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "8":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "9":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "b":
                        notExited = false;
                        Console.Clear();
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