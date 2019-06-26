namespace Csharp_Polymorphism_Interfaces_Generics
{
    interface IDier
    {
        void Feed();
    }

    class Paard : IDier
    {
        public Paard()
        {

        }

        public void Feed()
        {
            System.Console.WriteLine("krijgtyfus");
        }
    }

    public class ADier
    {
        public int legs;
        public bool isDead;
        public bool isFed;

        public ADier(bool isDead, bool isFed)

        {
            this.legs = 0;
            this.isDead = isDead;
            this.isFed = isFed;
        }
        public virtual void Feed() { this.isFed = true; }

    }

    class Schaap : ADier
    {
        public Schaap(bool isDead, bool isFed) : base(isDead, isFed)
        {

        }
    }

    interface IPerson
    {
        void Hit();
    }

    class Jawed : IPerson
    {
        public Jawed()
        {

        }

        public void Hit()
        {
            System.Console.WriteLine("Kut");
        }
    }

    class Pieter : Jawed
    {
        public Pieter()
        {
            Hit();
        }

        public void Hit()
        {
            System.Console.WriteLine("kutniew");
        }
    }

    public abstract class Teringlul
    {
        public abstract int Size();
    }



}