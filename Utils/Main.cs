using System;

namespace Csharp_Polymorphism_Interfaces_Generics.Utils
{
    class Subject
    {
        public string subjectName;
        public bool isRunning;
        
        public Subject(string subjectName)
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
            return "Chosen subject: "+this.subjectName;
        }

        public virtual void ToggleState(bool value)
        {
            this.isRunning = value;
        }
    }
}
