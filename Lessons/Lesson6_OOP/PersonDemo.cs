namespace Lesson6_OOP;

public class Person
{
    //Поля (private)
    private string name;
    private int age;
    
    //Свойства (public)
    public string Name
    {
        get{return name;}
        set
        {
            if(!string.IsNullOrEmpty(value))
                name = value;
        }
    }

    public int Age
    {
        get{return age;}
        set
        {
            if(value >= 0 || value <= 120)
                age = value;
        }
    }
    
    //Конструктор
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    //Метод
    public void Introduce()
    {
        Console.WriteLine($"Привет, меня зовут {Name}, мне {Age}");
    }
        
}

public class PersonDemo
{
    public static void Run()
    {
        Console.WriteLine("Введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());
        Person person = new Person(name, age);
        person.Introduce();
    }
}