using System;
using System.IO;

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
            return "Chosen subject: " + this.subjectName + "\n";
        }

        public virtual void ToggleState(bool value)
        {
            this.isRunning = value;
        }

        public void ReturnCode(string fileLocation)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(fileLocation);

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }


                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("END OF INFO\n");
            }
        }
    }
}