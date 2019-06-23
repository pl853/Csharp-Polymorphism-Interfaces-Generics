using System;
using System.IO;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects

{
    class Generics : Subject {
        public Generics (string subjectName = "Generics") : base (subjectName) {
            System.Console.WriteLine (ReturnInfo ());
            ReturnCode ("./TheoreticalInfo/" + this.subjectName);
        }

        public override void AddMainLogic () {

        }
    }
}