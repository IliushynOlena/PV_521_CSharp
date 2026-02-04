using System.Text.Json;

namespace _28_FactoryMethod
{
    class Question
    {
        //питання
        public string question { get; set; }
        //варіанти відповідей та true or false
        public Dictionary<string, bool> properties { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Quiz
    {
        List<Question> questions;

    }
    abstract class User
    {
        public abstract void Info();
    }

    class Admin : User
    {
        public override void Info()
        {
            Console.WriteLine("I am admin");
        }
    }
    class Manager : User
    {
        public override void Info()
        {
            Console.WriteLine("I am Manager");
        }
    }
    class Guest : User
    {
        public override void Info()
        {
            Console.WriteLine("I am Guest");
        }
    }

    enum UserTypes { ADMIN, GUEST, MANAGER}

    class UserFactory
    {
        public User CreateUser(UserTypes type)
        {
            switch (type)
            {
                case UserTypes.ADMIN:
                    return new Admin();
                case UserTypes.GUEST:
                    return new Guest();
                case UserTypes.MANAGER:
                    return new Manager();
                default:
                    return null;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            //UserFactory factory = new UserFactory();
            //User user = factory.CreateUser(UserTypes.ADMIN);
            //user.Info();
            //user = factory.CreateUser(UserTypes.GUEST);
            //user.Info();
            //user = factory.CreateUser(UserTypes.MANAGER);
            //user.Info();
            string fileName = "Q.json";
            //string jsonString = JsonSerializer.Serialize(persons);
            //File.WriteAllText(fileName, jsonString);
            List<Question> pr = null;
            string jsonString = File.ReadAllText(fileName);
            Console.WriteLine(jsonString);
            pr = JsonSerializer.Deserialize<List<Question>>(jsonString)!;
            foreach (Question item in pr)
            {
                Console.WriteLine(item.question);
                Console.WriteLine();
                int a = 1;
                foreach (var i in item.properties)
                {
                    Console.WriteLine(a + " " + i.Key );
                    a++;
                }
                Console.WriteLine();
            }

        }
    }
}
