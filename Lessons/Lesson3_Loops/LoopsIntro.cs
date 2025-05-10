namespace Lesson3_Loops;

public class LoopsIntro
{
    public static void Run()
    {
        //угадай число
        Random rand = new Random();
        int secret = rand.Next(1,101);
        int guess = 0;
        int attempts = 0;
        
        Console.WriteLine("Угадай число от 1 до 100");
        
        while (guess != secret)
        {
            Console.WriteLine("Введите число:");
            guess = int.Parse(Console.ReadLine());
            attempts++;
                
            if (guess < secret)
                Console.WriteLine("Больше");
            else if (guess > secret)
                Console.WriteLine("Меньше");
        }
        
        Console.WriteLine($"Угадал за {attempts} попыток!");
        
        //таблица умножения
        Console.WriteLine("\nТаблица умножения");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i*j}");
            }
        }
    }
}