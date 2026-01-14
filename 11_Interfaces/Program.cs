namespace _11_Interfaces
{
    //interface IWorkable
    //{
    //    //public
    //    //private int a; //error
    //    // virtual and override don*t access
    //    bool IsWorking { get; }
    //    void Print();
    //    event EventHandler WorkEnded;
    //}

    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public override string ToString()
        {
            return $"Fullname : {FirstName} {LastName}." +
                $" Birthdate : {Birthdate.ToShortDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nPosition : {Position}. Salary : {Salary}";
        }
    }
    interface IWorkable
    {
        bool IsWorking { get; }
        string DoWork();
    }
    interface IManager
    {
        //public
        List<IWorkable> ListOfWorkers { get; set; }//null
        void Organize();
        void CountMoney();
        void Control();
    }
    class Director : Employee, IManager //: Employee - наслідування ,
                                        //IManager - implementation/realize
    {
        public List<IWorkable> ListOfWorkers { get; set; }

      
        public void Control()
        {
            Console.WriteLine("I control work");
        }

        public void CountMoney()
        {
            Console.WriteLine("I count money");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string DoWork()
        {
            return "Selling product";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string DoWork()
        {
            return "Getting pay for product";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("I am a boss. I control work");
        }
        public void CountMoney()
        {
            Console.WriteLine("I am a boss. I count money");
        }
        public string DoWork()
        {
            return "I do my work(((((((";
        }
        public void Organize()
        {
            Console.WriteLine("I am a boss. I organize work");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Director director1 = new Director();
           
            int[] arr = new int[5];
           
            //Director director = new Director()
            IManager director = new Director()
            {
                FirstName = "Bob",
                LastName = "Tomson",
                Birthdate = new DateTime(1985, 5, 12),
                Position = "Director",
                Salary = 27000
            };

            director.Organize();
            director.CountMoney();
            director.Control();
            director.ListOfWorkers = new List<IWorkable>()
            {
                new Seller()
                {
                    FirstName = "Olga",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2001, 12, 1),
                    Position = "Seller",
                    Salary = 8500
                },
                 new Seller()
                {
                    FirstName = "Maria",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2004, 12, 1),
                    Position = "Seller",
                    Salary = 9200
                },
                  new Cashier()
                {
                    FirstName = "Mukola",
                    LastName = "Ilchuk",
                    Birthdate = new DateTime(1999, 12, 1),
                    Position = "Cashier",
                    Salary = 12000
                },

            };
            //Seller sell = new Seller()
            IWorkable sell = new Seller()
            {
                FirstName = "Maria",
                LastName = "Tomson",
                Birthdate = new DateTime(2004, 12, 1),
                Position = "Seller",
                Salary = 9200
            };
            Console.WriteLine(sell.DoWork()); ;  
          
            if(sell is Seller)
                Console.WriteLine($"Seller salary : { (sell as Seller)!.Salary}");

            Console.WriteLine("--------------Workers ---------------");
            foreach (IWorkable w in director.ListOfWorkers)
            {
                Console.WriteLine(w.DoWork()); 
            }
            //Multiple Interfaces
            Administrator admin = new Administrator();

            IWorkable worker = admin;
            worker.DoWork();
            Console.WriteLine(worker.IsWorking);


            IManager manager = admin;
            manager.Organize();
            manager.Control();
        }
    }
}
