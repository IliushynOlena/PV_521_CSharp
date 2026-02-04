namespace _25_AbstractFactory
{
    abstract class Toy
    {
        public string Name { get; set; }
        public Toy(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a Toy. My name : {Name}");
        }
    }
    abstract class Cat : Toy
    {
        public Cat(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Cat. My name : {Name}");
        }
    }
    abstract class Bear : Toy
    {
        public Bear(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Bear. My name : {Name}");
        }
    }
    class TeddyCat : Cat
    {
        public TeddyCat(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Teddy Cat. My name : {Name}");
        }
    }
    class WoodenCat : Cat
    {
        public WoodenCat(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Wooden Cat. My name : {Name}");
        }
    }
     class TeddyBear : Bear
    {
        public TeddyBear(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Teddy Bear. My name : {Name}");
        }
    }
    class WoodenBear : Bear
    {
        public WoodenBear(string name) : base(name) { }
        public override void Print()
        {
            Console.WriteLine($"I am a Wooden Bear. My name : {Name}");
        }
    }

    interface IToyFactory
    {
        Cat CreateCat();
        Bear CreateBear();
    }
    class TeddyFactory : IToyFactory
    {
        public Bear CreateBear()
        {
            return new TeddyBear("Teddy Bear TED");
        }

        public Cat CreateCat()
        {
            return new TeddyCat("Teddy Cat Tom");
        }
    }
    class WoodenFactory : IToyFactory
    {
        public Bear CreateBear()
        {
            return new WoodenBear("Wooden Bear GRIZLI");
        }

        public Cat CreateCat()
        {
            return new WoodenCat("Wooden Cat Billi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MS SQL connection read update close()

            //Postress  connection read update close()
            IToyFactory factory = new TeddyFactory();
            //IToyFactory factory = new WoodenFactory();

            Cat cat = factory.CreateCat();
            Bear bear = factory.CreateBear();

            cat.Print();
            bear.Print();
        }
    }
}
