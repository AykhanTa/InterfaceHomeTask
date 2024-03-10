using InterfaceHomeTask.Task2.Services;

namespace InterfaceHomeTask.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new("email1","Ayxan1234");
            user.FullName = "Test Testov";
            user.ShowInfo();

        }
    }
}