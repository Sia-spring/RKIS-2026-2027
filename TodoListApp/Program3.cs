using System;

namespace TodoList
{
    class Program3
    {
        static void Main(string[] args)
        {
            // Массив на 2 элемента
            string[] todos = new string[2]; 
            bool isRunning = true; 

            // Интерактивный ввод профиля
            Console.WriteLine("Давайте познакомимся!");
            Console.Write("Введите ваше Имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите вашу Фамилию: ");
            string userSurname = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            string userBirthYear = Console.ReadLine();

            Console.WriteLine($"\nДобро пожаловать, {userName}! Введите 'help'.");

            while (isRunning)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;

                // Разделяем строку на команду и аргументы
                string[] parts = input.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0].ToLower();

                switch (command)
                {
                    case "help":
                        Console.WriteLine("  help - список команд");
                        Console.WriteLine("  profile - данные пользователя");
                        Console.WriteLine("  exit - выйти");
                        break;
                    case "profile":
                        Console.WriteLine($"{userName} {userSurname}, {userBirthYear}");
                        break;
                    case "exit":
                        isRunning = false;
                        Console.WriteLine("Завершение работы...");
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }
            }
        }
    }
}