using System.Globalization;
using System.Text;

namespace _03_01_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    string fname;//null
        //    string lname = "Ivanchuk";//0d5d887
        //    fname = "Oleg";
        //    string str = new string("some name");
        //    string str1 = null;
        //    int age = 22;

        //    string fullname = fname + " " + lname;//concatenation
        //    Console.WriteLine($"Fullname : {fullname, -20}. Age : {age,-15}");


        //    char[] letters = ['H', 'e', 'l', 'l','o','!'];
        //    string greeting = new string(letters, 0,2);
        //    Console.WriteLine($"Greeting : {greeting}");


        //    string[]words = { "Hello", "green", "white", "Tree" };
        //    string res = string.Join(" - ", words);
        //    Console.WriteLine($"Res : {res}");

        //    string [] splitArr = res.Split(" - ");
        //    foreach (string s in splitArr)
        //    {
        //        Console.WriteLine(s);
        //    }

        //    string htmlMessage = "HTML is a standardized document markup language for viewing " +
        //"web pages in a browser. Browsers receive an HTML document from the " +
        //"server using HTTP/HTTPS protocols or open it from a local disk, " +
        //"then interpret the code into the interface that will be displayed " +
        //"on the monitor screen. ";
        //    Console.WriteLine();
        //  string []words2 =   htmlMessage.Split(new char[] { ' ', ',', '.', '!', '?', '\n' }
        //  ,StringSplitOptions.RemoveEmptyEntries);
        //    foreach (var word in words2)
        //    {
        //        Console.WriteLine(word);
        //    }


        //    DateTime dateNow = DateTime.Now;
        //    Console.WriteLine(dateNow);
        //    Console.WriteLine(dateNow.ToString());
        //    Console.WriteLine(dateNow.ToLongDateString());
        //    Console.WriteLine(dateNow.ToShortDateString());
        //    Console.WriteLine(dateNow.ToLongTimeString());
        //    Console.WriteLine(dateNow.ToShortTimeString());
        //    Console.WriteLine(dateNow.ToString("yyyy-MM-dd"));

        //    DateTime vacations = new DateTime(2025, 12, 19);

        //    TimeSpan timeSpan = vacations - dateNow;
        //    Console.WriteLine($"Time span : {timeSpan}");
        //    Console.WriteLine($"Time span : {timeSpan.ToString()}");
        //    Console.WriteLine($"Miliseconds: {timeSpan.Milliseconds}");
        //    Console.WriteLine($"Seconds: {timeSpan.Seconds}");
        //    Console.WriteLine($"Minutes: {timeSpan.Minutes}");
        //    Console.WriteLine($"Hours: {timeSpan.Hours}");
        //    Console.WriteLine($"Days: {timeSpan.Days}");

        //    Console.WriteLine($"TotalMilliseconds: {timeSpan.TotalMilliseconds}");
        //    Console.WriteLine($"TotalSeconds: {timeSpan.TotalSeconds}");
        //    Console.WriteLine($"TotalMinutes: {timeSpan.TotalMinutes}");
        //    Console.WriteLine($"TotalHours: {timeSpan.TotalHours}");
        //    Console.WriteLine($"TotalDays: {timeSpan.TotalDays}");

        //    Console.OutputEncoding = Encoding.UTF8;
        //    //CultureInfo us = new CultureInfo("PL-pl");
        //    //CultureInfo us = new CultureInfo("uk-UA");
        //    //CultureInfo us = new CultureInfo("en-US");
        //    //CultureInfo us = new CultureInfo("fr-FR");
        //    //CultureInfo us = new CultureInfo("it-IT");
        //    //CultureInfo us = new CultureInfo("cs-CZ");
        //    CultureInfo us = new CultureInfo("ja-JP");

        //    decimal money = 42.10m;
        //    string course = $"Today course of dollar is : {money.ToString("C2",us)}";
        //    Console.WriteLine(course);

        //    string nullStr = null;

        //    if (nullStr == null)
        //        Console.WriteLine("References is empty");
        //    else
        //        Console.WriteLine(nullStr.Length);
        //    //null-conditional operator
        //    nullStr?.ToUpper();
        //    //next line

        //    string strEmpty = "";
        //    Console.WriteLine(strEmpty.Length);
        //    if (string.IsNullOrEmpty(strEmpty) && string.IsNullOrEmpty(nullStr))
        //        Console.WriteLine("Is null or empty");

        //    string str5 = "              ";
        //    Console.WriteLine(str5.Length);
        //    if (string.IsNullOrWhiteSpace(str5))
        //    {
        //        Console.WriteLine("Is null or white Spaces...");
        //    }

            // Comparing 2 strings 
            string str1 = "This is test";
            string str2 = "This is text";

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }

            //String Contains String:
            string str3 = "This is testing";
            if (str3.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            //Getting a Substring:
            string str4 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str4);
            string substr = str4.Substring(23, 9);
            Console.WriteLine(substr);


            //String interpolations

            //C / c
            //Задаємо грошові одиниці , вказуючи кількість цифр після коми
            //
            //D / d
            //Цілочисельний формат, де ми вказуємо максимальну кількість цифр (5)
            //
            //  00015
            //  00155
            //  01478
            //  00587
            //
            //E / e
            //Кількість цифр після коми
            //
            //F / f
            //Кількість цифр після коми
            //
            //G / g
            //Вибирає більш короткий варіант : F або E
            //
            //
            //P / p
            //Задает відображення знаку відсотків поряд з числом
            //
            //X / x
            //Шестнадцятковий формат числа

            int number = 23;
            Console.WriteLine(number);
            Console.WriteLine("Number : " + number.ToString());
            Console.WriteLine("Number : {0:d4}. {1:d5}. {2:d3}. {3}",number,5,55,555);
            Console.WriteLine("Number {0:d2}", number);
            string result = String.Format("Number: {0:d5}", number);
            Console.WriteLine(result); // 23
            //string result2 = String.Format("{0:d4}", number);
            //interpolation
            string result2 = $"Number : {number:d4}";
            // string result2 = $"Number : {number, 15}";
            Console.WriteLine(result2); // 0023
            //Console.ReadKey(); // pause

            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00

            double number2 = 45.086546546545;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:F4}";
            Console.WriteLine(result3); // 45,0800

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10

            //was
            //auto a = 5; //auto = int
            //auto a = "hello"; //auto = string
            //auto == var
            var anInt = 1;//var - int
            var aBool = true;//var = bool
            var aString = "3";//var = string
            //var c; //error
            var formated = string.Format("{0},{1},{2}", anInt, aBool, aString);
            Console.WriteLine(formated);
            //Console.ReadKey();
            //become
            var anInt1 = 1;
            var aBool1 = true;
            var aString1 = "3";
            var formated1 = $"{anInt1:f4},{aBool1},{aString1}";
            Console.WriteLine(formated1);
            //Console.ReadKey();

            var someDir = "a";
            Console.WriteLine($@"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");
            Console.WriteLine(someDir);

            Console.WriteLine($"Name: {"Ivan",-10} Age: {23,10}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",-10} Age: {34,10}"); // spaces after

            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = System.String.Concat(s3, "!!!"); // = string "hello world!!!"
            Console.WriteLine(s4);

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s11.IndexOf(subString); // = 6
            Console.WriteLine(indexOfSubstring);
            Console.ReadKey();
            //   helen@gmail.com   
            string s12 = " ? Me tengo?!, To be honest!!!   ";
            //s12 = s12.Trim();

            s12 = s12.Trim(new char[] { '?', ' ', '!' });
           
            Console.WriteLine($"After trimming: /{s12}/");

            Console.ReadKey();
            //Hello world
            //s12.Insert()
            foreach (char item in s12)
            {
                //Char.IsUpper();
            };
             //s12[numberword][0]

        }
    }
}
