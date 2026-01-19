using System.Net.Sockets;
using System.Security.Cryptography;

namespace _16_GarbageCollector
{
    class Person
    {
        string name;
        string surname;
        int age;
    }
    class GarbageHELPER
    {
        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
            }
        }
       
    }
    class TestClass
    {
        public int MyProperty { get; set; }
        public TestClass()
        {
            Console.WriteLine("Constructor");
        }
        ~TestClass()
        {
            Console.WriteLine("Finalize!");
        }
    }
    class DisposeExample : IDisposable
    {
        Stream stream;
        public DisposeExample()
        {
            Console.WriteLine("Open stream....");
            stream = new FileStream(@"C:\Test\Csharp\doc.txt", FileMode.OpenOrCreate);
        }
        public void Dispose()
        {
            stream.Close();
            Console.WriteLine("Close connection");
            //забороняє Garbage collectory запускати фіналізатора
            GC.SuppressFinalize(this);
        }
        public void DoSomething()
        {
            throw new Exception();
        }
        ~DisposeExample()
        {
            stream.Close();
            Console.WriteLine("Close connection");
        }
    }
    class Test : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Close resourses");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NetworkStream
            TestClass testClass = new TestClass();

            if (true)
            {
                DisposeExample disposeExample = new DisposeExample();
                // throw exception....
                try
                {
                    disposeExample.DoSomething();
                }
                catch (Exception ex)
                {
                    //work with object....
                    disposeExample.Dispose();
                }
                finally
                {
                    disposeExample.Dispose();
                }

                using (Test t = new Test())
                {
                    t.SomeMethod();
                    //throw ex


                   
                }//t.Dispose( t.Close())

                using (DisposeExample d = new DisposeExample())
                {
                    d.DoSomething();

                }// d.Dispose();


                DisposeExample d = new DisposeExample();
                using (FileStream w = new FileStream())
                {
                    w.Write();

                }// w.Dispose();


                using (string s = new string("hello"))
                {
                    

                }// w.Dispose();


            }
           
            //GarbageHELPER gc = new GarbageHELPER();
            //Console.WriteLine(GC.GetGeneration(gc));
            //Console.WriteLine($"Total memory : {GC.GetTotalMemory(false)}");
            //gc.MakeGarbage();
            //Console.WriteLine($"Total memory : {GC.GetTotalMemory(false)}");
            //GC.Collect(0);
            //Console.WriteLine(GC.GetGeneration(gc));
            //Console.WriteLine($"Total memory : {GC.GetTotalMemory(false)}");
            //GC.Collect(1);
            //Console.WriteLine(GC.GetGeneration(gc));
            //Console.WriteLine($"Total memory : {GC.GetTotalMemory(false)}");



            //int a = 5;
            //string str = "1";
            //string str3;
            //if (true)
            //{
            //    string copy;

            //    if (true)
            //    {
            //        int b = 10;
            //        string str2 = "hello";
            //        copy = str2;
            //        Console.WriteLine(str2);
            //    }
            //    Console.WriteLine(copy);
            //    str3 = copy;

            //}




        }
    }
}
