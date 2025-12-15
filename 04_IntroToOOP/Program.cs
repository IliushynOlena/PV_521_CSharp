namespace _04_IntroToOOP
{
    /*
      Access to the field :
    public
    private (default for all fild)
    protected
    internal
    protected internal
     
     
     */
    partial class Point :Object
    {

        //private int number = 1;//private
        //private string name;
        //private const float pi = 3.14f;
        //private readonly int id;
        //public Point()
        //{
        //    id = 10;
        //}
        //void setId(int id)
        //{
        //    this.id = id;//error
        //}
        private int x;        
        //Properties
        public int X//value == newX
        {
            get { return x; }
            set
            {
                if (value >= 0)
                    this.x = value;
                else
                    this.x = 0;
            }
        }
        private int y;
        public int Y//value == newX
        {
            get { return y; }
            set
            {
                if (value >= 0)
                    this.y = value;
                else
                    this.y = 0;
            }
        }
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto-property   prop+TAB
        public string Name { get; set; }
        public string Color { get; }//readonly

        // full property  fullprop + TAB
        private int salary;

        public int Salary
        {
            get { return salary; }
            set 
            {
                if (value > 0)
                {
                    salary = value;                    
                }
                else
                {
                    salary = 0; 
                }
            }
        }
        //public string Address { get; set; } //auto prop
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        static int count;
        static Point()
        {
            count = 0;
        }


        public Point(): this(0, 0) 
        {
            Console.WriteLine("Default constructor");
        }
        public Point(int size) : this(size, size) { }
        public Point(int x, int y)
        {
            Console.WriteLine("Parametrized constructor");
            X = x;//set //setX(x);
            Y = y;//setY(y);
            Color = "White";
            count++;    
        }
      

       

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10,25);  //Heap references type
            point.Print();
            Console.WriteLine(point.ToString());
            point.setX(100);
            point.setY(222);
            Console.WriteLine(point.getX());
            Console.WriteLine(point);


            point.X = 45;//value = 45
            Console.WriteLine(point.X);//get
            point.Name = "2DPoint";
            Console.WriteLine(point.Name);

            //point.Color = "Red"; //error
            Console.WriteLine(point.Color);

            Point p1 = new Point(55);
            Console.WriteLine(p1);
            p1.NewPrint();

            Point[] points = new Point[5];
            points[0] = new Point(10,25);   
            points[1] = new Point(10,25);   
            points[2] = new Point(10,25);   
            points[3] = new Point(10,25);   
            points[4] = new Point(10,25);   
            foreach (Point p in points)
                Console.WriteLine(p.ToString());
        }
    }
}
