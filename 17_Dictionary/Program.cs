namespace _17_Dictionary
{
    class Person
    {
        public string  Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string>countries = new Dictionary<string, string>();

            countries.Add("UA", "Ukraine");
            countries.Add("PL", "Poland");
            countries.Add("FR", "France");
            countries.Add("CH", "China");
            countries.Add("USA", "United States");

            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine(country.Key + " - " + country.Value);
            }

            string c = countries["UA"];
            Console.WriteLine(c);

            countries["USA"] = "America";
            Console.WriteLine(countries["USA"]);

            countries["IN"] = "India";
            Console.WriteLine("---------------------------");
            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine(country.Key + " - " + country.Value);
            }

            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill" });
            people.Add('t', new Person() { Name = "Tom" });
            people.Add('j', new Person() { Name = "Jack" });
            people.Add('r', new Person() { Name = "Rita" });
            foreach (var item in people)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine("-------------------------------");

            people['b'] = new Person() { Name = "Bob" };

            if(people.ContainsKey('a'))
            {
                people['a'] = new Person() { Name = "Anna" };
            }
            else
            {
                Console.WriteLine("Does not key.");
            }

                foreach (var item in people)
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
            Console.WriteLine("-------Keys---------------");
            foreach (var key in people.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("-------Values---------------");
            foreach (var value in people.Values)
            {
                Console.WriteLine(value);
            }

            people.Remove('b');
            foreach (var item in people)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
