using System.Globalization;

namespace Lesson8_Interfaces
{
//интерфейс
    public interface IMovable
    {
        void Move();
    }

//интерфейс
    public interface IAttackable
    {
        void Attack();
    }

//класс, реализующий несколько интерфейсов
    public class Warrior : IMovable, IAttackable
    {
        public void Move()
        {
            Console.WriteLine("Воин двигается вперед");
        }

        public void Attack()
        {
            Console.WriteLine("Воин атакует мечом");
        }
    }

    public class Archer : IMovable, IAttackable
    {
        public void Move()
        {
            Console.WriteLine("Лучник занимает позицию");
        }

        public void Attack()
        {
            Console.WriteLine("Лучник стреляет из лука");
        }
    }

    public class InterfaceDemo
    {
        public static void Run()
        {
            List<IMovable> characters = new List<IMovable>
            {
                new Warrior(),
                new Archer()
            };
            
            Console.WriteLine("Все двигаются");
            foreach (var c in characters)
            {
                c.Move();//интерфейсный вызов
            }

            Console.WriteLine("Теперь все атакуют");
            List<IAttackable> attackers = new List<IAttackable>
            {
                new Warrior(),
                new Archer()
            };

            foreach (var c in attackers)
            {
                c.Attack();//интерфейсный вызов
            }
        }
    }
}

