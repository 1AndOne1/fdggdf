// Сравнение объектов
interface Compar
{
    int ComparTo(object obj);
}

class Cars : Compar
{
    public string Car;
    public int HS;

    public Cars(string car, int hs)
    {
        Car = car;
        HS = hs;
    }
    public int ComparTo(object obj)
    {
        if (obj == null) return 0;

        if (obj is Cars anotherCar)
        {
            return HS.CompareTo(anotherCar.HS);
        }
        else
        {
            throw new ArgumentException("Ошибка");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите название первой машины:");
        string car1 = Console.ReadLine();

        Console.WriteLine("Введите лошадиные силы первой машины:");
        int hs1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите название второй машины:");
        string car2 = Console.ReadLine();

        Console.WriteLine("Введите лошадиные силы:");
        int hs2 = int.Parse(Console.ReadLine());

        Cars cars1 = new Cars(car1, hs1);
        Cars cars2 = new Cars(car2, hs2);
        Console.WriteLine($"{cars1.Car} // {cars2.Car}");
        int sravnenie = car1.CompareTo(car2);
        if (sravnenie < 0) {
            Console.WriteLine($"{cars1.HS} менее мощная чем {cars2.HS}");
        }
        else if (sravnenie > 0) {
            Console.WriteLine($"{cars1.HS} мощнее чем {cars2.HS}");
        }
        else {
            Console.WriteLine($"У {cars1.Car} и {cars2.Car} мощность одинаковая {cars1.HS}");
        }
    }
}
