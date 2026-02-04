namespace _26_Builder
{
    class Laptop
    {
        public string MonitorResolution { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }
        public string HDD { get; set; }
        public string Battery { get; set; }
        public void Print()
        {
            Console.WriteLine($"MonitorResolution : {MonitorResolution}");
            Console.WriteLine($"Processor : {Processor}");
            Console.WriteLine($"Memory : {Memory}");
            Console.WriteLine($"HDD : {HDD}");
            Console.WriteLine($"Battery : {Battery}");
        }
    }
    abstract class LaptopBuilder
    {
        public Laptop Laptop { get; set; }
        public void CreateLaptop()
        {
            Laptop = new Laptop();  
        }
        public Laptop GetLaptop()
        {
            return Laptop;
        }
        public abstract void SetMonitorResolution();
        public abstract void SetProcessor();
        public abstract void SetMemory();
        public abstract void SetHDD();
        public abstract void SetBatery();
    }
    class GamingLaptopBiulder : LaptopBuilder
    {
        public override void SetBatery(){Laptop.Battery = "6lbs"; }

        public override void SetHDD(){Laptop.HDD = "2 Tb";}

        public override void SetMemory(){
            Laptop.Memory = "32 GB";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900*1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Intel Core I7 13700K";
        }
    }
    class HomeLaptopBiulder : LaptopBuilder
    {
        public override void SetBatery() { Laptop.Battery = "6lbs"; }

        public override void SetHDD() { Laptop.HDD = "500 Gb"; }

        public override void SetMemory()
        {
            Laptop.Memory = "16 GB";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900*1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Intel Core I5 13700K";
        }
    }

    class LaptopDirector
    {
        private LaptopBuilder _laptopBuilder = null;
        public void setLaptopBuilder(LaptopBuilder laptopBuilder )
        {
            _laptopBuilder = laptopBuilder; 
        }
        public Laptop GetLaptop()
        {
            return _laptopBuilder.GetLaptop();
        }
        public void Configutare()
        {
            _laptopBuilder.CreateLaptop();
            _laptopBuilder.SetMonitorResolution();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetMemory();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetBatery();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LaptopDirector director = new LaptopDirector(); 
            GamingLaptopBiulder gamingLaptop = new GamingLaptopBiulder();   
            HomeLaptopBiulder homelaptopBiulder = new HomeLaptopBiulder();

            director.setLaptopBuilder(gamingLaptop);
           
            director.Configutare();
            Laptop laptop = director.GetLaptop();
            laptop.Print();

            director.setLaptopBuilder(homelaptopBiulder);
            director.Configutare();
            laptop = director.GetLaptop();
            laptop.Print();
        }
    }
}
