namespace Lesson5_Methods;

public class MethodsIntro
{
    //Метод без параметров
    static void SayHello()
    {
        Console.WriteLine("Привет, пользователь");
    }

    //Метод с параметрами и возвращаемым значением
    static int Add(int a, int b)
    {
        return a + b;
    }

    //Пергегрузка метода Add
    static double Add(double a, double b)
    {
        return a + b;
    }

    //Метод с передачей массива
    static int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (var n in numbers)
            sum += n;
        return sum;
    }

    //Рекурсивный метод - факториал
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    public static void Run()
    {
        SayHello();
        Console.WriteLine("Сложение чисел:");
        Console.WriteLine($"5 + 3 = {Add(5, 3)}");
        Console.WriteLine($"4.5 + 4.15 = {Add(4.5, 4.15)}");

        Console.WriteLine("Сумма всех чисел (params):");
        Console.WriteLine($"SumAll(1, 2, 3) = {SumAll(1, 2, 3)})");

        Console.WriteLine("Введите число для факториала:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n}! = {Factorial(n)})");
    }
}

   
