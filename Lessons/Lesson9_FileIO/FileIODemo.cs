namespace Lesson9_FileIO
{
    public class FileIODemo
    {
        public static void Run()
        {
            string folder = "Data";
            string path = Path.Combine(folder, "example.txt");
            
            //Создание папки
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                Console.WriteLine($"Папка {folder} создана");
            }
            
            //Запись текста в файл
            string text = "Что-то здесь должно быть. \nДата: " + DateTime.Now;
            File.WriteAllText(path, text);
            Console.WriteLine($"Файл записан: {path}");
            
            //Добавление строки
            File.AppendAllText(path, "\nДополнительная строка");
            
            //Чтение всего содержимого
            Console.WriteLine("\n--- Содержимое всего файла ---");
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            
            //Чтение построчно
            Console.WriteLine("\n--- Построчное чтение ---");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine($"[строка] {line}");
            }
            
            //Удаление файла
            Console.Write("\nУдалить файл? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                File.Delete(path);
                Console.WriteLine("Файл удален.");
            }
        }
    }    
}
