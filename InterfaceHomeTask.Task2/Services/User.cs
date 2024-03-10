using InterfaceHomeTask.Task2.Interfaces;

namespace InterfaceHomeTask.Task2.Services
{
    internal class User : IAccount
    {

        public int ID { get; private set;}
        public string FullName { get; set; }
        public string Email { get; set; }

        string _password;
        public string  Password {
            get => _password; 
            set
            {
                if (!PasswordChecker(value)) 
                {
                    Console.WriteLine("Duzgun formatda password daxil edin.");
                    return;
                }
                _password=value;

            }
        }

        public User(string email,string password)
        {
            Email = email;
            Password = password;            
        }
        public bool PasswordChecker(string password)
        {
            int countUpper = 0;
            int countLower = 0;
            int isDigit = 0;
            foreach (var c in Password)
            {
                if (char.IsDigit(c))
                {
                    isDigit++;
                }
                else if (char.IsUpper(c))
                {
                    countUpper++;
                }
                else if (char.IsLower(c))
                {
                    countLower++;
                }
            }

            if (password.Length > 8)
            {
                if (countUpper > 0 && countLower > 0)
                {
                    if (isDigit > 0)
                    {
                        return true;
                    }
                }

            }
            return false;
            
        }

        public void ShowInfo()
        {

            
        }
    }
}
