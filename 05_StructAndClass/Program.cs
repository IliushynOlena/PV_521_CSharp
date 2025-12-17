namespace _05_StructAndClass
{
    //struct Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    //default constructor is in class
    //    public override string ToString()
    //    {
    //        return $"X : {X}. Y : {Y}";
    //    }
    //}
    class Point//private
    {
        public int X { get; set; }
        public int Y { get; set; }
        //default constructor is in class
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}";
        }
    }
    struct Square//public
    {
        public int Height { get; set; }
        public int Width { get; set; }
        //default constructor is in class - don't write

        //Properties - full
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 16 && value <= 65)
                    age = value;
                else
                    throw new Exception("Age error");
            }
        }



    }

    internal class Program
    {
        //params  - set many parameters
        static void MethodWithParams(string name,params int[] marks)
        {
            Console.WriteLine("----------------" + name + "------------------");
            foreach (var m in marks)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine();
        }
        //ref - references (link)
        static void Modify(ref int num,ref string str,ref Point p)
        {
            num += 1;
            str += "!!!";
            p.X += 5;
            p.Y += 5;

        }
        //out - return many params 
        static void GetCurentTime(out int hour, out int minute, out int second)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
          
        }
       
        static void Main(string[] args)
        {
            int a;
            //Struct vs Class
            Point point = new Point() { X = 2, Y = 2}; //new - create dynamic memory

            Square square = new Square() {  Height = 10, Width = 10};//new  - invoke default constructor
            //numbers : 0
            //references : null
            //bool : false

            //Point p;
            //Square sq;
            //p = new Point();

            try
            {
                 square.Age = int.Parse(Console.ReadLine()!);
                //Date = DateTime.Parse(Console.ReadLine()!); 2002-12-3

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            //out
            int h, m, s ;
            //Console.WriteLine($"{h}:{m}:{s}");
            GetCurentTime(out h, out m, out s);
            Console.WriteLine($"{h}:{m}:{s}");

            //ref
            int num = 10;
            string str = "Hello academy";
            Point p = new Point() { X = 4, Y = 2 };
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Str = {str}");
            Console.WriteLine($"Point = {p}");
            Modify(ref num, ref str,ref p);
            Console.WriteLine($"Num = {num}");
            Console.WriteLine($"Str = {str}");
            Console.WriteLine($"Point = {p}");


            //params
            //int[] marks = [11, 12, 10, 12, 12, 11, 9];
            //MethodWithParams("Bob", marks);

            //MethodWithParams("Tom", new int[] { 4, 7, 8, 5, 6, 3, 4, 2, 3 });

            //MethodWithParams("Olga", 11,5,7,8,9,10,11,12,10,11,11,1,1,11,1);
            //MethodWithParams("Vita", 11,5,7,8);
            //MethodWithParams("Irina", 11,11,11,1,1,11,1);
            //MethodWithParams("Vasul",11,4,3,6,4,2);


            //Structs
            //Point p = new Point() { X = 10, Y = 5 };
            ////p.X = 10;
            ////p.Y = 5;
            //Console.WriteLine(p);
            //_3DPoint.Point p1 = new _3DPoint.Point() { X = 1, Y = 2, Z = 3 };
            //Console.WriteLine(p1);
        }
    }

}

namespace _3DPoint
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $"X : {X}. Y : {Y}. Z : {Z}";
        }
    }
}
