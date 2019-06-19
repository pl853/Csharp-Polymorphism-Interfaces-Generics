using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects
{
    class Basics : Main
    {
        public Basics(string subjectName ="Basics"):base(subjectName)
        {

        }

        public override void AddMainLogic()
        {
            //STUDENT RELATED
            string[] courses = new string[] { "Development", "Analysis", "Skills", "Project" };
            Student s1 = new Student("Sarah", "Smith", 123456, courses);
            Student s2 = new Student("Bill", "Rogers", 654321, courses);

            //CAT RELATED
            Cat c1 = new Cat("Whiskers", "Meow", 1.5);
            string s1 = c1.MakeSound();
            c1.Feed();
            double w1 = c1.weight;

            Cat c2= new Cat("Mr Fluffy", "Mauw", 1.6);
            string s2 = c2.MakeSound();
            c2.Feed();
            double w2 = c2.weight;

            //RECTANGLE RELATED
            Rectangle r1 = new Rectangle(3.0, 4.0);
            Rectangle r2 = new Rectangle(5.0, 2.0);
            double l = r1.length;
            double w = r1.width;
            double a1 = r1.Area();
            double a2 = r2.Area();

            //PLANET RELATED
            Planet p1 = new Planet("Jupiter", 5.203, 2.5);
            Planet p2 = new Planet("Earth", 1.0, 1.0);
            string n1 = p1.name;
            double d1 = p1.distance;
            double g1 = p1.gravity;
            string s1 = p1.Info();
            string s2 = p2.Info();

            //VECTOR RELATED
            var v1 = new Vector2(2.0, 4.0);
            var v2 = new Vector2(5.0, 1.0);
            var r = v1.Times(3.0);
            var q = v2.Plus(r);
            var p = v2.Times(q.x + q.y);
        }
    }
}
