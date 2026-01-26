using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace _22_DataAnnotationSerialize
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Constructor)]
    class CoderAttribute : Attribute
    {
        public string Name { get; set; } = "Olena";
        public DateTime Date { get; set; } = DateTime.Now;
        public CoderAttribute() { }

        public CoderAttribute(string name, string date)
        {
            Name = name;
            Date = DateTime.Parse(date);
        }
        public override string ToString()
        {
            return $"Corer : {Name}. Date : {Date}";
        }
    }

    [Coder]
    [Obsolete, Serializable]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        [Coder]
        public Employee() { }

        [Coder("Oleksiy","2026-1-26")]
        public void IncreaseSalary(decimal salary)
        {
            Salary += salary;
        }
    }

   // [Serializable]
    public class Passport
    {
        public int Number { get; set; }
        public Passport()
        {
            Number = 9999999;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
    //[Serializable]
    public class Person
    {
        public Passport Passport { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        int _identNumber;
        const string Planet = "Earth";
        public Person()
        {
            
        }
        public Person(int number)
        {

            _identNumber = number;
            Passport = new Passport();
        }
        public override string ToString()
        {
            return $"Name : {Name}, Age: {Age}, Identification number : {_identNumber}, Planet: {Planet}" +
                $"Passport {Passport}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Serializable
            ////XML 
            //Person person = new Person(5464654)
            //{
            //    Name = "Jack",
            //    Age = 15
            //};
            //XmlSerializer xmlFormatter = new XmlSerializer(typeof(Person));
            //using (Stream str = File.Create("test.xml"))
            //{
            //    xmlFormatter.Serialize(str, person);
            //}
            //Console.WriteLine("Sezialize OK!!!!");
            //Person pr = null;
            //using (Stream s = File.OpenRead("test.bin"))
            //{
            //    pr = (Person)xmlFormatter.Deserialize(s);
            //}
            //Console.WriteLine(pr);
            //JSON
            //XML 
            //Person person = new Person(5464654)
            //{
            //    Name = "Jack",
            //    Age = 15
            //};
            List<Person> persons = new List<Person>()
            {
              new Person(123654){ Name="Jack", Age = 15},
              new Person(123654){ Name="Tom", Age = 12},
              new Person(123654){ Name="Bill", Age = 35},
              new Person(123654){ Name="John", Age = 47}
            };
            string fileName = "Person.json";
            string jsonString = JsonSerializer.Serialize(persons);
            File.WriteAllText(fileName, jsonString);
           

            Console.WriteLine("Sezialize OK!!!!");
            List<Person> pr = null;
            jsonString = File.ReadAllText(fileName);
            pr = JsonSerializer.Deserialize<List<Person>>(jsonString)!;
            foreach (var item in pr)
            {
                Console.WriteLine(item);
            }
         
            //Person person = new Person(5464654)
            //{
            //    Name = "Jack",
            //    Age = 15
            //};
            //BinaryFormatter binaryFormatter = new BinaryFormatter();
            //using (Stream str = File.Create("test.bin"))
            //{
            //    binaryFormatter.Serialize(str, person);
            //}
            //Console.WriteLine("Sezialize OK!!!!");
            //Person pr = null;
            //using (Stream s = File.OpenRead("test.bin"))
            //{
            //    pr = (Person)binaryFormatter.Deserialize(s);
            //}
            //Console.WriteLine(pr);

            //{
            //    Employee employee = new Employee();

            //    Console.WriteLine("Attribute of class Employee");
            //    foreach (var attr in typeof(Employee).GetCustomAttributes(true)) 
            //    {
            //        Console.WriteLine(attr.ToString());
            //    }

            //    Console.WriteLine("Attribute of members of class Employee");
            //    foreach (var attr in typeof(Employee).GetMembers())
            //    {
            //        Console.WriteLine(attr.ToString());
            //        foreach (var a in attr.GetCustomAttributes(true))
            //        {
            //            Console.WriteLine(a);
            //        }
            //    }
        }
    }
}
