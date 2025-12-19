
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

