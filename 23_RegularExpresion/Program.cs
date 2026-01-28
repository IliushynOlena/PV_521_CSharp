using System.Text.RegularExpressions;
using System.Transactions;

namespace _23_RegularExpresion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Regex
            /*
             СПЕЦ. СИМВОЛИ
             \d - Визначає символи цифр. 
             \D - Визначає любий символ, який не є цифрою. 
             \w - Визначає любий символ цифри, букви або нижнє підкреслення. 
             \W - Визначає любий символ, який не є цифрою, буквою або нижнім підкресленням.. 
             \s - Визначає любий недрукований символ, включаючи пробіл. (таб і перехід на новий рядок)
             \S - Визначає любий символ, крім символів табуляции, нового рядка и повернення каретки.
             .  - Визначає любий символ крім символа нового рядка.  
             \. - Визначає символ крапки.
           */
            /*
            КВАНТИФИКАТОРЫ
            ^ - з початку рядка. 
            $ - з кінця рядка. 
            * - нуль і більше входжень підшаблону в сторці.  
            + - одне і більше  входжень підшаблону в сторці.  
            ? - нуль чи одне  входження підшаблону в сторці.    
         */



            //string pattern = @"\d";
            //string pattern2 = @"\d+";
            //Regex regex = new Regex(pattern);
            //bool flag = true;

            //example 1
            //while (flag)
            //{
            //    string str = Console.ReadKey().KeyChar.ToString();
            //    if (str == " ")
            //    {
            //        flag = false; break;
            //    }
            //    bool saccess = regex.IsMatch(str);
            //    Console.WriteLine(saccess? $"match found {pattern}" : $"match not found {pattern}");
            //}

            //Example 2
            //regex = new Regex(pattern2);
            //var array = new string[] { "test", "123", "test123test", "123test", "test123" };
            //foreach (string str in array)
            //{
            //    Console.WriteLine(regex.IsMatch(str)? $"Match is found : {str}":
            //        $"Match is not found : {str}");
            //}

            //Example 3
            //string pattern3 = "^[A-Z][a-z]*$";
            //regex = new Regex(pattern3);

            //while (true)
            //{
            //    Console.WriteLine("Enter login : ");
            //    string input = Console.ReadLine();  

            //    if(input == "exit")break;
            //    Console.WriteLine(input != null && regex.IsMatch(input) ? 
            //        $"String is correct : {input}" : $"String is uncorrect : {input}")                    ;
            //}


            #region Example 4
            string pattern = @"";

            //pattern = @"\d+";
            //pattern = @"\D+";
            //pattern = @"^\d+";
            //pattern = @"\d+$";
            pattern = @"^\d+$";
            var regex = new Regex(pattern);
            var arr = new[] { "test", "123", "test123test", "123test", "test123" };

            foreach (string item in arr)
            {
                Console.WriteLine(regex.IsMatch(item) ? $" String \"{pattern}\" matched" :
                    $" String \"{pattern}\"  NOT mached");

            }
            #endregion
            #region Exapmle 5
            //string value = "4 - 5 AND 5 y 579";
            //Match match = Regex.Match(value, @"\d");
            string value = "113 Axx-1xxy \n Axyx-2xyyxyx ";
            Match match = Regex.Match(value, @"A.*y");

            if(match.Success)
            {
                Console.WriteLine("Value : " + match.Value);
                Console.WriteLine("Lenght : " + match.Length);
                Console.WriteLine("Index : " + match.Index);

            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine("Value : " + match.Value);
                Console.WriteLine("Lenght : " + match.Length);
                Console.WriteLine("Index : " + match.Index);
            }


            #endregion

            #region Example 6
            string message = "saidsaid  said shed shed see said spear spread super";

            MatchCollection collection =  Regex.Matches(message, @"s\w+d");
            Console.WriteLine("--------------------------------------------");
            foreach (Match item in collection)
            {
                Console.WriteLine("Value : " + item.Value);
                Console.WriteLine("Lenght : " + item.Length);
                Console.WriteLine("Index : " + item.Index);
                Console.WriteLine();
            }
            #endregion

            #region Example 7
            string mess = "Don*t replace Dot Net replaced Net Net Don Net dots";
            string output = Regex.Replace(mess, "N.t", "NET");
            Console.WriteLine(mess);
            Console.WriteLine(output);
            #endregion



        }
    }
}
