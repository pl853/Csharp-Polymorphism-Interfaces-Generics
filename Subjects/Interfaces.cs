using System;
using System.Reflection;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects {
    class Interfaces : Subject {
        public Interfaces (string subjectName = "Interfaces") : base (subjectName) {
            System.Console.WriteLine (ReturnInfo ());
        }
        public override void AddMainLogic () {
            //BA-1 RELATED
            Timer timerInstance = new Timer ();
            timerInstance.AddLogic ();

            //BA-2 RELATED
            AInstacte aInstance = new AInstacte ();
            aInstance.AddLogic ();

            //BA-4 RELATED
            DEV4_Int dev4_IntInstance = new DEV4_Int ();
            dev4_IntInstance.AddLogic ();

            //BA-5 RELATED
            Adventure adventureInstance = new Adventure ();
            adventureInstance.AddLogic ();

            //BA-6 RELATED
            SciFi scifiInstance = new SciFi ();
            scifiInstance.AddLogic ();

            //BA-7 RELATED
            PlayerInterfaces playerInterfacesInstance = new PlayerInterfaces();
            playerInterfacesInstance.AddLogic();

            //BA-8 RELATED
            PersonInterfaces2 personInterFaces2Instance = new PersonInterfaces2();
            personInterFaces2Instance.AddLogic();

            //BA-9 RELATED
            AccessModifiers accesModifiersInstance = new AccessModifiers();
            accesModifiersInstance.AddLogic();

            //BA-10 FCKING GOTIT
            Vector2Interfaces vector2InterfacesInstance = new Vector2Interfaces();
            vector2InterfacesInstance.AddLogic();


        }

        public override string ReturnInfo () {
            return "You chose the subject: " + this.subjectName + " so REMEMBER THIS: \n When we talk about abstract classes we are defining characteristics of an object type; specifying what an object is and, \n When we talk about an interface and define capabilities that we promise to provide, we are talking about establishing a contract about what the object can do.";
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
            this.ReturnsAnswer ("complete");
            System.Console.WriteLine (this.ReturnCorrect ());
        }

        public void Run () {
            this.amount = this.amount + 1;
        }
    }

    class AInstacte : Assignment {
        public AInstacte (string assignmentName = "AInterfaces") : base (assignmentName) { }

        public override void AddLogic () {
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
                        this.ReturnsAnswer (easter_egg.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
    }
    abstract class AInterfaces {
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
                        this.ReturnsAnswer (s.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
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
                        this.ReturnsAnswer (x.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
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
    class SciFi : Assignment {

        public SciFi (string assignmentName = "ScifiInterface") : base (assignmentName) { }
        public override void AddLogic () {
            T800 arnie = new T800 ("I'll be back.");
            string arnie_catchphrase = arnie.Talk ();

            Human kyle_reese = new Human ("Kyle Reese", "Come with me if you want to live!");
            string kyle_catchphrase = kyle_reese.Talk ();

            T1000 t1000 = new T1000 ("Have you seen this boy?");

            t1000.ShapeShift ("Police officer");
            string t1000_catchphrase = t1000.Talk ();
            t1000.ShapeShift ("Sarah Connor");
            this.ReturnsAnswer (t1000.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
        }
    }
    public class T800 : Terminator {
        public T800 (string catchphrase) : base (catchphrase) {
            this.appearance = "Austrian Oak";
        }

        public override string Talk () { return this.catchphrase; }
    }

    public class T1000 : T800 {
        public T1000 (string catchphrase) : base (catchphrase) {
            this.appearance = "Liquid metal";
        }

        public override string Talk () { return this.catchphrase; }

        public void ShapeShift (string appearance) {
            this.appearance = appearance;
        }
    }

    public class Human : HumanoidBehavior {
        public string name;
        public string catchphrase;

        public Human (string name, string catchphrase) {
            this.name = name;
            this.catchphrase = catchphrase;
        }

        public string Talk () { return this.catchphrase; }
    }

    public interface HumanoidBehavior {
        string Talk ();
    }

    public abstract class Terminator {
        public string appearance;
        public string catchphrase;
        public Terminator (string catchphrase) {
            this.catchphrase = catchphrase;
            this.appearance = "No Appearance";
        }
        public virtual string Talk () {
            return "";
        }
    }
  class PlayerInterfaces : Assignment
  {
    private string name;
    private int level;
    private int experience;
    private int[] exp_chart = new int[] { 100, 250, 450, 700, 1000 };
    private Weapon weapon;
    public PlayerInterfaces():base(){this.assignmentName = "PlayerInterfaces";}

    public PlayerInterfaces(string name)
    {
      this.name = name;
      this.level = 1;
      this.experience = 0;
      this.weapon = new Weapon("Dagger", 26);
    }

    public override void AddLogic()
    {
      PlayerInterfaces player = new PlayerInterfaces("Locke Cole");
      string name = player. GetName() ;

      player.GainExperience(150);
      int current_level =  player.GetLevel() ;

      int current_attack = player.GetWeapon().GetAttackPower();


      Weapon wpn = new Weapon("Lightbringer", 255);
      player.SetWeapon(wpn) ;
      string current_weapon = player.GetWeapon().GetName() ;
      current_attack = player.GetWeapon().GetAttackPower() ;



      player.GainExperience(300);
      current_level = player. GetLevel() ;
                  this.ReturnsAnswer (current_attack.ToString());
            System.Console.WriteLine (this.ReturnCorrect ());
    }

    public string GetName() { return this.name ; }

    public int GetLevel() { return this. level ; }

    public void SetWeapon(Weapon wpn) {  this.weapon  = wpn; }

    public Weapon GetWeapon() { return this.weapon ; }

    public void GainExperience(int amount)
    {
      if (amount > 0)
      {
        this.experience += amount;
        this.CheckLevel();
      }
    }

    // Pop quiz: why would this method be private?
    // If you don't know, check back on the FA's.
    private void CheckLevel()
    {
      for (int i = 0; i < this.exp_chart.Length; i++)
      {
        if (this.experience < this.exp_chart[i])
        {
          this.level = i + 1;
          break;
        }
      }
    }
  }

  public class Weapon
  {
    private string name;
    private int attackpower;
    public Weapon(string name, int ap)
    {
      this.name = name;
      this.attackpower = ap;
    }

    public string GetName() { return this.name ; }
    public int GetAttackPower() { return this.attackpower; }
  }
class PersonInterfaces : Assignment
  {
    protected string name;
    private int id;
    public string gender;
    public PersonInterfaces(string assignmentName="PersonInterfaces"):base(assignmentName){}
    public PersonInterfaces(string name, int id, string gender)
    {
      this.name = name;
      this.id = id;
      this.gender = gender;
    }

    public override void AddLogic()
    {
      StudentInterfaces s = new StudentInterfaces("John Doe", 54321, "male");
      string name = s. GetName() ;
      int id = s. GetId() ;
      string gender = s. gender ;
      string introduction = s.Introduction();
                  this.ReturnsAnswer (introduction.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
    }

    public string GetName() { return this.name; }
    public int GetId() { return this.id; }
  }

  class StudentInterfaces : PersonInterfaces
  {
    public StudentInterfaces(string name, int id, string gender) :
      base(name, id, gender) { }

    public string Introduction()
    {
      return "I am " + this. name  + ", " + this. gender  +
        ", and my student ID is " + this.GetId() ;
    }
  }
  class PersonInterfaces2 : Assignment
  {
    protected string name;
    private int id;
    public string gender;
    public PersonInterfaces2(string assignmentName="PersonInterFaces2"):base(assignmentName){}
    public PersonInterfaces2(string name, int id, string gender)
    {
      this.name = name;
      this.id = id;
      this.gender = gender;
    }

    public override void AddLogic()
    {
      StudentInterfaces2 s = new StudentInterfaces2("John Doe", 54321, "male");
      string name = s. GetName() ;
      int id = s. GetId() ;
      string gender = s. gender ;
      string introduction = s.Introduction();
                        this.ReturnsAnswer (introduction.ToString());
            System.Console.WriteLine (this.ReturnCorrect ());
    }

    public string GetName() { return this.name; }
    public int GetId() { return this.id; }
  }

  class StudentInterfaces2 : PersonInterfaces2
  {
    public StudentInterfaces2(string name, int id, string gender) :
      base(name, id, gender) { }

    public string Introduction()
    {
      return "I am " + this. name  + ", " + this. gender  +
        ", and my student ID is " + this.GetId() ;
    }
  }
  class AccessModifiers : Assignment
  {
    public AccessModifiers(string assignmentName ="AccesModifiersInterfaces"):base(assignmentName){}
    public override void AddLogic()
    {
      InheritMystery hmmm = new InheritMystery();
      var whatIsA = hmmm.a;
     //var whatIsB = hmmm.a;//-> SHOULD be Error
       //var whatIsC = hmmm.c;// -> SHOULD be Error
      hmmm.Test();

      var acessModifierACorrect = TestAccessModifiers("a", "Public");
      var acessModifierBCorrect = TestAccessModifiers("b", "Private");
      var acessModifierCCorrect = TestAccessModifiers("c", "Family");
                        this.ReturnsAnswer (acessModifierCCorrect.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
    }
    public static bool TestAccessModifiers(string field, string test)
    {
      return typeof(Mystery).GetField(field, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).Attributes.ToString() == test;
    }
  }

  public class Mystery
  {
     public int a = 1;
     private  int b = 2;
     protected  int c = 3;
  }

  public class InheritMystery : Mystery
  {
    public void Test()
    {
      var whatIsA = a;
      //var whatIsB = b; -> Error
      var whatIsC = c;
    }
  }

  public  interface Ship  {
     void Update(double dt = 0.0) ;
  }

  class SimpleSpaceShip : Ship {
    public Vector2Interfaces position;
    public Vector2Interfaces velocity;

    public SimpleSpaceShip(Vector2Interfaces pos, Vector2Interfaces vel){
      this.position = pos;
      this.velocity = vel;
    }

    public void Update(double dt){
      this.position.Sum(this.velocity.Mul(dt));
    }
  }

    class Vector2Interfaces : Assignment {
    public  double  x;
    public double  y;
    public Vector2Interfaces(string assignmentName="Vector2Interfaces"): base(assignmentName){}
    public Vector2Interfaces( double x,  double  y) {
       this.x = x ;
       this.y = y ;
    }

    public override void AddLogic()
    {
      var p1 = new Vector2Interfaces(0.0,0.0);
      var v1 = new Vector2Interfaces(10.0,10.0);
      SimpleSpaceShip  s = new SimpleSpaceShip(p1,v1) ;
      EnterpriseNX01 nx1 =  new EnterpriseNX01(s) ;
      nx1.GoToWarp(3.0);

      var p2 = new Vector2Interfaces(0.0,100.0);
      var v2 = new Vector2Interfaces(10.0,10.0);
       SimpleSpaceShip  tv = new SimpleSpaceShip(p2, v2);

       Ship[]  fleet = new Ship[2]{nx1,tv} ;

      for(int i = 0; i < fleet.Length; i = i + 1 ){
        fleet[i].Update(0.16);
     }
                             this.ReturnsAnswer (fleet.ToString ());
            System.Console.WriteLine (this.ReturnCorrect ());
    }

    public Vector2Interfaces  Mul(double  c){
      Vector2Interfaces res = new Vector2Interfaces((this.x*c),(this.y*c));
      return res;
    }

    public void Sum(Vector2Interfaces v1) {
      this.x = this.x + v1.x;
      this.y = this.y + v1.y;
    }
  }

  class WarpEngine {
    public double current_warp_factor;
    public double max_warp;

    public WarpEngine(){
      this.current_warp_factor =  0.0 ;
      this.max_warp =  5.0 ;
    }

    public void SetWarpFactor(double factor){
      this.current_warp_factor = Math.Min(factor, this.max_warp);
    }

    public double GetWarpSpeed() {
      var warp_factor = this.current_warp_factor;
      var speed_light = 1.0;
      return speed_light / Math.Pow(warp_factor, 10.0/3.0);
    }
  }

  public abstract class ShipDecorator   : Ship {
    public Ship ship ;

    public ShipDecorator(Ship ship)   {
       this.ship = ship  ;
    }

    public  void Update(double dt) {}
  } 

  class EnterpriseNX01 : ShipDecorator {
    public WarpEngine warp_engine;

    public EnterpriseNX01(Ship  ship) : base(ship) {
      this.ship = ship;
       this.warp_engine = new WarpEngine();
    }

    public void GoToWarp(double factor) {
       this .warp_engine.SetWarpFactor(factor);
    }

    public void Update(double dt) {
      var multiplier = this.warp_engine.GetWarpSpeed();
      this.ship.Update(dt * multiplier);
    }
  }

}