namespace _13_Delegates
{
    //public class NameDelegate : MulticastDelegate
    //{
    //public int Method(int a, double v)
    //{

    //}

    //}
    public delegate void NameDelegate();
    public delegate int SomeDelegate(int a, double b);

    public delegate void SetStringDelegate(string str);
    //double GetKoef()
    public delegate double GetDoubleDelegate();
    //void DoWork()
    public delegate void VoidDelegate();    
    public class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine($"String : {str}");
        }
        public static double GetKoef()
        {
            Random rnd = new Random();
            double res = rnd.NextDouble();
            return res;
            //return new Random().NextDouble();
        }
        public double GetNumber()
        {           
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("Doing some work.....");
        }
        public void Test()
        {
            Console.WriteLine("Testing....");
        }

    }

    //class MyClass
    //{
    //    public string Name { get; set; }
    //    public MyClass(string name)
    //    {
    //        this.Name = name;
    //    }

    //}
    //class GetDoubleDelegate
    //{
    //    public void* Method (){ get; set; }
    //    public GetDoubleDelegate(void* Method)
    //    {
    //        this.Name = name;
    //    }

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass("Olga");  
            
            GetDoubleDelegate getDouble =  new GetDoubleDelegate(SuperClass.GetKoef);

            if (getDouble != null)//== ?
            {
                Console.WriteLine(getDouble());
            }
            Console.WriteLine(getDouble?.Invoke());
            Console.WriteLine("-------------------");

            SuperClass superClass = new SuperClass();
            GetDoubleDelegate[] delArr = new GetDoubleDelegate[]
            {
                SuperClass.GetKoef,
                superClass.GetNumber
            };

            Console.WriteLine(delArr[0]());
            Console.WriteLine(delArr[1]?.Invoke());;


            SetStringDelegate setString = new SetStringDelegate(superClass.Print);
            setString.Invoke("Hello academy");

            //VoidDelegate voidDelegate = new VoidDelegate(superClass.DoWork);
            VoidDelegate voidDelegate = superClass.DoWork;
            voidDelegate += superClass.Test;
            voidDelegate += superClass.DoWork;
            voidDelegate += superClass.Test;

            foreach (var item in voidDelegate.GetInvocationList())
            {
                (item as VoidDelegate)?.Invoke();
            }

        }
    }
}
