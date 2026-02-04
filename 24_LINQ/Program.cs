namespace _24_LINQ
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"Product :  {Name} : {Category} ";
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Product :  {Name}. Age :  {Age} ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# - LINQ Language Integrated Query (LINQ)
            //data - IEnumerable
            //■ LINQ to DataSet – використовується для отримання даних із DataSet;
            //■ LINQ to XML — застосовується для отримання інформації із файлів XML;
            //■ LINQ to Sql — використовується для отримання даних із MS SQL Server;
            //■ LINQ to Entities — використовується при роботі з технологією Entity Framework;
            //■ LINQ to Objects — використовується при роботі з колекція;
            //■ Parallel LINQ(PLINQ) — застосовується для виконання паралельних запитів.

            #region Select

            
            //Синтаксис запиту
            int[] arr = new int[] { 5, 34, 67, 12, 94, 42 };

            //    res =       from item_name in source_name
            //                select  item_name
           IEnumerable<int> res = from i in arr
                                  select i*-1;//select == return //відкладене завантаження

            List<int> list = arr.ToList();//негайне завантаження
            //Console.WriteLine("----------------Original arr --------------");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine("\n----------------Arr after query --------------");
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }


            //Синтаксис методу
            //IEnumerable<int> res2 = arr.Select(ConvertData);
            //IEnumerable<int> res2 = arr.Select(delegate(int item) { return item *- 1; });
            IEnumerable<int> res2 = arr.Select( item=> item *- 1);
            Console.WriteLine("\n----------------Arr 2 after query --------------");
            foreach (var item in res2)
            {
                Console.Write(item + " ");
            }
            #endregion
            #region Where
            int[] array = { 15, 7, 14, 58, 63, 21, 4 };

            var query = from i in array
                        where i%2 == 0
                        select i*-1;

            Console.WriteLine("\n----Array after where ------");
            foreach (var item in query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //method
            //query = array.Where(i => i%2 == 0).Select(i=> i*-1);
            //query = array.Where(i => i%2 == 0).Select(i=> i);
            query = array.Where(i => i%2 == 0);
            Console.WriteLine("\n----Array after where ------");
            foreach (var item in query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            string[] words = { "hello", "green", "blue", "yellow", "sasha" };
            var result = from word in words 
                         where word.Length == 5
                         select word;
            Console.WriteLine("\n----------- Word.Lenght == 5 ----------");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            result = words.Where(i=> i.Length == 5).Select(i=>i);
            Console.WriteLine("\n----------- Word.Lenght == 5 ----------");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Order by
            int[] arrayInt = { 5, -9, 47, -36, 25, 3, 9, -4, -7 ,-8 ,-10, 5 ,12,16 };
            IEnumerable<int> query2 = from i in arrayInt
                                      where i%2 == 0
                                      orderby i descending //ascending (default)
                                      select i;
            Console.WriteLine("\n------------ Array --------------");
            foreach (var item in query2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //User { Name, LOgin, Email}
            //Method
            //query2 = arrayInt.Where(i=> i%2 == 0).OrderBy(i=> i);
            int[] s;
            
            query2 = arrayInt.Where(i=> i%2 == 0).OrderByDescending(i=> i);
            Console.WriteLine("\n------------ Array --------------");
            foreach (var item in query2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            #endregion

            #region Group By
            //                   4   5   2   4   2   5
            int[] array3 = { 5, 34, 65, 12, 94, 42, 365 };
            IEnumerable<IGrouping<int,int>> query3 = from i in array3
                                                     where i > 10
                                                     group i by i % 10;

            foreach (IGrouping<int, int> item in query3)
            {
                Console.Write($"Key : {item.Key}. Value : ");
                foreach (var el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //method
            query3 = array3.Where(i => i > 10).GroupBy(i => i % 10).OrderBy(i=>i.Key);
            //foreach (IGrouping<int, int> item in query3)
            foreach (var item in query3)
            {
                Console.Write($"Key : {item.Key}. Value : ");
                foreach (var el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Product[] products =
            {
                new Product(){ Name = "Apple", Category = "Fruit"},
                new Product(){ Name = "Banana", Category = "Fruit"},
                new Product(){ Name = "Phone", Category = "Tech"},
                new Product(){ Name = "Laptop", Category = "Tech"},
                new Product(){ Name = "Sasuage", Category = "Food"},
                new Product(){ Name = "Butter", Category = "Food"},
                new Product(){ Name = "Bread", Category = "Food"}
            };

            var res3 = products.GroupBy(p => p.Category);
            foreach (IGrouping<string, Product> item in res3)
            {
                Console.Write($"Key : {item.Key}. Value : ");
                foreach (var el in item)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region Min, Max, Average, Count, Sum
            int[] numbers = { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<User> users = new List<User>()
            {
                new User(){Name="Bob", Age = 23},
                new User(){Name="Tom", Age = 8},
                new User(){Name="Bill", Age = 12 }
            };

            Console.WriteLine($"Count numbers : {arr.Count()}");
            Console.WriteLine($"Count users : {users.Count()}");


            Console.WriteLine($"Max numbers : {numbers.Max()}");
            Console.WriteLine($"Max users : {users.Max(u=>u.Age)}");

            Console.WriteLine($"Min numbers : {numbers.Min()}");
            Console.WriteLine($"Min users : {users.Min(u => u.Age)}");

            Console.WriteLine($"Average numbers : {numbers.Average()}");
            Console.WriteLine($"Average users : {users.Average(u => u.Age)}");

            Console.WriteLine($"Summa numbers : {numbers.Sum()}");
            Console.WriteLine($"Summa users : {users.Sum(u => u.Age)}");
            #endregion

            #region Methods
            string[] soft = { "Blue", "Grey", "Yellow", "Cyan", "Grey", "Yellow" };
            string[] hard = { "Yellow", "Magenta", "White", "Blue" };

            IEnumerable<string> strings;

            ////показує чим перша колекція відрізняється від другої
            //strings = soft.Except(hard);

            ////спільні елементи для двох колекцій
            //strings = soft.Intersect(hard);

            ////об*єднуємо дві колекції без повторень
            //strings = soft.Union(hard);

            //об*єднуємо дві колекції з дублюванням даних
            //strings = soft.Concat(hard);

            //видаляє дублікати
            strings = soft.Distinct();

            foreach (string s in strings)
                Console.WriteLine(s);
            #endregion

        }
        static int ConvertData(int value)
        {
            return value *-1;
        }
    }
}
