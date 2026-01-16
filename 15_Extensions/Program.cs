using System.Runtime.CompilerServices;

namespace _15_Extensions
{

    static class ExampleExtension
    {
        public static int NumberWords(this string data)
        {
            if( string.IsNullOrEmpty(data) ) return 0;
            return data.Split(new char[] {' ', '.', ',','!','?' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int NumberSymbol(this string data, char s)
        {
            if (string.IsNullOrEmpty(data)) return 0;

            int c = 0;
            foreach (char letter in data)
            {
                if(letter == s)
                    c++;
            }
            return c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string str = "Some.  string with very long text";
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Count());
            Console.WriteLine(str.NumberWords());
            Console.WriteLine(str.NumberSymbol('o'));
            Console.WriteLine(str.NumberSymbol('t'));
            Console.WriteLine(str.NumberSymbol('y'));

          
        }
    }
}
