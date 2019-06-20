using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects {
    class Polymorphism : Subject {
        public Polymorphism (string subjectName = "Polymorphism") : base (subjectName) {
            System.Console.WriteLine(ReturnInfo());
        }
        public override void AddMainLogic () {
            X xInstance = new X ();
            xInstance.AddLogic ();

            Compute computeInstance = new Compute ();
            computeInstance.AddLogic ();

            StudentPolymorphism studentPolymorphismInstance = new StudentPolymorphism ();
            studentPolymorphismInstance.AddLogic ();

            Simple simpleInstance = new Simple();
            simpleInstance.AddLogic();

            X_h x_hInstance = new X_h ();
            x_hInstance.AddLogic ();

            Person personInstance = new Person ();
            personInstance.AddLogic ();

            Shape shapeInstance = new Shape ();
            shapeInstance.AddLogic ();

            Tool toolInstace = new Tool();
            toolInstace.AddLogic();

            A aInstance = new A();
            aInstance.AddLogic();

            CarPolymorphism carInstance = new CarPolymorphism();
            carInstance.AddLogic();
            
            StudentPolymorphism3 studentPolymorphism3Instance = new StudentPolymorphism3();
            studentPolymorphism3Instance.AddLogic();

            Fighter fighterInstance = new Fighter();
            fighterInstance.AddLogic();

        }
        public override string ReturnInfo () {
            return "You chose the subject: "+this.subjectName + "\n";
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
    class Simple :Assignment {

    public Simple(string assignmentName="SimplePolymorphism"):base(assignmentName){}
    public override void AddLogic(){
      double n1 = 36.0;
      int x1 = 2;
      int res1 = ComputeAmountOfDivisions(n1, x1);

      double n2 = 1024.0;
      int x2 = 2;
      int res2 = ComputeAmountOfDivisions(n2, x2);      

      double n3 = 3333.0;
      int x3 = 3;
      int res3 = ComputeAmountOfDivisions(n3, x3); 
      this.ReturnsAnswer (null);
      System.Console.WriteLine (this.ReturnCorrect ());
      
    }

    public static int ComputeAmountOfDivisions(  double n, int   x){
        return 0;
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
            this.ReturnsAnswer (tools.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
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
    class A : Assignment {
        public double a;

        public A (string assignmentName = "APolymorphism") : base (assignmentName) { }
        public A (int a) {
            this.a = a;
        }

        public override void AddLogic () {
            B object1 = new B (555, 883);
            double result = object1.GetA ();
            A object2 = new B (123, 321);
            result = object2.GetA ();
            A object3 = new A (9001);
            result = object3.GetA ();
            this.ReturnsAnswer (result.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public virtual double GetA () {
            return this.a;
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

    class CarPolymorphism : Assignment {
        public string carName;
        public int carYear;
        public int mileage;
        public string carType;

        public CarPolymorphism (string assignmentName = "CarPolymorphism") : base (assignmentName) { }
        public CarPolymorphism (string carName, int carYear, int mileage) {
            this.carName = carName;
            this.carYear = carYear;
            this.mileage = mileage;
            this.carType = "Boredom";
        }

        public override void AddLogic () {
            var boreCar = new CarPolymorphism ("Boremobile", 1990, 0);
            var mainCar = new Primary ("BMW X6", 2015, 20000);
            var weekendCar = new Weekend ("Ford mustang", 1965, 160000);
            CarPolymorphism storePrimaryInCarVar = new Primary ("Toyota Yaris", 2015, 222);
            CarPolymorphism storeWeekendInCarVar = new Primary ("Ferrari 458 Italia Coupe", 2018, 10000);

            string output = "";
            output = boreCar.CarInfo ();
            output = boreCar.RoofType ();
            output = mainCar.CarInfo ();
            output = mainCar.DriveFast ();
            output = mainCar.RoofType ();
            output = weekendCar.CarInfo ();
            output = weekendCar.DriveInStyle ();
            output = weekendCar.RoofType ();
            output = storePrimaryInCarVar.RoofType ();
            output = storeWeekendInCarVar.RoofType ();
            this.ReturnsAnswer (output.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public string CarInfo () => "Car type: " + this.carType + ". Build year: " + this.carYear + ". Car name: " + this.carName + "\n" + " I drove it for " + this.mileage + " KM";

        public virtual string RoofType () {
            return "unknown";
        }
    }

    class Primary : CarPolymorphism {
        public Primary (string carName, int carYear, int mileage) : base (carName, carYear, mileage) {
            this.carType = "Primary";

        }
        public string DriveFast () {
            return "Whoop I am fast";
        }
        public override string RoofType () {
            return "Sunroofs";
        }
    }

    class Weekend : CarPolymorphism {
        public Weekend (string carName, int carYear, int mileage) : base (carName, carYear, mileage) {
            this.carType = "Weekend";

        }
        public string DriveInStyle () {
            return "I am cruising on the highway";
        }
        public override string RoofType () {
            return "Convertible";
        }
    }

    class Shape : Assignment {
        public int x, y;
        public Shape (string assignmentName = "ShapePolymorphism") : base (assignmentName) { }
        public Shape (int x, int y) {
            this.x = x;
            this.y = y;
        }

        public override void AddLogic () {
            Shape shape = new Shape (10, 30);
            string shape_dims = shape.GetDims ();

            Triangle tri = new Triangle (6, 9);
            string tri_dims = tri.GetDims ();
            double area = tri.Area ();
            this.ReturnsAnswer (area.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public virtual string GetDims () {
            return "Width: " + this.x + "; Height: " + this.y;
        }

    }

    class Triangle : Shape {

        public Triangle (int x, int y) : base (x, y) {

        }

        public double Area () {
            return (this.x * this.y / 2);
        }

    }

    class StudentPolymorphism3 : Assignment {
        string name;
        PersonPolymorphism1 base_Person;

        public StudentPolymorphism3 () : base () { this.assignmentName = "StudentPolymorphism3"; }

        public StudentPolymorphism3 (string name) {
            this.base_Person = new PersonPolymorphism1();
            this.name = name;
        }

        public override void AddLogic () {
            var s = new StudentPolymorphism3 ("Marlow");
            var x = s.SayHello ();
            s.Enlarge ();
            var y = s.SayHello ();
            s.Shrink ();
            var z = s.SayHello ();
            this.ReturnsAnswer (z.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public string SayHello () {
            return this.name + ": " + this.base_Person.SayHello();
        }

        public void Shrink () {
            this.base_Person = new ShortPerson ();
        }

        public void Enlarge () {
            this.base_Person = new TallPerson ();;
        }

    }
    public class PersonPolymorphism1 {
        public virtual string SayHello () {
            return "hello!";
        }
    }

    public class TallPerson : PersonPolymorphism1 {
        public override string SayHello () {
            return "nice weather up here!";
        }
    }

    public class ShortPerson : PersonPolymorphism1 {
        public override string SayHello () {
            return "hey, I found a penny!";
        }
    }

    class Fighter : Assignment {
        public int healthPoints;
        public int strength;
        public Fighter (string assignmentName = "FighterPolymorphism") : base (assignmentName) { }
        public Fighter (int hp, int strength) {
            this.healthPoints = hp;
            this.strength = strength;
        }
        public override void AddLogic () {
            var paladin = new Paladin (1200, 100, 0.25);
            var darkKnight = new DarkKnight (1000, 120, 0.25, 0.30);

            int damage2Paladin = 0;
            int damage2DarkKnight = 0;

            while (paladin.GetHP () > 0 && darkKnight.GetHP () > 0) {
                damage2DarkKnight = paladin.Attack ();
                darkKnight.TakeDamage (damage2DarkKnight);
                damage2Paladin = darkKnight.Attack ();
                paladin.TakeDamage (damage2DarkKnight);
            }

            var outcome = "";
            if (paladin.GetHP () > 0 && darkKnight.GetHP () <= 0)
                outcome = "A glorious victory for the Paladin!";
            else if (paladin.GetHP () <= 0 && darkKnight.GetHP () > 0)
                outcome = "The Dark Knight has risen!";
            else
                outcome = "In war there are no winners, only widows.";
            var x = outcome;
            this.ReturnsAnswer (outcome.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
        public virtual int GetHP () {
            return this.healthPoints;
        }

        public virtual int Attack () {
            return this.strength;
        }

        public virtual void TakeDamage (int amount) {
            this.healthPoints -= amount;
        }

    }

    class Knight : Fighter {
        public double blockChance;

        public Knight (int hp, int strength, double blockChance) : base (hp, strength)

        {
            this.blockChance = blockChance;
        }

        public override void TakeDamage (int amount) {
            if (this.Block ())
                this.healthPoints -= amount / 4;
            else
                this.healthPoints -= amount;
        }

        public bool Block () {
            Random random = new Random (this.healthPoints);
            return (this.blockChance >= random.NextDouble ());
        }
    }

    class Paladin : Knight {
        public Paladin (int hp, int strength, double blockChance):
            base (hp, strength, blockChance) {
                this.blockChance += 0.1;
            }

        public override void TakeDamage (int amount) {
            if (this.Block ()) {
                this.healthPoints -= amount / 4;
                if (this.healthPoints >= 0) // Whenever a Paladin blocks, they heal a bit of their healthPoints.
                    this.healthPoints += this.HealAmount ();
            } else
                this.healthPoints -= amount;
        }

        public int HealAmount () {
            return strength / 5;
        }
    }

    class DarkKnight : Knight {
        public double critChance;

        public DarkKnight (int hp, int strength, double blockChance, double critChance):
            base (hp, strength, blockChance) {
                this.critChance = 0.3;
            }

        public override int Attack () {
            if (this.CriticalHit ()) // Dark Knights have a chance to double their damage.
                return 2 * this.strength;
            else
                return this.strength;
        }

        public bool CriticalHit () {
            Random random = new Random (this.healthPoints);
            return (this.critChance >= random.NextDouble ());
        }
    }

}