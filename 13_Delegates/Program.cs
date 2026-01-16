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
    public delegate double CalcDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y != 0)
                return x / y;
            throw new DivideByZeroException();
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
    public delegate int ChangeDelegate(int value);
    class Program
    {
        public static void DoOperation(double a, double b, CalcDelegate c)
        {
            Console.WriteLine(c.Invoke(a,b));
        }
        static void ChangeEachElements(int[]array, ChangeDelegate action )
        {
            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = action(array[i]);
                array[i] = action.Invoke(array[i]);
            }
        }
        static int Sqrt(int v)
        {
            return v * v;
        }
        static int Increment(int v)
        {
            return ++v;
        }
        static int Decrement(int v)
        {
            return --v;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 10 };
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine(); 
            
            ChangeEachElements(arr, Sqrt);
            foreach (var item in arr) Console.Write(item+ " "); Console.WriteLine();

            ChangeEachElements(arr, Increment);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeEachElements(arr, Decrement);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            //анонімний делегат
            ChangeEachElements(arr, delegate(int value) { return --value; });
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            //lambda function
            //ChangeEachElements(arr,  (value) => { return --value; });
            ChangeEachElements(arr,  (value) =>  --value);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeEachElements(arr, (value) => value+5);
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();

            ChangeEachElements(arr, (value) => {

                //some code
                return value;
            
            });
            foreach (var item in arr) Console.Write(item + " "); Console.WriteLine();
            /*
            Calculator calculator = new Calculator();
            DoOperation(5, 2, calculator.Add);
            DoOperation(5, 2, calculator.Sub);
            DoOperation(5, 2, calculator.Multy);
            DoOperation(5, 2, calculator.Div);
            CalcDelegate calcDelegate = calculator.Add;
            calcDelegate += calculator.Sub;
            calcDelegate += calculator.Sub;
            calcDelegate += calculator.Multy;
            calcDelegate += calculator.Div;
            calcDelegate -= calculator.Div;

            foreach(Delegate  i in calcDelegate.GetInvocationList())
            {
                Console.WriteLine($"Res = { (i as CalcDelegate)?.Invoke(100,25)}");
            }
            */
            /*
            Calculator calculator = new Calculator();
            double x, y;
            int key;
            do
            {
                CalcDelegate calcDelegate = null;
                Console.WriteLine("Enter first number ");
                x = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter second number ");
                y = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Add  - 1 ");
                Console.WriteLine("Sub  - 2 ");
                Console.WriteLine("Mult  - 3 ");
                Console.WriteLine("Divide  - 4 ");
                Console.WriteLine("Exit  - 0 ");
                key = int.Parse(Console.ReadLine()!);
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalcDelegate(calculator.Add);
                        //calculator.Add(x, y);
                        break;
                    case 2:
                        calcDelegate = new CalcDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multy;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good  Buy");
                        break;
                    default:
                        Console.WriteLine("Error choice......");
                        break;
                }
                Console.WriteLine($"Res =  {calcDelegate?.Invoke(x,y)}");

            } while (key != 0);
            */
            /*
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
            */
        }
    }
}
