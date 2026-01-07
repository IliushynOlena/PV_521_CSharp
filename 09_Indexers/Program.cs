namespace _09_Indexers
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model}. Price : {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;//null 
        public Shop(int size)//10
        {
            laptops = new Laptop[size];
        }
        public int Lenght
        {
            get { return laptops.Length; }
        }
        public void SetLaptop(Laptop laptop, int index)//HP 25000  100
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Laptop GetLaptop(int index)//0...10   5
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index] ;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Laptop this[int index]//laptop == value
        {
            get 
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set 
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public Laptop this[string model]//Laptop = value
        {
            get 
            {
                foreach (var l in laptops)//readonly
                {
                    if (l.Model == model)
                        return l;
                }
                return null;
            }
            //private set 
            //{
            //    for (int i = 0; i < laptops.Length; i++)
            //    {
            //        if (laptops[i].Model == model)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }
            //}
        }
        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                {
                    return i;
                }
            }
            return  -1;
        }
        public Laptop this[double price]
        {
            get 
            {
                int index = FindByPrice(price);
                if(index != -1)
                {
                    return laptops[index];
                }
                throw new Exception("Incorrect price");
            }
            private set {
                int index = FindByPrice(price);
                if (index != -1)
                {
                    this[index] = value;
                }
            }
        }


    }
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //MultArray multArray = new MultArray(2, 3);

            //for (int i = 0; i < multArray.Rows; i++)
            //{
            //    for (int j = 0; j < multArray.Cols; j++)
            //    {
                   
            //        multArray[i, j] = i + j;//indexator - set
            //        Console.Write($"{multArray[i, j]} ");//indexator - get
            //    }
            //    Console.WriteLine();
            //}

            Shop shop = new Shop(3);
            shop.SetLaptop(new Laptop() { Model = "HP", Price = 25999.0 }, 0);
            Console.WriteLine(shop.GetLaptop(0));

            shop[1] = new Laptop() { Model = "Asus", Price = 15458.0 };//set
            shop[2] = new Laptop() { Model = "DELL", Price = 15458.0 };//set
            Console.WriteLine(shop[1]);//get

            //shop["HP"] = new Laptop() { Model = "MAC", Price = 100000 };//set
            Console.WriteLine(shop["HP"]);

            Console.WriteLine(shop[25999.90]);
            try
            {
                for (int i = 0; i < shop.Lenght + 1; i++)
                {
                    Console.WriteLine(shop[i]);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Continue....");
        }
    }
}
