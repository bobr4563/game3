using System;

namespace game3;
class Program
{
    static void Main()
    {
        Random random = new Random();
        int score = 0;
        int totalTasks = 5;

        Console.WriteLine("Добро пожаловать в игру 'Уборка на даче'!");
        Console.WriteLine($"У вас {totalTasks} заданий по уборке.");

        for (int i = 0; i < totalTasks; i++)
        {
            Console.WriteLine($"\nЗадание {i + 1}:");
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1. Убрать листья");
            Console.WriteLine("2. Полить цветы");
            Console.WriteLine("3. Убрать мусор");
            Console.WriteLine("4. Прополоть грядки");
            Console.WriteLine("5. Собирать ягоды");
            Console.Write("Ваш выбор (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int task))
            {
                if (task < 1 || task > 5)
                {
                    Console.WriteLine("Пожалуйста, выберите задачу от 1 до 5.");
                    i--; // Уменьшаем счетчик заданий
                    continue;
                }

                // Генерируем случайный результат выполнения
                bool taskCompleted = random.Next(2) == 1; // 50% шанс на успех

                if (taskCompleted)
                {
                    Console.WriteLine("Задание выполнено! Вы заработали 1 очко.");
                    score++;
                }
                else
                {
                    Console.WriteLine("Задание не выполнено. Попробуйте снова.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите допустимый номер задачи.");
                i--; // Уменьшаем счетчик заданий
            }
        }

        Console.WriteLine($"\nИгра окончена! Ваш счет: {score}");
    }
}
