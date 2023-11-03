using System;

// Сравнение объектов
interface Compar
{
    int ComparTo(object obj);
}

// Класс, реализующий интерфейс Compar
class Cars : Compar
{
    public string Car;
    public int HS;

    public Cars(string car, int hs)
    {
        Car = car;
        HS = hs;
    }

    // Реализуем метод ComparTo интерфейса Compar
    public int ComparTo(object obj)
    {
        if (obj == null) return 1;

        Cars anotherCar = obj as Cars;
        if (anotherCar != null)
        {
            // Сравниваем объекты по лошадиным силам
            return HS.Compar(anotherCar.HS);
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
        Console.WriteLine($"{cars1.HS}hs и {cars2.HS}hs");
    }
}
