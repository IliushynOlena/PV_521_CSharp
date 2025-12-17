namespace _04_IntroToOOP
{
    partial class Point
    {
        //Old code
        //set
        public void setX(int newX)
        {
            if (newX >= 0)
                this.x = newX;
            else
                this.x = 0;
        }
        public void setY(int newY)
        {
            if (newY >= 0)
                this.y = newY;
            else
                this.y = 0;
        }
        //get
        public int getX() { return x; }
        public int getY() { return y; }
    }
}
