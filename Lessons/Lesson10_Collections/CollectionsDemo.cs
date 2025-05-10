using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10_Collections
{
    public class CollectionsDemo
    {
        public static void Run()
        {
            // ===== List =====
            List<string> names = new List<string> { "Arman", "Dana", "Rustam", "Aliya", "Arman" };
            Console.WriteLine("Список имён:");
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine($"\nВсего: {names.Count}");
            Console.WriteLine($"Есть ли 'Arman'? {names.Contains("Arman")}");

            // Уникальные имена
            HashSet<string> uniqueNames = new HashSet<string>(names);
            Console.WriteLine($"\nУникальные имена: {string.Join(", ", uniqueNames)}");

            // ===== Dictionary =====
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Arman", 21 },
                { "Dana", 19 },
                { "Rustam", 23 }
            };

            Console.WriteLine("\nСловарь (имя → возраст):");
            foreach (var kv in ages)
                Console.WriteLine($"{kv.Key} — {kv.Value} лет");

            // ===== LINQ =====
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var even = numbers.Where(n => n % 2 == 0);
            var squares = numbers.Select(n => n * n);
            var sum = numbers.Sum();
            var max = numbers.Max();

            Console.WriteLine($"\nЧётные: {string.Join(", ", even)}");
            Console.WriteLine($"Квадраты: {string.Join(", ", squares)}");
            Console.WriteLine($"Сумма: {sum}, Максимум: {max}");
        }
    }
}