using System;
using System.Diagnostics;
using System.Threading;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.TheoreticalInfo {
    class Jawed : Subject {
        public Jawed (string subjectName = "Jawed") : base (subjectName) {
            System.Console.WriteLine (ReturnInfo ());
        }
        public override void AddMainLogic () {
            Studentjawed sj = new Studentjawed ();
            sj.AddLogic ();
            A a = new A ();
            var x = ((int) 3.9);
            System.Console.WriteLine (x);
            a.AddLogic ();
        }
    }

    class Studentjawed : Assignment {

        public int subjectOne;
        public int subjectTwo;
        public string studentName;
        public Studentjawed (int subjectOne = 0, int subjectTwo = 0, string studentName = "") {
            this.studentName = studentName;
            this.subjectOne = subjectOne;
            this.subjectTwo = subjectTwo;
        }

        public Studentjawed (string studentName, int subjectOne, int subjectTwo) {
            this.studentName = studentName;
            this.subjectOne = subjectOne;
            this.subjectTwo = subjectTwo;

        }

        public void ChangeStudentName (string name) {
            this.studentName = name;
        }

        public override void AddLogic () {
            Studentjawed s1 = new Studentjawed ();
            Studentjawed s2 = new Studentjawed (80);
            Studentjawed s3 = new Studentjawed ("Pieter", 80, 80);
            System.Console.WriteLine (s1.studentName, s3.subjectOne);

        }
    }

    class A {
        public double a;
        public A () {

        }
        public A (int a) {
            this.a = a;
        }

        public virtual double GetA () {
            return this.a;
        }

        public void AddLogic () {
            B object1 = new B (123, 321);
            double result1 = object1.GetA ();
            A object2 = new B (123, 321);
            double result2 = object2.GetA ();
            B object3 = new B (123, 321);
            double result3 = object3.GetA ();
            System.Console.WriteLine (result1);
            System.Console.WriteLine (result2);
            System.Console.WriteLine (result3);
        }
    }

    class B : A {
        public int b1;

        public B (int b1, int a) : base (a) {
            this.b1 = b1;
        }

        public override double GetA () {
            return this.b1 * 10.0;
        }
    }
}