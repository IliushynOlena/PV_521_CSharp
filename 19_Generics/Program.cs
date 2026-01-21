namespace _19_Generics
{
    /*
     Generics :
    - collection
    - class
    - struct
    - methods
    - Interfaces
    - delegate

     
     */

    //Generic Delegates
    //template<typename Type>
    public delegate Type SummaDelegate<Type>(Type x, Type y);
    public delegate Type SubDelegate<Type>(Type x, Type y);
    public delegate bool CompareDelegate<T1,T2>(T1 x, T2 y);

    //Generic Interface
    interface IMyComparable<T>
    {
        void CompareMyObject(T obj1, T obj2);
    }
    class User : IMyComparable<User>
    {
        public void CompareMyObject(User obj1, User obj2)
        {
            throw new NotImplementedException();
        }
    }
    interface IIndexer<T>
    {
        T this[int index] { get; set; }
    }
    //Generic Class
    //template<typename Type>
    class MyArray<Type> : IMyComparable<MyArray<Type>>, IIndexer<Type>
    {
        private Type[] arr;

        public MyArray(int size = 10)
        {
            Random random = new Random();
            arr = new Type[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = default(Type)!;
            }
        }
        public void AddElement(Type el)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = el;
        }
        public override string ToString()
        {
            string res = " ";
            foreach (var item in arr)
            {
                res += item + " ";
            }
            return res;
        }
        public Type this[int index] {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public void CompareMyObject(MyArray<Type> obj1, MyArray<Type> obj2)
        {
            throw new NotImplementedException();
        }
    }
    class Abonent
    {
        public Abonent(string name, string phone)
        {
            
        }
    }
    /*
     *  where T1 : class, new ()
        struct -  type is struct
        class -  type is class
        interface -  type is interface
        new() - type has default constructor
        BaseClass -  type is BasseClass
     
     */
    class Point<T1, T2> //where T1 : class, new ()
    {
        public T1 X { get; set; }
        public T2 Y { get; set; }
        public Point()
        {
            X = default(T1)!;
            Y = default(T2)!;


            //T1 value = new T1();
        }
        public Point(T1 x, T2 y)
        {
          X = x; Y = y;
            if( typeof(T1) == typeof(int))
                Console.WriteLine("T1 is int!");
        }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }

    }
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static float Add(float a, float b)
        {
            return a + b;
        }
        static float Sub(float a, float b)
        {
            return a - b;
        }
        static bool Compare(double d1, decimal d2)
        {
            return (decimal)d1 == d2;
        }
        //Generics methods
        static void ShowObject<T>(T obj)
        {
            Console.WriteLine(obj);
        }
        static bool CompareElements<T1, T2>(T1 obj1, T2 obj2)
        {
            return obj1.GetHashCode() == obj2.GetHashCode();
        }
        static T3 Multy<T1,T2,T3>(T1 a,T2 b)
        {
            //some action  res T3
            return default(T3);
        }
        static void Main(string[] args)
        {
            List<int> list;
            Dictionary<string, string> dict;
            Stack<int> s;
            Queue<float> q;
            Multy<int, float, double>(5, 7);

            short a = 5;
            int b = 10;
            if(CompareElements<short, int>(a,b))
                Console.WriteLine("Hash code are equals");

            ShowObject(5);
            ShowObject("one");
            ShowObject(false);

            SummaDelegate<int> summa = new SummaDelegate<int>(Add);
            Console.WriteLine(summa.Invoke(15, 4)); ;
            SubDelegate<float> sub = new SubDelegate<float>(Sub);
            Console.WriteLine(sub.Invoke(100, 80)); ;

            CompareDelegate<double, decimal> compare = new CompareDelegate<double, decimal>(Compare);
            Console.WriteLine(compare.Invoke(10.5, 3.4m)); ;

            MyArray<float> my = new MyArray<float>();
            Console.WriteLine(my);
            my.AddElement(8.25f);
            my.AddElement(3.3f);
            Console.WriteLine(my);

            MyArray<bool> myBool = new MyArray<bool>();
            Console.WriteLine(myBool);
            myBool.AddElement(true);
            myBool.AddElement(true);
            Console.WriteLine(myBool);

            Point<int, double> point = new Point<int, double>(5, 4.7);
            Console.WriteLine(point);
        }
    }
}
