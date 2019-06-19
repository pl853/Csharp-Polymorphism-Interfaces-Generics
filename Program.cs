using System;
using Csharp_Polymorphism_Interfaces_Generics.Subjects;

namespace Csharp_Polymorphism_Interfaces_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;
      
            switch (caseSwitch)
            {
                case 1:
                    Basics basics = new Basics();
                    basics.AddMainLogic();
                    System.Console.WriteLine(basics.ReturnInfo()); 
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}
