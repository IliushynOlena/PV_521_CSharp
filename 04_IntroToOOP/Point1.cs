namespace _04_IntroToOOP
{
    partial class Point
    {
        public void Print()
        {
            Console.WriteLine($"X : {x}. Y : {y}. Color : {Color}");
        }
        public override string ToString()
        {
            return $"X : {x}. Y : {y} . Color : {Color}";
        }
    }
}

namespace _04_IntroToOOP
{
    partial class Point
    {
        public void NewPrint()
        {
            Console.WriteLine($"NEW Print : X : {x}. Y : {y}. Color : {Color}");
        }
    }
}