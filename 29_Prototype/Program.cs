namespace _29_Prototype
{
    interface IPrototype<T>
    {
        public T Clone();
    }
    class IdInfo
    {
        public int IdNumber { get; set; }
        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
    class Person : IPrototype<Person>   
    {
        public string Name { get; set; }//0x1447  --> 0x1447
        public int Age { get; set; }   //22  ---> 22(55)
        public DateTime Birthdate { get; set; }// 25.12.2004 ---> 25.12.2004
        public IdInfo IdInfo { get; set; } //0x258  --> 0x258

        public Person Clone()
        {
            Person clone =(Person) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(this.IdInfo.IdNumber);
            return clone;   
        }
        public override string ToString()
        {
            return $"{Name} . {Age}. {Birthdate.ToShortDateString()}\n" +
                $"Id Number {IdInfo.IdNumber}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { 
                 Name = "Mukola",
                 Age = 22,
                 Birthdate = new DateTime(2004,5,12),
                 IdInfo = new IdInfo(123456789)            
            };
            Console.WriteLine(person);

            Person clone = person.Clone();
            Console.WriteLine(clone);
            clone.Age = 55;
            clone.IdInfo.IdNumber = 1111111111;
            Console.WriteLine(person);
            Console.WriteLine(clone);
        }
    }
}
