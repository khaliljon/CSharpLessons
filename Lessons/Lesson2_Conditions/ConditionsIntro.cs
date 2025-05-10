using System;
using System.Globalization;

namespace Lesson2_Conditions;

public class ConditionsIntro
{
    public static void Run()
    {
        Console.WriteLine("Введите температуру:");
        double temp = double.Parse(Console.ReadLine());

        if (temp < 0)
            Console.WriteLine("Очень холодно");
        else if (temp <= 15)
            Console.WriteLine("Прохладно");
        else if (temp <= 25)
            Console.WriteLine("Тепло");
        else if (temp > 25)
            Console.WriteLine("Жарко");

        //калькулятор
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите операцию (+, -, *, /)");
        string op = (Console.ReadLine());

        double result = 0;
        bool valid = true;
        
        switch (op)
        {
            case "+":
                result = (a + b);
                break;
            case "-":
                result = (a - b);
                break;
            case "*":
                result = (a * b);
                break;
            case "/":
                result = b!=0 ? a/b : throw new DivideByZeroException();
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                valid = false;
                break;
        }

        if (valid)
        Console.WriteLine($"Результат: {result}");
}
}