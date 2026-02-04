namespace _27_Singleton
{
    class Singleton
    {
        private static Singleton instance;//null
        private string name;
        private Singleton() { }
       
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works, both references is same");
            }
            else
            {
                Console.WriteLine("Singleton works, both not references is same");
            }

            if (singleton.Equals(singleton2))
            {
                Console.WriteLine("Singleton works, both references is same");
            }
            else
            {
                Console.WriteLine("Singleton works, both not references is same");
            }
        }
    }
}
