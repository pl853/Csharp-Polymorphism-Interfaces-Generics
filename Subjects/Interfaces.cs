using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects
{
    class Interfaces : Subject
    {
        public Interfaces(string subjectName="Interfaces") : base(subjectName)
        {
            ReturnInfo();
        }
    }
}
