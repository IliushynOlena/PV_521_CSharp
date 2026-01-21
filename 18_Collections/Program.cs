using System.Collections;

namespace _18_Collections
{
    class MyClass
    {
        public MyClass(int numbers)
        {
            
        }
        public static implicit operator int(MyClass cl)
        {
            return 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {1,2,3,4,5};

            ArrayList arr1 = new ArrayList();
            Console.WriteLine(arr1.Capacity);
            Console.WriteLine(arr1.Count);

            ArrayList arr2 = new ArrayList(5);
            Console.WriteLine(arr2.Capacity);
            Console.WriteLine(arr2.Count);

            ArrayList arr3 = new ArrayList(new int[] { 1, 2, 3, 4, 6 });
            Console.WriteLine(arr3.Capacity);
            Console.WriteLine(arr3.Count);

            arr3.Add(100);
            arr3.Add("one");
            arr3.Add("two");
            arr3.Add(false);
            arr3.AddRange(new char[] { 'a', 'b', 'c','d' });

            Console.WriteLine(arr3.Capacity);
            Console.WriteLine(arr3.Count);

            foreach (object item in arr3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            arr3.Insert(2, "Hello world");

            arr3.RemoveAt(0);
          
            foreach (object item in arr3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //arr3.Sort();
            foreach (object item in arr3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("----------------------");
            stack.Push("blue");
            stack.Push("green");
            stack.Push("yellow");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Contains("one"));
            Console.WriteLine(stack.Contains("green"));

            //boxing -- unboxing
            // 4 --> int --> value   --> Stack
            //value ---> references - boxing
            //references ---> value   --> unboxing

            object obj = new object();// references --- > references
            int number = 5;//value --> value

            //boxing
            obj = (object) number;

            //unboxing
            number = (int) obj;

            //boxing
            MyClass myClass = new MyClass(15);

            //unboxing
            int res =(int) myClass;


        }
    }
}
