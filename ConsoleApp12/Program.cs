using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое слово: ");
            string userMessage = Console.ReadLine();
            Console.Write("Введите кол-во повторов: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < userNumber; i++)
            {
                Console.WriteLine("userMessage");
            }
        }
    }
}
