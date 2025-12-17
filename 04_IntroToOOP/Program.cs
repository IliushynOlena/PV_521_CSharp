namespace _04_IntroToOOP
{

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
            {
                //p = new Point(p.X,p.Y);
                Console.WriteLine(p.ToString());
            }
               

            for (int i = 0; i < points.Length; i++)
            {
                points[i].Print();
            }
        }
    }
}
