using System.Text;

namespace _03_02_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            str += "some text";
            str += "some text";
            str += "some text";
            str += "some text";
            str += "some text";
            str += "some text";
            str += "some text";

            StringBuilder builder = new StringBuilder();
            Console.WriteLine($"Lenght : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.Append("some text");
            builder.Append("some text");
            Console.WriteLine($"Lenght : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");

            builder.AppendLine();
            builder.Append("some text");
            builder.Append("some text");
            builder.Append("some text");
            builder.Append("some text");
            Console.WriteLine($"Lenght : {builder.Length}");
            Console.WriteLine($"Capacity : {builder.Capacity}");
            Console.WriteLine(builder.ToString());

        }
    }
}
