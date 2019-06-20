using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects {
    class Basics : Subject {
        public Basics (string subjectName = "Basics") : base (subjectName) {
            ReturnInfo ();
        }
        public override void AddMainLogic () {
            //STUDENT RELATED
            Student studentInstance = new Student ();
            studentInstance.AddLogic ();
            //CAT RELATED
            Cat catInstance = new Cat ();
            catInstance.AddLogic ();
            //VECTOR RELATED
            Vector2 vector2Instance = new Vector2 ();
            vector2Instance.AddLogic ();
            //PLAYER RELATED
            Player playerInstance = new Player ();
            playerInstance.AddLogic ();
            //CAR RELATED
            Car carInstance = new Car ();
            carInstance.AddLogic ();
            //TURTLE RELATED
            Turtle turtleInstance = new Turtle ();
            turtleInstance.AddLogic ();
            //POINT RELATED
            Canvas canvasInstance = new Canvas ();
            canvasInstance.AddLogic ();
            //CARD RELATED
        }
    }
    class Student : Assignment {
        public string firstName, lastName;
        public int studentNumber;
        public string[] courses;

        public Student (string assignmentName = "StudentBasic") : base (assignmentName) { }
        public Student (string firstName, string lastName, int studentNumber, string[] courses) : base () {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.courses = courses;
        }
        public override void AddLogic () {
            string[] courses = new string[] { "Development", "Analysis", "Skills", "Project" };
            Student s1 = new Student ("Sarah", "Smith", 123456, courses);
            Student s2 = new Student ("Bill", "Rogers", 654321, courses);
            this.ReturnsAnswer (s1.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
    }
    class Cat : Assignment {
        public string name, sound;
        public double weight;
        public Cat (string assignmentName = "CatBasic") : base (assignmentName) {

        }
        public Cat (string name, string sound, double weight) {
            this.name = name;
            this.sound = sound;
            this.weight = weight;
        }
        public override void AddLogic () {
            Cat c1 = new Cat ("Whiskers", "Meow", 1.5);
            string sc1 = c1.MakeSound ();
            c1.Feed ();
            double w1 = c1.weight;

            Cat c2 = new Cat ("Mr Fluffy", "Mauw", 1.6);
            string sc2 = c2.MakeSound ();
            c2.Feed ();
            double w2 = c2.weight;
            this.ReturnsAnswer (w2.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public string MakeSound () {
            return this.name + " says " + this.sound;
        }
        public void Feed () {
            this.weight += 0.5;
        }
    }
    class Rectangle : Assignment {
        public double length, width;
        public Rectangle (string assignmentName = "RectangleBasic") : base (assignmentName) {

        }
        public Rectangle (double length, double width) {
            this.length = length;
            this.width = width;
        }
        public override void AddLogic () {
            Rectangle r1 = new Rectangle (3.0, 4.0);
            Rectangle r2 = new Rectangle (5.0, 2.0);
            double l = r1.length;
            double w = r1.width;
            double a1 = r1.Area ();
            double a2 = r2.Area ();
            this.ReturnsAnswer (a1.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());

        }
        public double Area () {
            return this.length * this.width;
        }
    }
    class Planet : Assignment {
        public string name;
        public double distance, gravity;
        public Planet (string assignmentName = "PlanetBasic") : base (assignmentName) {

        }
        public Planet (string name, double distance, double gravity) {
            this.name = name;
            this.distance = distance;
            this.gravity = gravity;
        }
        public override void AddLogic () {
            Planet p1 = new Planet ("Jupiter", 5.203, 2.5);
            Planet p2 = new Planet ("Earth", 1.0, 1.0);
            string n1 = p1.name;
            double d1 = p1.distance;
            double g1 = p1.gravity;
            string sp1 = p1.Info ();
            string sp2 = p2.Info ();
            this.ReturnsAnswer (sp1.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public string Info () {
            return "Planet " + this.name + ", distance: " + this.distance + "AU, gravity: " + this.gravity;
        }
    }
    class Vector2 : Assignment {
        public double x, y;
        public Vector2 (string assignmentName = "Vector2Basic") : base (assignmentName) {

        }
        public Vector2 (double x, double y) {
            this.x = x;
            this.y = y;
        }
        public override void AddLogic () {
            var v1 = new Vector2 (2.0, 4.0);
            var v2 = new Vector2 (5.0, 1.0);
            var r = v1.Times (3.0);
            var q = v2.Plus (r);
            var p = v2.Times (q.x + q.y);
            this.ReturnsAnswer (p.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public Vector2 Times (double value) {
            var newX = this.x * value;
            var newY = this.y * value;
            return new Vector2 (newX, newY);
        }
        public Vector2 Plus (Vector2 vectorToAdd) {
            var newX = this.x + vectorToAdd.x;
            var newY = this.y + vectorToAdd.y;
            return new Vector2 (newX, newY);
        }
    }
    class Player : Assignment {
        public string name;
        public int healthPoints, damage;
        public Player (string assignmentName = "PlayerBasic") : base (assignmentName) { }
        public Player (string name, int damage) {
            this.name = name;
            this.damage = damage;
            this.healthPoints = 100;
        }
        public override void AddLogic () {
            Player pl1 = new Player ("John Snow", 30);
            Player pl2 = new Player ("Night King", 60);
            string winner = null;
            while (winner == null) {
                pl1.TakeDamage (pl2.damage);
                pl2.TakeDamage (pl1.damage);
                if (pl1.healthPoints < 0 && pl2.healthPoints < 0) {
                    winner = "It is a draw";
                } else if (pl1.healthPoints < 0) {
                    winner = pl2.name + " wins";
                } else if (pl2.healthPoints < 0) {
                    winner = pl1.name + " wins";
                }
            }
            this.ReturnsAnswer (pl2.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());

        }
        public void TakeDamage (int amount) {
            this.healthPoints -= amount;
        }

    }
    class Car : Assignment {
        public string make, model;
        public int speed;
        public Car (string assignmentName = "CarBasic") : base (assignmentName) { }
        public Car (string make, string model) {
            this.make = make;
            this.model = model;
            this.speed = 0;
        }
        public override void AddLogic () {
            Car ca1 = new Car ("Toyota", "Yaris");
            Car ca2 = new Car ("Ferrari", "458 Italia Coupe");
            ca1.SpeedUp (60);
            ca1.SlowDown (5);
            ca2.SpeedUp (100);
            ca2.SlowDown (10);

            string sa1 = "The " + ca1.make + " " + ca1.model + " is going " + ca1.speed + "km/hr. It is ";
            sa1 += ca1.IsSpeeding (80) ? "speeding" : "not speeding";

            string sa2 = "The " + ca2.make + " " + ca2.model + " is going " + ca2.speed + "km/hr. It is ";
            sa2 += ca2.IsSpeeding (80) ? "speeding" : "not speeding";
            this.ReturnsAnswer (sa2.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public void SpeedUp (int value) {
            this.speed += value;
        }
        public void SlowDown (int value) {
            this.speed -= value;
        }
        public bool IsSpeeding (int speedLimit) {
            if (this.speed > speedLimit) {
                return true;
            }
            return false;
        }
    }
    class Turtle : Assignment {
        public Position position;
        public bool penOn;
        public Turtle (string assignmentName = "TurtleBasic") : base (assignmentName) { }
        public Turtle () {
            this.position = new Position (0, 0);
            this.penOn = false;
        }
        public override void AddLogic () {
            Turtle leonardo = new Turtle ();
            leonardo.Pen (true);
            leonardo.Right (10);
            leonardo.Up (10);
            leonardo.Left (5);
            leonardo.Down (4);
            int xPos = leonardo.position.x;
            int yPos = leonardo.position.y;
            this.ReturnsAnswer (xPos.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public void Right (int value) {
            this.position.x += value;
        }
        public void Left (int value) {
            this.position.x -= value;
        }
        public void Up (int value) {
            this.position.y += value;
        }
        public void Down (int value) {
            this.position.y -= value;
        }
        public void Pen (bool value) {
            this.penOn = value;
        }
    }
    class Position {
        public int x, y;
        public Position (int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    class Canvas : Assignment {
        public Line[] lines;
        public int numLines;
        public Canvas (string assignmentName = "CanvasBasic") : base (assignmentName) { }
        public Canvas (int size) {
            this.lines = new Line[size];
            this.numLines = 0;
        }
        public override void AddLogic () {
            Point po1 = new Point (2.0, 1.0);
            Point po2 = new Point (6.0, 4.0);
            Line line1 = new Line (po1, po2);
            double length = line1.Distance ();
            Canvas myCanvas = new Canvas (3);
            myCanvas.AddLine (line1);
            int numberOfLines = myCanvas.numLines;
            myCanvas.Undo ();
            numberOfLines = myCanvas.numLines;
            myCanvas.Undo ();
            numberOfLines = myCanvas.numLines;
            myCanvas.AddLine (line1);
            Point p3 = new Point (0.0, 0.0);
            Point p4 = new Point (1.0, 1.0);
            Line line2 = new Line (p3, p4);
            myCanvas.AddLine (line2);
            myCanvas.AddLine (line1);
            numberOfLines = myCanvas.numLines;
            myCanvas.AddLine (line2);
            numberOfLines = myCanvas.numLines;
            this.ReturnsAnswer (null);
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public void AddLine (Line lineToAdd) {
            if (this.numLines < this.lines.Length) {
                this.lines[this.numLines] = lineToAdd;
                this.numLines += 1;
            } else { }
        }
        public void Undo () {
            if (this.numLines > 0) {
                this.lines[numLines - 1] = null;
                this.numLines -= 1;
            } else { };
        }

    }
    class Point {
        public double x, y;
        public Point (double x, double y) {
            this.x = x;
            this.y = y;
        }
    }
    class Line {
        public Point[] points;
        public Line (Point pointOne, Point pointTwo) {
            this.points = new Point[2];
            this.points[0] = pointOne;
            this.points[1] = pointTwo;
        }
        public double Distance () {
            var distance = 5;
            return distance;
        }
    }
}