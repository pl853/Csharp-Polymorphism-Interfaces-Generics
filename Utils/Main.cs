using System;

namespace Csharp_Polymorphism_Interfaces_Generics.Utils
{
    class Main
    {
        public string subjectName;
        public bool isRunning;
        
        public Main(string subjectName)
        {
            this.subjectName = subjectName;
            this.isRunning = false;
        }

        public virtual void AddMainLogic()
        {
            System.Console.WriteLine("Main Logic Added");
        }

        public virtual string ReturnInfo()
        {
            return this.subjectName;
        }

        public virtual void State(bool value)
        {
            this.isRunning = value;
        }
    }
}
