using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects {
    class Polymorphism : Subject {
        public Polymorphism (string subjectName = "Pylomorphism") : base (subjectName) {
            ReturnInfo ();
        }
        public override void AddMainLogic () {
            X xInstance = new X ();
            xInstance.AddLogic ();

            Compute computeInstance = new Compute ();
            computeInstance.AddLogic ();

            StudentPolymorphism studentPolymorphismInstance = new StudentPolymorphism ();
            studentPolymorphismInstance.AddLogic ();

            X_h x_hInstance = new X_h ();
            x_hInstance.AddLogic ();

            Person personInstance = new Person ();
            personInstance.AddLogic ();

        }
    }

    class X : Assignment {
        public int a;
        public float b;
        public double c;

        public X (string assignmentName = "XPolymorphism") : base (assignmentName) {
            this.a = 0;
            this.b = this.a;
            this.c = this.b;
        }

        public override void AddLogic () {
            X xb = new X ();
            double x_c = xb.GetC ();
            this.ReturnsAnswer (x_c.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public double GetC () {
            return this.c;
        }
    }
    class Compute : Assignment {
        public Compute (string assignmentName = "ComputePolymorphism") : base (assignmentName) { }
        public override void AddLogic () {
            var x = new Compute ();
            var a = x.Add (3, 5);
            var b = x.Add (3, 5, 1);
            var c = x.Add (3.0, 5);
            var d = x.Add (3, 5.0);
            var e = x.Add (3.0, 5.0);
            this.ReturnsAnswer (a.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());

        }
        public int Add (int x, int y) {
            return x + y;
        }

        public int Add (int x, int y, int z) {
            return x + y + z;
        }

        public double Add (double x, int y) {
            return x + y + 1;
        }

        public double Add (int x, double y) {
            return x + y + 10;
        }

        public double Add (double x, double y) {
            return x + y;
        }
    }
    class StudentPolymorphism : Assignment {
        public int SubjectOne;
        public int SubjectTwo;
        public string StudentName;

        public StudentPolymorphism (string StudentName, int SubjectOne, int SubjectTwo, string assignmentName = "StudentPolymorphism") : base (assignmentName) {
            this.StudentName = StudentName;
            this.SubjectOne = SubjectOne;
            this.SubjectTwo = SubjectTwo;
        }
        public StudentPolymorphism (int SubjectOne = 0, int SubjectTwo = 0, string StudentName = "StudentName", string assignmentName = "StudentPolymorphism") : base (assignmentName) {
            this.SubjectOne = SubjectOne;
            this.SubjectTwo = SubjectTwo;
            this.StudentName = StudentName;
        }
        public override void AddLogic () {
            StudentPolymorphism s1 = new StudentPolymorphism ();
            StudentPolymorphism s2 = new StudentPolymorphism (90);
            StudentPolymorphism s3 = new StudentPolymorphism ("Amit", 88, 60);
            string output1 = "Subject One Marks: " + s1.GetSubjectOneMarks ();
            string output2 = "Subject One Marks: " + s2.GetSubjectOneMarks ();
            string output3 = "Student name: " + s3.GetStudentName ();
            string output4 = "Subject One Marks: " + s3.GetSubjectOneMarks ();
            string output5 = "Subject Two Marks: " + s3.GetSubjectTwoMarks ();
            this.ReturnsAnswer (output2.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());

        }
        public int GetSubjectOneMarks () {
            return this.SubjectOne;
        }
        public int GetSubjectTwoMarks () {
            return this.SubjectTwo;
        }
        public string GetStudentName () {
            return this.StudentName;
        }
    }

    class X_h : Assignment {
        public int a;
        public double b;
        public string c;

        public X_h (string assignmentName = "X_hPolymorphism") : base (assignmentName) { }

        public X_h (int num) {
            this.a = num;
            this.b = this.a * 2;
            this.c = "num " + this.a;
        }

        public override void AddLogic () {
            X_h x1 = new X_h (5);
            X_h x2 = new X_h (7);
            var a = x1.Compute (4);
            var b = x1.Compute (4.0);
            var c = x2.Compute (3.0);
            var d = x1.Compute ("hello");
            var e = x2.Compute ("ciao");
            this.ReturnsAnswer (d.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public int Compute (int v) {
            return v + this.a;
        }

        public double Compute (double v) {
            return this.b + v;
        }

        public string Compute (string v) {
            return v + " num " + this.a;
        }
    }
    class Person : Assignment {
        public string name;
        public string surname;

        public Person (string assignmentName = "Person_StudentPolymorphism") : base (assignmentName) { }

        public Person (string name, string surname) {
            this.name = name;
            this.surname = surname;
        }

        public override void AddLogic () {
            StudentPolymorphism2 s = new StudentPolymorphism2 ("John", "Doe", 871029);
            s.SetPassedExams (5);
            int passedExams = s.GetPassedExams ();
            s.SetPassedExams (s.GetPassedExams () + 1);
            int id = s.GetStudentNumber ();
            Person p = s as Person;
            string name = p.GetName ();
            this.ReturnsAnswer (name.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public string GetName () {
            return this.name;
        }
    }

    class StudentPolymorphism2 : Person {
        public int passed_exams;
        public int student_number;

        public StudentPolymorphism2 (string name, string surname,
            int student_number) : base (name, surname) {
            this.student_number = student_number;
            this.passed_exams = 0;
        }

        public int GetPassedExams () {
            return this.passed_exams;
        }

        public void SetPassedExams (int exams) {
            this.passed_exams = exams;
        }

        public int GetStudentNumber () {
            return this.student_number;
        }
    }
    class Tool : Assignment {
        public int durability;
        public Tool (string assignmentName = "ToolPolymorphism") : base (assignmentName) {
            this.durability = 100;
        }

        public override void AddLogic () {
            Tool[] tools = new Tool[] { new IronHammer (), new StoneHammer (), new PhasePistol () };
            for (int i = 0; i < 5; i = i + 1) {
                for (int j = 0; j < tools.Length; j = j + 1) {
                    tools[j].Use ();
                }
            }
        }

        public virtual void Use () {
            this.durability = this.durability - 1;
        }
    }

    class StoneHammer : Tool {
        public StoneHammer () : base () { }

        public override void Use () {
            this.durability -= 10;
        }
    }

    class IronHammer : Tool {
        public IronHammer () : base () { }

        public override void Use () {
            this.durability -= 2;
        }
    }

    class PhasePistol : Tool {
        public PhasePistol () : base () { }
        public override void Use () {
            this.durability -= 5;
        }
    }
}