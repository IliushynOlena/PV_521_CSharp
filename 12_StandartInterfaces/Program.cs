using System.Collections;

namespace _12_StandartInterfaces
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Student card : {Number}  {Series}";
        }
    }
    class Student: IComparable<Student>, ICloneable
    {
        public string Name { get; set; }//0x147  Tom  = 02588 Alisa
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }//value 1990/5/5  --> 2000/5/5
        public StudentCard StudentCard { get; set; }//0x25x8 = 0x25x8

        public object Clone()
        {
            Student copy = (Student) this.MemberwiseClone();
            copy.Name = (string) this.Name.Clone();
            copy.LastName = (string) this.LastName.Clone();
            copy.StudentCard = new StudentCard()
            {
                Number = this.StudentCard.Number,
                Series = this.StudentCard.Series
            };
            return copy;
        }

        public int CompareTo(Student? other)
        {
            return this.Name.CompareTo(other?.Name);
        }
      

        //public int CompareTo(object? obj)
        //{
        //    if (obj is Student)
        //    {
        //       return this.Name.CompareTo((obj as Student)!.Name);
        //    }
        //    throw new Exception();
        //}

        public override string ToString()
        {
            return $"Fullname : {Name} {LastName}. Birthdate : {Birthdate.ToShortDateString()}" +
                $"\n{StudentCard}";
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students;
        public Auditory()
        {
            students = new Student[]
            {
                new Student 
                {
                     Name = "Tom",
                     LastName = "Nicson",
                     Birthdate = new DateTime(1995,12,5),
                     StudentCard = new StudentCard{ Number = 111111, Series = "AA" }
                },
                new Student
                {
                     Name = "Bob",
                     LastName = "Tomson",
                     Birthdate = new DateTime(1999,5,5),
                     StudentCard = new StudentCard{ Number = 222222, Series = "BB" }
                },
                new Student
                {
                     Name = "Olga",
                     LastName = "Ivanchuk",
                     Birthdate = new DateTime(1995,12,5),
                     StudentCard = new StudentCard{ Number = 333333, Series = "CC" }
                },
                new Student
                {
                     Name = "Iruna",
                     LastName = "Mukhalchuk",
                     Birthdate = new DateTime(1995,12,5),
                     StudentCard = new StudentCard{ Number = 444444, Series = "DD" }
                },
                new Student
                {
                     Name = "Oleg",
                     LastName = "Oliunuk",
                     Birthdate = new DateTime(1995,12,5),
                     StudentCard = new StudentCard{ Number = 555555, Series = "FF" }
                }

            };
        }
        public IEnumerator GetEnumerator()
        {
           return students.GetEnumerator();
        }
        public void Print()
        {
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            foreach (var item in students)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class LastNameComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.LastName.CompareTo(y!.LastName);
        }
    }
    class BirthdateComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.Birthdate.CompareTo(y!.Birthdate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student//student = 0x2d5d4df65sd4
            {
                Name = "Tom",
                LastName = "Nicson",
                Birthdate = new DateTime(1995, 12, 5),
                StudentCard = new StudentCard { Number = 111111, Series = "AA" }
            };
            Console.WriteLine(student);

            Student copy =(Student)student.Clone();//copy = 0x2d5d4df65sd4
            Console.WriteLine("--------------- Clone ---------------");
            Console.WriteLine(copy);
            copy.Name = "Alisa";
            copy.Birthdate = new DateTime(2000, 5, 25);
            copy.StudentCard.Number = 999999;
            Console.WriteLine();
            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(copy);
            //Auditory auditory = new Auditory();
            ////auditory.Print();
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
            //auditory.Sort();
            //Console.WriteLine("---------------------After sort------------");
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}

            //auditory.Sort(new LastNameComparer());
            //Console.WriteLine("---------------------Last name sort------------");
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}

            //auditory.Sort(new BirthdateComparer());
            //Console.WriteLine("---------------------Birthdate sort------------");
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
        }
    }
}
