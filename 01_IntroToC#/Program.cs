using System;
using System.Text;

namespace _01_IntroToC_
{
    class Program
    {
        static void Task1()
        {

        }
              
        static void Literals()
        {

           
            Console.WriteLine((10).GetType());  
            Console.WriteLine((10D).GetType()); 
            Console.WriteLine((10f).GetType()); 
            Console.WriteLine((10m).GetType()); 
            Console.WriteLine((10L).GetType()); 
            Console.WriteLine((10UL).GetType());
            Console.WriteLine(0xFF);            
        }
        static void ConsoleMethods()
        {
         
            Console.Title = "Приклад використання метолів класу Console";
            
            Console.BackgroundColor = ConsoleColor.Green;
                                
            Console.ForegroundColor = ConsoleColor.Magenta;
           
            Console.WriteLine("Input Encoding: dsnbfdjskjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh");
            int length = ("Input Encoding: dsnbfdjsbsdjghdfjkghdfkjghdfjkhkjgbksdjghskghskdghkdsjgh ").Length + 1;
            Console.SetWindowSize(length, 8);
            
            Console.WriteLine("Input Encoding: " + Console.InputEncoding.ToString());
            Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            Console.ResetColor();
            Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());
           
            Console.Write("Enter a simpe message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Your message is: " + message);
            Console.Beep(300, 3000);
            //Console.Clear();
            Console.WriteLine("Your message is: " + message);
        }
        static void FormatString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            /////////////////////// Escape Sequences
            /*
                \'      – single quote, needed for character literals
                \"      – double quote, needed for string literals
                \\      – backslash
                \0      – Unicode character 0
                \a      – Alert (character 7)
                \b      – Backspace (character 8)
                \f      – Form feed (character 12)
                \n      – New line (character 10)
                \r      – Carriage return (character 13)
                \t      – Horizontal tab (character 9)
                \v      – Vertical quote (character 11)
                \uxxxx  – Unicode escape sequence for character with hex value xxxx                
            */
            Console.WriteLine("Деяке повідомлення \nІ ще " +
                "одне просте повідомлення  " +
                "в новому рядку" +
                "ще якийсь текст");
           
            Console.WriteLine("Пример табуляции: " +
             "\n1\t2\t3\n4\t5\t6");
            /*
            1. 2 3
            4. 5 6*/
            Console.WriteLine("kghfdkjgh" +
                "sdjfisdgiusgf" +
                "sdhfiusdgfuisd" +
                "dsihfsdigiusd" +
                "shdgoisdgh");
            Console.WriteLine(@"C:\Users\helen\Desktop\Work\C#\1");
            /////////////////////// @ - litteral formatting
            Console.WriteLine(@"Пример буква        льного
         hhjfhf
                C:\Users\helen\Desktop\Work\C#\1
             kdfjgoihiodfhoihb
            строкового литерала:
ehoiweiowegtowei
            1 \t 3
            \n 5 6");


          
            string name = "Bob";
            int day = 29;
            bool isValid = true;

            Console.WriteLine("Hello " + name + " Day: " + day.ToString());
            Console.WriteLine("Hello " + name + " Day: " + day); // ToString() is called automatically
            // string interpolation: $ - operator
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            Console.WriteLine($"Hello, {name,20}\tDay: {day,-20}\nValid: {isValid}{{}}");
            // $ + @
            Console.WriteLine($@"Hello, {name}\tDay: {day}\nValid: {isValid}{{}}");
        }
        static void Main(string[] args)
        {
            //Literals();
            //ConsoleMethods();
            FormatString();
            Task1();
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello, World!");
            Console.Write("Hello\n");
            Console.Write("\tHello\n");
            Console.Write("\"Hello\"\n");
            Console.Write("\\Hello\\\n");
            Console.Write("Hello");
            Console.WriteLine("Hello, World!");

            int a = 5;
            Int32 b = 10;

            double c = 3.33;
            Double d = 1.25;

            //cw + TAB == Console.WriteLine();
            //Console.WriteLine("Enter number : ");
            //string str = Console.ReadLine()!;
            //int number = int.Parse(str);
            //Console.WriteLine("Number : " + str);
            //Console.WriteLine("Number : " + number.ToString() + 10.ToString());
            
            ////Interpolation
            //Console.WriteLine($"Number : {number + 10} ");
            //object obj = new object();

            //Nullable(references)   ----    Not nullable(value)
            int g = 0;
            //int p = null;
            //Nullable<int> p = null;
            int? p = null;
            p = 2;
            string s1 = "Hello";
           
            string s3 = null;


            DateTime now = DateTime.Now;
            
            Console.WriteLine(now);
            Console.WriteLine(now.ToString());
            
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy/MM/dd"));


            //int a = 2.54; cout<<a<<endl; //2
            bool myBool = true;
            short myShort = 6;
            int myInt = myShort; //short ---> int implicit 
            float myFloat = 1.35f; // double --> float     implicit
            int myInt2 = (int) myFloat;//float --> int  explicit

            //try
            //{
            //    int number_new = int.Parse(Console.ReadLine()!);
            //    //   number_new = Convert.ToInt32(Console.ReadLine()!);
            //    Console.WriteLine($"Number = {number_new}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Random random = new Random();   
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(100)); ;
            }
            Console.WriteLine(random.Next());///0 ... maxInt
            Console.WriteLine(random.Next(50));///0 ... 49
            Console.WriteLine(random.Next(50, 100));///50 ... 99
            Console.WriteLine(random.NextDouble());///0 ... 1
            Console.ResetColor();


            if (3 > 8)
            {
                Console.WriteLine("Some text");
            }
            else
            {
                Console.WriteLine("Some text2222");
            }
            //while (true)
            //{

            //}
            //do
            //{

            //} while (true);

        }
    }
}
