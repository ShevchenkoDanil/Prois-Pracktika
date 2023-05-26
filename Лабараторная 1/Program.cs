using System;

namespace Лабараторная_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1");

            string str1 = "hello";
            string str2 = "word";
            string result = str1 + " " + str2;
            Console.WriteLine(result);

            
            Console.WriteLine("Задание 2");

            int a = 20;
            int b = 10;
            Console.WriteLine("Сложение:" + (a + b));
            Console.WriteLine("Вычетание:" + (a - b));
            Console.WriteLine("Умножение:" + (a * b));
            Console.WriteLine("Деление:" + (a / b));

            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите отчесвто:");
            string middleName = Console.ReadLine();

            String fullName = $"{lastName} {firstName} {middleName}";
            Console.WriteLine($"Полное имя: {fullName}");

            Console.WriteLine("Задание 4");

            int playerHealth = 90; // Здоровье игрока
            int playerDamage = 35; // Урон игрока
            int playerDefense = 10; // Защита игрока

            int monsterHealth = 70; // Здоровье монста
            int monsterDamage = 20; // Урон монстра
            int monsterDefense = 5; // Защита монстра

            int playerDamageDealt = (int)Math.Round((double)monsterDamage / playerDefense * 90); // Урон, нанесенный игроком
            int monsterDamageDealt = (int)Math.Round((double)playerDamage / monsterDefense * 90); // УРон, нанесенный монстром

            playerHealth -= monsterDamageDealt; // Уменьшаем здоровье игрока на урон, нанесенный монстром
            monsterHealth -= playerDamageDealt; // Уменьшаем здоровье монстра на урон, нанесеннйы игроком

            Console.WriteLine("Здоровье игрока:" + playerHealth);
            Console.WriteLine("Здоровье монстра:" + monsterHealth);
            Console.WriteLine("Урон нанесенный игроком:" + playerDamageDealt);
            Console.WriteLine("Урон нанесенный монстром:" + monsterDamageDealt);



        }
    }
}
