using System;
using System.IO;

namespace Lesson11_Exceptions
{
    public class ExceptionDemo
    {
        public static void Run()
        {
            try
            {
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"Результат деления: {result}");

                // Пример чтения несуществующего файла
                Console.WriteLine("\nПопытка прочитать файл:");
                string content = File.ReadAllText("nofile.txt");
                Console.WriteLine(content);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ Ошибка: Деление на ноль.");
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Ошибка: Введены некорректные данные.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"❌ Файл не найден: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Необработанная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("⏹️ Работа завершена. (блок finally)");
            }
        }
    }
}