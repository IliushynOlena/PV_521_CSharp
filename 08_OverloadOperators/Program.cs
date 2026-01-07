

namespace _08_OverloadOperators
{
    class _3D_Point
    {
        public int X { get; set; }//auto private int x;
        public int Y { get; set; }
        public int Z { get; set; }
        public _3D_Point(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }

        public override string ToString()
        {
            return $"X : {this.X}. Y : {this.Y}. Z : {Z}";
        }
    }
    class Point
    {
        public int X { get; set; }//auto private int x;
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X : {this.X}. Y : {this.Y}";
        }
        public void Print()
        {
            Console.WriteLine($"X : {this.X}. Y : {this.Y}");
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
            
           
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //public override bool Equals(object? obj)//object? obj == Point obj
        //{
        //    //this
        //    return this.X ==  ((Point)obj).X && this.Y == ((Point)obj).Y;
        //}



        // public static return_type operator [symbol] (parameters)
        //{
        //      code
        //}
        #region Uno Operators (++, --, -, +)
        public static Point operator -(Point p)//p = 02x165c486
        {
            Point res = new Point()
            {
                X = -p.X,
                Y = -p.Y
            };
            return res;
        }
        public static Point operator ++(Point p)// prefix
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)// prefix
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Binary operators (+ - * /)
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region Logic operators (==, != , < , > , <= , >=)
        public static bool operator ==(Point p1, Point p2)
        {
            //return p1.X == p2.X && p1.Y == p2.Y;
            return p1.Equals(p2);
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        //in pair
        public static bool operator <(Point p1, Point p2)
        {
            //return p1.X + p1.Y < p2.X + p2.Y;
            return !(p1 > p2);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        //in pair
        public static bool operator <=(Point p1, Point p2)
        {
            //return p1.X + p1.Y <= p2.X + p2.Y;
            return !(p1 >= p2);
        }
        #endregion

        #region TRUE/FALSE
        public static bool operator true(Point p)
        {
            return p.X > 0 && p.Y > 0;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X < 0 || p.Y < 0;
        }
        #endregion
        #region Оператори приведення типів даних
        //public static implicit operator int(Point p)
        //{
        //    return p.X + p.Y;
        //}
        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X * p.Y;
        }
        public static explicit operator _3D_Point(Point p)
        {
            return new _3D_Point(p.X, p.Y, 0);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  Console.ReadLine()!);
            string str = null;
            Console.WriteLine(str?.ToUpper());
            int a = 5;//int ---> int
            double b = 3.335;//double  --> double

            b = a;//5.0000000000000000  implicit розширююче
            //a = b;//3     implicit звужуюче  помилка
            a = (int)b;//3     explicit звужуюче  

            Point p1 = new Point() { X = 5, Y = 7 };
            Console.WriteLine(p1.ToString());
            //a = p1; //implicit
            a = (int)p1;//explicit
            Console.WriteLine($"Convert Point to int {a}");
            b = p1;
            Console.WriteLine($"Convert Point to double {b}");

            _3D_Point p3 = (_3D_Point) p1;
            Console.WriteLine(p3);
            /*
            Point p1 = new Point() { X = -5, Y = 7 };//this = 0x14588
            Point p2 = new Point() { X = 5, Y = 7 };//this = 0d3d58988

            //0  0.0 ""  None --> false
            //1 5 -2 -50 "hello"   -->  true
            if( p1)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("Point is false");


                string str = "Hello";//str = 0x1x4778
            string str2 = "Hello";  //str2 = 02c545

            if (str.Equals(str2))
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("not Equals");
            }
            if (p1.Equals(p2))
            {
                Console.WriteLine("Point Equals");
            }
            else
            {
                Console.WriteLine("not Point Equals");
            }
            //Overload operators
            Console.WriteLine($"Res =  {5 + 6}");
            //Console.WriteLine($"Res =  { 5 - 6}" );
            //Console.WriteLine($"Res =  { p1 + p2}" );
            //Console.WriteLine($"Res =  { p1 - p2}" );
            Point result = -p1;
            Console.WriteLine("Original point : " + p1);
            Console.WriteLine("Operator -  : " + result);
            Console.WriteLine("Original point : " + p1);

            Console.WriteLine($"Operator++ : {p1++} ");
            Console.WriteLine($"Operator++ : {++p1} ");

            Console.WriteLine($"Operator++ : {p1--} ");
            Console.WriteLine($"Operator++ : {--p1} ");
            Console.WriteLine("--------------- Binary operators --------");
            Console.WriteLine("Original point 1 : " + p1);
            Console.WriteLine("Original point 2 : " + p2);
            result = p1 + p2;
            Console.WriteLine("Operator +  : " + result);

            result = p1 - p2;
            Console.WriteLine("Operator -  : " + result);

            result = p1 * p2;
            Console.WriteLine("Operator *  : " + result);

            result = p1 / p2;
            Console.WriteLine("Operator /  : " + result);
            */
        }
    }
}
