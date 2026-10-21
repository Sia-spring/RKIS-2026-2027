using System;

namespace TodoList
{
    class Program3
    {
        static void Main(string[] args)
        {
            // Создаем массив на 2 элемента
            string[] todos = new string[2]; 
            int count = 0; // Счетчик добавленных задач
            bool isRunning = true; // Флаг для работы цикла

            Console.WriteLine("Добро пожаловать! Введите 'help'.");

            // Бесконечный цикл
            while (isRunning)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;

                // Заглушка для проверки
                Console.WriteLine("Вы ввели: " + input);
            }
        }
    }
}