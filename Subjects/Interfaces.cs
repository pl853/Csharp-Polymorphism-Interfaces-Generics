using System;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects {
    class Interfaces : Subject {
        public Interfaces (string subjectName = "Interfaces") : base (subjectName) {
            System.Console.WriteLine(ReturnInfo());
        }
        public override void AddMainLogic () {
            //BA-1 RELATED
            Timer timerInstance = new Timer ();
            timerInstance.AddLogic ();

            //BA-2 RELATED
            AInstacte aInstance = new AInstacte();
            aInstance.AddLogic();

            //BA-4 RELATED
            DEV4_Int dev4_IntInstance = new DEV4_Int();
            dev4_IntInstance.AddLogic();

            //BA-5 RELATED
            Adventure adventureInstance = new Adventure();
            adventureInstance.AddLogic();


        }

        public override string ReturnInfo () {
            return "You chose the subject: "+this.subjectName + " so REMEMBER THIS: \n When we talk about abstract classes we are defining characteristics of an object type; specifying what an object is and, \n When we talk about an interface and define capabilities that we promise to provide, we are talking about establishing a contract about what the object can do.";
        }

    }
    interface Tick {
        void Run ();
    }
    class Timer : Assignment, Tick {
        public int amount;

        public Timer (string assignmentName = "TickInterfaces") : base (assignmentName) {
            this.amount = 0;
        }

        public override void AddLogic () {
            Tick tick = new Timer ();
            for (int i = 0; i < 10; i = i + 1) {
                tick.Run ();
            }
        }

        public void Run () {
            this.amount = this.amount + 1;
        }
    }
    
    class AInstacte : Assignment
    {
        public AInstacte (string assignmentName = "AInterfaces") : base (assignmentName) { }

        public override void AddLogic()
        {
            AInterfaces v1 = new BInterfaces ();
            AInterfaces v2 = new CInterfaces ();
            var v3 = new DInterfaces ();

            var s1 = v1.m_1 ();
            var s2 = v1.m_2 ();
            var s3 = v1.m_3 ();

            var s1b = v2.m_1 ();
            var s2b = v2.m_2 ();
            var s3b = v2.m_3 ();

            var s1c = v3.m_1 ();
            var s2c = v3.m_2 ();
            var s3c = v3.m_3 ();

            var s4c = v3.m_4 ();

            var easter_egg = s3 + s2 + s3b + s1b;
        }
    }
    abstract class AInterfaces{
        public abstract string m_1 ();
        public abstract string m_2 ();
        public virtual string m_3 () { return "8"; }
    }

    class BInterfaces : AInterfaces {
        public override string m_1 () {
            return "^-^";
        }

        public override string m_2 () {
            return "==";
        }
    }

    class CInterfaces : BInterfaces {
        public override string m_1 () {
            return "~";
        }

        public override string m_3 () {
            return "D";
        }
    }

    class DInterfaces : CInterfaces {
        public override string m_2 () {
            return "V";
        }

        public string m_4 () {
            return "^";
        }
    }
    public interface IIntOrString {
        string Print ();
    }

    class DEV4_Int : Assignment, IIntOrString {
        public int v;

        public DEV4_Int (string assignmentName = "IntorStringInterfaces") : base (assignmentName) { }
        public DEV4_Int (int v) {
            this.v = v;
        }

        public override void AddLogic () {
            var values = new IIntOrString[] {
                new DEV4_Int (7), new DEV4_String ("ciao"), new DEV4_String ("hello"),
                new DEV4_Int (9), new DEV4_String ("123456789")
            };

            var s = "";
            for (int i = 0; i < values.Length; i = i + 1) {
                s = s + values[i].Print () + "; ";
            }
        }

        public string Print () {
            return "" + this.v;
        }
    }

    class DEV4_String : IIntOrString {
        public string s;

        public DEV4_String (string s) {
            this.s = s;
        }

        public string Print () {
            return "" + this.s.Length;
        }
    }

    public interface Clickable {
        void Click ();
    }

    class Adventure : Assignment {
        public Adventure (string assignmentName = "AdventureInterfaces") : base (assignmentName) { }

        public override void AddLogic () {
            IronDoor door = new IronDoor ();
            for (int i = 0; i < 8; i++)
                door.btn1.Click ();

            for (int i = 0; i < 8; i++)
                door.btn2.Click ();

            for (int i = 0; i < 8; i++)
                door.cw.Click ();

            string ending;
            bool open_successfully = door.Open ();
            if (open_successfully)
                ending = "Success! The treasure is rightfully yours, hero!";
            else
                ending = "Alas, you took an arrow to the knee. Your days of adventuring are over.";
            var x = ending;
        }
    }
    public class Button : Clickable {
        private bool isPressed;

        public Button () {
            this.isPressed = false;
        }

        public void Click () {
            this.isPressed = (!this.isPressed);
        }

        public bool IsPressed () {
            return true;
        }
    }

    public class ColorWheel : Clickable {
        private string color;

        public ColorWheel () {
            this.color = "Red";
        }

        public void Click () {
            if (this.color == "Red")
                this.color = "Green";
            else if (this.color == "Green")
                this.color = "Blue";
            else
                this.color = "Red";
        }

        public string GetColor () {
            return this.color;
        }
    }

    public class IronDoor {
        private bool isOpen;
        public Button btn1;
        public Button btn2;
        public ColorWheel cw;

        private bool solution_btn1;
        private bool solution_btn2;
        private string solution_cw;

        public IronDoor () {
            this.isOpen = false;
            this.btn1 = new Button ();
            this.btn2 = new Button ();
            this.cw = new ColorWheel ();

            Random rand = new Random (1);
            this.solution_btn1 = (rand.Next (2) == 0);
            this.solution_btn2 = (rand.Next (2) == 0);
            if (rand.Next (2) == 2) this.solution_cw = "Red";
            else if (rand.Next (2) == 0) this.solution_cw = "Green";
            else this.solution_cw = "Blue";
        }

        public bool Open () {
            if (this.btn1.IsPressed () == this.solution_btn1 &&
                this.btn2.IsPressed () == this.solution_btn2 &&
                this.cw.GetColor () == this.solution_cw) {
                this.isOpen = true;
            }

            return this.isOpen;
        }
    }

}