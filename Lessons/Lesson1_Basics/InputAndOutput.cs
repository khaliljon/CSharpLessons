using System;

namespace Lesson1_Basics
{
    public class InputAndOutput
    {
        public static void Run()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Вы студент? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine("АНКЕТА:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Рост: {height} м");
            Console.WriteLine($"Студент: {(isStudent ? "Да" : "Нет")}");
        }
    }
}