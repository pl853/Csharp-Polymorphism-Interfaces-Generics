using System;
using System.IO;
using Csharp_Polymorphism_Interfaces_Generics.Utils;

namespace Csharp_Polymorphism_Interfaces_Generics.Subjects

{
    class Generics : Subject
    {
        public Generics(string subjectName = "Generics") : base(subjectName)
        {
        }

        public override void AddMainLogic()
        {
            bool notExited = true;
            Console.Clear();
            System.Console.WriteLine(ReturnInfo());
            ReturnCode("./TheoreticalInfo/");
            while (notExited)
            {
                Console.Write("Select an assignment:\n \n1: BA-1\n2: BA-2\n3: BA-3\n4: BA-4\n5: BA-5\n6: BA-6\n7: BA-7\n8: BA-8\n9: BA-9\n\nb to go back\n");
                string caseSwitch = Console.ReadLine();
                System.Console.WriteLine("\n");
                switch (caseSwitch)
                {
                    case "1":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "2":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "3":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "4":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "5":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "6":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "7":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "8":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "9":
                        Console.Clear();
                        System.Console.ResetColor();
                        break;
                    case "b":
                        notExited = false;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("Not a valid option please try again.");
                        break;
                }
            }
        }
        // // BA-1B
        // class Array<a> : Assignment
        // {
        //     public a[] elems;

        //     public Array(int amount)
        //     {
        //         this.elems = new a[amount];
        //     }

        //     public void CopyByVal(a[] new_elems)
        //     {
        //         var elems_dest = new a[new_elems.Length];
        //         for (int i = 0; i < new_elems.Length; i++)
        //         {
        //             elems_dest[i] = new_elems[i];
        //         }

        //         this.elems = elems_dest;
        //     }

        //     public void CopyByRef(a[] new_elems)
        //     {
        //         this.elems = new_elems;
        //     }

        //     public override void AddLogic()
        //     {
        //         var elems = new int[] { 1, 5, 9, -1, 7 };
        //         var array1 = new Array<int>(elems.Length);
        //         array1.CopyByVal(elems);
        //         array1.elems[2] = 99;
        //         array1.CopyByRef(elems);
        //         array1.elems[2] = 99;
        //     }
        // }
        // // BA-2B
        // interface Option<a>
        // {
        //     b Visit<b>(Func<a, b> on_some, Func<b> on_none);
        // }

        // class None<a> : Option<a>
        // {
        //     public None() { }

        //     public b Visit<b>(Func<a, b> on_some, Func<b> on_none)
        //     {
        //         return on_none();
        //     }
        // }

        // class Some<a> : Option<a>
        // {
        //     a v;
        //     public Some(a v) { this.v = v; }

        //     public b Visit<b>(Func<a, b> on_some, Func<b> on_none)
        //     {
        //         return on_some(this.v);
        //     }
        // }

        // class Treasure : Assignment
        // {
        //     int gold;
        //     public Treasure()
        //     {
        //         this.gold = 100;
        //     }

        //     public override void AddLogic()
        //     {
        //         var treasure_or_not = new Option<Treasure>[]{
        //             new None<Treasure>(),
        //             new Some<Treasure>(new Treasure()),
        //             new None<Treasure>(),
        //             new None<Treasure>(),
        //             new Some<Treasure>(new Treasure())
        //         };

        //         int loot = 0;
        //         for (int i = 0; i < treasure_or_not.Length; i++)
        //         {
        //             Func<Treasure, int> onSome = v => v.gold;
        //             Func<int> onNone = () => 0;
        //             loot += treasure_or_not[i].Visit<int>(onSome, onNone);
        //         }
        //     }
        // }

        // interface Visitor<a, b>
        // {
        //     b onSome(a _a);
        //     b onNone();
        // }

        // class IntVisitorToString : Visitor<int, string>
        // {
        //     public string onNone()
        //     {
        //         return "";
        //     }
        //     public string onSome(int v)
        //     {
        //         return "" + v;
        //     }
        // }

        // interface OptionIntString
        // {
        //     string Visit(IntVisitorToString v);
        // }

        // class None : OptionIntString
        // {
        //     public None() { }
        //     public string Visit(IntVisitorToString vis)
        //     {
        //         return vis.onNone();
        //     }
        // }

        // class Some : Assignment, OptionIntString
        // {
        //     public int v;
        //     public Some(int v)
        //     {
        //         this.v = v;
        //     }

        //     public string Visit(IntVisitorToString vis)
        //     {
        //         return vis.onSome(this.v);
        //     }

        //     public override void AddLogic()
        //     {
        //         var values_or_not = new OptionIntString[]{
        //             new Some(7),
        //             new None(),
        //             new Some(5),
        //             new None()
        //         };
        //         var s = "";
        //         var v = new IntVisitorToString();
        //         for (int i = 0; i < values_or_not.Length; i++)
        //         {
        //             var x = values_or_not[i];
        //             s = s + x.Visit(v) + "; ";
        //         }
        //     }
        // }
        interface Visitor<a, b>
        {
            b OnSome(a _a);
            b OnNone();
        }

        interface Option<a, b>
        {
            b Visit(Visitor<a, b> v);
        }

        class None<a, b> : Option<a, b>
        {
            public None() { }

            public b Visit(Visitor<a, b> vis)
            {
                return vis.OnNone();
            }
        }


        class IntVisitorToString : Visitor<int, string>
        {
            public string OnNone()
            {
                return "###";
            }
            public string OnSome(int v)
            {
                return "|" + v + "|";
            }
        }

    }
}