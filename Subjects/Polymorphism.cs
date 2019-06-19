using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects
{
    class Polymorphism : Main
    {
        public Polymorphism(string subjectName ="Pylomorphism") : base(subjectName)
        {
            ReturnInfo();
        }
        public override void AddMainLogic()
        {}
    }
}
