using System.Collections;
using System.Runtime.Serialization;

namespace _06_Exeptions
{
    class MyClass
    {
        public void BadMethod()
        {
            Exception exception = new Exception("My exeption message");
            exception.HelpLink = "https://google.com";
            exception.Data.Add("Exeption reason : ", "Test system");
            exception.Data.Add("Time invokation : ", DateTime.Now);
            exception.Data.Add("User name : ", "Olena");
            throw exception;
        }
    }
    class MyExeption : Exception
    {
        public DateTime Time { get; set; } = DateTime.Now;  
        public MyExeption()
        {
            //Time = DateTime.Now;    
        }

        public MyExeption(string? message) : base(message)
        {
            //Time = DateTime.Now;
        }

        public MyExeption(string? message, Exception? innerException) : base(message, innerException)
        {
            //Time = DateTime.Now;
        }

        protected MyExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    class ConsoleReader
    {
        public static int GetInt32FromConsole()
        {
            try
            {
                return int.Parse(Console.ReadLine()!);
            }
            catch (FormatException ex)
            {

                throw new MyExeption("Argument was a not correct format ",ex) ;
            }
            catch(Exception ex)
            { throw ex; }
        }
    }
    internal class Program
    {
       static double SafeDivision(double a, double b)
        {
            if( b == 0)
            {
                throw new DivideByZeroException("Second operand = 0");
            }
            return a / b;   
        }
        static void Main(string[] args)
        {
            #region Example 1
            /*
           
            int num1 = 0, num2 = 0, res = 0 ;

            try
            {
                Console.WriteLine("Enter first number : ");
                num1 = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter second number : ");
                num2 = int.Parse(Console.ReadLine()!);

                SafeDivision(num1, num2);
                //res = num1 / num2;
                //Console.WriteLine($"Res : {num1}/{num2} = {res}");
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("You can't divide by zero. Study Math.");            
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {

                //Console.WriteLine("You can't divide by zero. Study Math.");
                Console.WriteLine("You need enter digit value");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("You need enter some digit value");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Soo large number .");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continue......");
            Console.WriteLine("Continue......");
            Console.WriteLine("Continue......");
            Console.WriteLine("Continue......");
            Console.WriteLine("Continue......");
            */
            #endregion
            #region Example 2
            /*
            try
            {
                MyClass @class = new MyClass();
                @class.BadMethod(); 

            }
            catch (Exception ex)
            {
                Console.WriteLine("Member name : {0} ", ex.TargetSite);
                Console.WriteLine("Member class : {0}", ex.TargetSite?.DeclaringType);
                Console.WriteLine("Member type : {0}", ex.TargetSite?.MemberType);
                Console.WriteLine("Method name : {0}", ex.TargetSite?.Name);
                Console.WriteLine("Message : {0}", ex.Message);
                Console.WriteLine("Source : {0}", ex.Source);
                Console.WriteLine("HelpLInk : {0}", ex.HelpLink);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);

                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key} . {item.Value}");
                }
            }
            */
            #endregion
            #region Example 3
            int number = 0;
            try
            {
                number = ConsoleReader.GetInt32FromConsole();
                Console.WriteLine(new string('*', number));
            }
            catch (MyExeption ex)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("My exeption catch");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Time);
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    FileStream fs = new FileStream(@"C:\Test\LogFile.txt", FileMode.OpenOrCreate);
                    //open....
                    //save information .... ex

                    //close()..... very bad
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.ResetColor();
                    //work always
                    //close files
                    //close connection to database
                    //close network connection

                }
            }
            finally
            {
                //work always
            }


           
            #endregion

        }
    }
}
