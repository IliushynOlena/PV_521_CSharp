using System.ComponentModel.DataAnnotations;

namespace _22_DataAnnotations
{
    class User
    {
    
        [Required(ErrorMessage ="Id not found")]//not be empty
        public int Id { get; set; }


        [Required(ErrorMessage ="Name not set")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Illegal length")]
        [RegularExpression("[A-Za-z]")]
        ///dfdfd5dg5d4g5dfg5df4g
        public string Name { get; set; }//"              "

        [Required(ErrorMessage = "Age not set")]
        [Range(1,100, ErrorMessage ="Error age")]
        public int Age { get; set; }//value = 0

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage ="Not confirm password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [RegularExpression(@"\+380\d{2}\-\d{3}\-\d{2}\-\d{2}|\+38\(0\d{2}\)\d{3}\-\d{2}\-\d{2}|\+380[0-9]{9}")]

        public string Phone { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            //Menu 
            //1 * Add new User
            //2 Selialize
            //3 Deserialize
            //DataAnnotations == Attribute 
            User user = new User();
            bool isValid = true;
            do
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter Login");
                string login = Console.ReadLine()!;

                Console.WriteLine("Enter password");
                string password = Console.ReadLine()!;

                Console.WriteLine("Confirm password");
                string confirmPassword = Console.ReadLine()!;

                Console.WriteLine("Enter email");
                string email = Console.ReadLine()!;

                Console.WriteLine("Enter phone");
                string phone = Console.ReadLine()!;


                user.Id = 1;
                user.Name = name;
                user.Age = age;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Email = email;
                user.Phone = phone;
                user.Login = login;


                var result = new List<ValidationResult>();
                var context = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, context, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }


            } while (!isValid);

            //Add to dictionary 

            Console.WriteLine("Model is valid");
        }
    }
}

