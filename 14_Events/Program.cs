namespace _14_Events
{
    public delegate void ExamDelegate(string task);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"Student : {LastName} {FirstName} pass the exam {task}");
        }
    }

    class Teacher
    {

        // List<Student> students;
        public event Action TestEvent;//void ()
        //public event ExamDelegate ExamEvent;//ExamDelegate = 0c321ds6fs56d ()   or Invoke()
        //or
        private ExamDelegate examDelegate;

        public event ExamDelegate ExamEvent//value - method
        {
            add {
                examDelegate += value;
                Console.WriteLine(value.Method.Name + " was added");
            }
            remove 
            { 
                examDelegate -= value;
                Console.WriteLine(value.Method.Name + " was removed");
            }
        }
        public void StartAction()
        {
            TestEvent();
        }

        //public void SetExamDelegate()
        public void CreateExam(string task)
        {
            //exam creating
            //some code

            //foreach (Student student in students)
            //{
            //    student.PassExam(task);
            //}
            //ExamDelegate(task);
            //call all students
            examDelegate?.Invoke(task);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student
                {
                    FirstName = "Mukola",
                    LastName = "Oliunuk",
                    Birthdate = new DateTime(2000,5,12)
                },
                 new Student
                 {
                    FirstName = "Olga",
                    LastName = "Ivanchuk",
                    Birthdate = new DateTime(2002,5,12)
                 },
                  new Student
                  {
                    FirstName = "Oleg",
                    LastName = "Muronchuk",
                    Birthdate = new DateTime(1999,5,12)
                  },
                   new Student
                   {
                    FirstName = "Ira",
                    LastName = "Oliunuk",
                    Birthdate = new DateTime(2000,5,12)
                   },
                    new Student
                    {
                    FirstName = "Petro",
                    LastName = "Oliunuk",
                    Birthdate = new DateTime(2000,5,12)
                    }

            };

            Teacher teacher = new Teacher();
            foreach (Student student in list) {
                //subcribe
                teacher.ExamEvent += new ExamDelegate(student.PassExam);

            }

            //teacher.ExamDelegate = null;
            teacher.ExamEvent -= list[4].PassExam;

            teacher.CreateExam("C# exam 02.02.2026 in 21 auditory");


            teacher.TestEvent += Console.Clear;
            teacher.TestEvent -= Console.Clear;
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent += delegate () { Console.ForegroundColor = ConsoleColor.Green; };
            teacher.TestEvent -= delegate () { Console.ForegroundColor = ConsoleColor.Green; };
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent -= Teacher_TestEvent;
            teacher.TestEvent += () => Console.ResetColor();

            Console.WriteLine("----------------------------");

            teacher.StartAction();
        }

        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto-created method by press TAB!");
        }
    }
}
