using System;
using System.IO;
namespace Csharp_Polymorphism_Interfaces_Generics.Utils
{
    class Assignment
    {
        public string assignmentName;
        public bool isCorrect;

        public Assignment(string assignmentName = "Assignment")
        {
            this.assignmentName = assignmentName;
            this.isCorrect = false;
        }
        public virtual void AddLogic()
        {
            System.Console.WriteLine("No logic to add");
        }

        public void ReturnCode(string fileLocation)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileLocation);

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("END OF INFO \n");
            }
        }

        public string ReturnCorrect()
        {

            if (this.isCorrect)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                return "The Code of " + this.assignmentName + " is correct";
            }
            else
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                return "The Code of " + this.assignmentName + " is Incorrect";
            }

        }

        public void ReturnsAnswer(string answer = null)
        {
            if (answer != null)
            {
                this.isCorrect = true;
                // System.Console.WriteLine(answer + "\n");
            }
            else this.isCorrect = false;
        }
    }
}