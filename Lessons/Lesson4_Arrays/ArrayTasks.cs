using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson4_Arrays;

public class ArrayTasks
{
    public static void Run()
    {
        //работа с массивом
        Console.WriteLine("Сколько чисел вы хотите ввести?");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Число {i + 1}:");
            nums[i] = int.Parse(Console.ReadLine());
        }
        
        int sum = 0, max = nums[0];
        foreach (var c in nums)
        {
            sum += c;
            if (max < c)
                max = c;
        }
        double avg = (double)sum / n;
        Array.Sort(nums);
        
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Среднее: {avg}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Отсортированный массив: ");
        foreach (var c in nums)
            Console.Write(c + " ");
        
        //работа со списком
        Console.WriteLine("Введите имена (введите 'stop' для завершения):");
        List<string> names = new List<string>();
        while (true)
        {
            string name = Console.ReadLine();
            if (name.ToLower() == "stop") break;
            names.Add(name);
        }

        Console.WriteLine("Список имен:");
        foreach (var name in names)
            Console.WriteLine(name);

        Console.WriteLine($"Всего имен: {names.Count}");
        if (names.Contains("Арман"))
            Console.WriteLine("Имя Арман уже есть в списке");
        else
            Console.WriteLine("Имя Арман не найдено");
    }
}