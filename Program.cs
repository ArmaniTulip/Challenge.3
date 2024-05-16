using System.Xml.Schema;

namespace Challenge._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string storedUserName = "Armani";
            const string storedPassWord = "Password";
            bool success = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your username.");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password.");
                string password = Console.ReadLine();

                if (username == storedUserName && password == storedPassWord)
                {
                    success = true;
                    break;
                }
                Console.WriteLine();
            }

            if (success)
            {
                Console.WriteLine("Welcome " + storedUserName);
            }
            else
            {
                Console.WriteLine("Account blocked");
            }
           
        }
        
    }
}
