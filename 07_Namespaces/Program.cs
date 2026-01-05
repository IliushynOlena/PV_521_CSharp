
using System.Globalization;

namespace A
{
    class Incrementer
    {
        private int count;
        public Incrementer(int count)
        {
            this.count = count; 
        }
        public int MyltyIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                count++;
            }
            return count;
        }
    }     
}
namespace B
{
    class Incrementer
    {
        private int var;
        public Incrementer(int var)
        {
            this.var = var;
        }
        public int MyltyIncrement()
        {
            for (int i = 0; i < 5; i++)
            {
                var+=10;
            }
            return var;
        }
    }
}
namespace _07_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A.Incrementer inkrementer = new A.Incrementer(5);
            Console.WriteLine(inkrementer.MyltyIncrement());
            B.Incrementer inkrementer2 = new B.Incrementer(5);
            Console.WriteLine(inkrementer2.MyltyIncrement());


            string text = "qwer 12 qw 43.2 wq eqw 123 422 12.23 43.2";
            string[] arr = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();

            foreach (string item in arr)
            {
                if (int.TryParse(item, out int iVal))
                {
                    intList.Add(iVal);
                }
                else if (double.TryParse(item, NumberStyles.Any, CultureInfo.InvariantCulture, out double dVal))
                {
                    doubleList.Add(dVal);
                }
                else
                {
                    stringList.Add(item);
                }
            }
            Console.WriteLine("Integers:" + string.Join(",", intList));
            Console.WriteLine("Doubles: " + string.Join(" | ", doubleList));
            Console.WriteLine("Strings:" + string.Join(",", stringList));
        }
    }
}
namespace CSharpNamespace
{
    class Foo
    {
        //some code
    }
}
namespace CSharpNamespace1
{
    class Foo
    {
        //some code
    }
}

