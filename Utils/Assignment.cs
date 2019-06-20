namespace Csharp_Polymorphism_Interfaces_Generics.Utils {
    class Assignment {
        public string assignmentName;
        public bool isCorrect;

        public Assignment (string assignmentName = "Assignment") {
            this.assignmentName = assignmentName;
            this.isCorrect = false;
        }
        public virtual void AddLogic () {
            System.Console.WriteLine ("No logic to add");
        }

        public string ReturnCorrect () {
            
            if (this.isCorrect) {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                return "The Code of " + this.assignmentName + " is correct";
            } else {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                return "The Code of " + this.assignmentName + " is Incorrect"; 
            }
            
        }

        public void ReturnsAnswer (string answer = null) {
            if (answer != null) {
                this.isCorrect = true;
            } else this.isCorrect = false;
        }
    }
}