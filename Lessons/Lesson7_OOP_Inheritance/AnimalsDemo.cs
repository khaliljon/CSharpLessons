namespace Lesson7_OOP_Inheritance;

//Абстрактный класс
public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Speak();//абстрактный метод
    
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} говорит: Гав-гав!");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Speak()
    {
        Console.WriteLine($"{Name} говорит: Мяу!");
    }
}

public class AnimalsDemo
{
    public static void Run()
    {
        Animal[] zoo = new Animal[2];
        zoo[0] = new Dog("Шарик");
        zoo[1] = new Cat("Мурка");

        foreach (Animal animal in zoo)
        {
            animal.Speak(); //полиморфный вызов
        }
    }
}