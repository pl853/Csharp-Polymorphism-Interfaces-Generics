namespace Csharp_Polymorphism_Interfaces_Generics.Utils
{   
    class Assignment
    {
        public string assignmentName;
        public bool isCorrect;

        public Assignment(string assignmentName ="Assignment")
        {
            this.assignmentName = assignmentName;
            this.isCorrect = false;
        }
        public virtual void AddLogic()
        {
            System.Console.WriteLine("No logic to add");
        }

        public string ReturnCorrect()
        {
            if(this.isCorrect)
            {
                return "The Code of " +this.assignmentName + " is correct";
            }else return "The Code of " +this.assignmentName + " is incorrect";
        }

        public void ReturnsAnswer(string answer=null)
        {
            if (answer!= null)
            {
                this.isCorrect = true;
            }else this.isCorrect=false;
        }
    }
}