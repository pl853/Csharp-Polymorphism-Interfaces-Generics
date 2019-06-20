using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects
{
    class Polymorphism : Subject
    {
        public Polymorphism(string subjectName ="Pylomorphism") : base(subjectName)
        {
            ReturnInfo();
        }
        public override void AddMainLogic()
        {
            //BA 1A RELATED
            X xb = new X();
            double x_c = xb.GetC();

            //COMPUTE RELATED
            var x = new Compute();
            var a = x.Add(3,5); 
            var b = x.Add(3,5,1);
            var c = x.Add(3.0,5);
            var d = x.Add(3,5.0);
            var e = x.Add(3.0,5.0);

            //STUDENT RELATED
            StudentPolymorphism  s1  = new StudentPolymorphism();
            StudentPolymorphism  s2  = new StudentPolymorphism(90);
            StudentPolymorphism  s3  = new StudentPolymorphism("Amit",88, 60);
            string output1 = "Subject One Marks: " +  s1 .GetSubjectOneMarks();
            string output2 = "Subject One Marks: " +  s2 .GetSubjectOneMarks();
            string output3 = "Student name: " +  s3 .GetStudentName  ();
            string output4 = "Subject One Marks: " +  s3 .GetSubjectOneMarks  ();
            string output5 = "Subject Two Marks: " +  s3 .GetSubjectTwoMarks  ();
        }
    }

    class X {
        public  int  a;
        public  float  b;
        public  double  c;

        public X(){
        this.a = 0;
        this.b = this.a;
        this.c = this.b;
        }

        public  double  GetC(){
            return this.c;
        }
    }
    class Compute {
        public int Add(int x, int y) 
        {
            return x+y;
        }

        public int Add(int x, int y, int z) 
        {
            return x+y+z;
        }

        public double Add(double x, int y) 
        {
            return x+y+1;
        }

        public double Add(int x, double y) 
        {
            return x+y+10;
        }

        public double Add(double x, double y) 
        {
            return x+y;
        }
    }
    class StudentPolymorphism
    {
        public int SubjectOne;
        public int SubjectTwo;
        public string StudentName;

        public StudentPolymorphism(string StudentName,int SubjectOne,int SubjectTwo)
        {
        this.StudentName = StudentName;
        this.SubjectOne= SubjectOne;
        this.SubjectTwo= SubjectTwo;
        }
        public StudentPolymorphism(int SubjectOne =0,int SubjectTwo=0,string StudentName="StudentName")
        {
        this.SubjectOne = SubjectOne;
        this.SubjectTwo = SubjectTwo;
        this.StudentName = StudentName;
        }
        public int GetSubjectOneMarks() {
        return this.SubjectOne;
        }
        public int GetSubjectTwoMarks() {
        return this.SubjectTwo;
        }
        public string GetStudentName() {
        return this.StudentName;
        }
    }
}
