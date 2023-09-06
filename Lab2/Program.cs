using Lab2;
using System;

class Program
{
    static void Main()
    {
        LeariningTest test = new LeariningTest();

        test.Print();
        test.SortArray();

        Console.Write("Найти: ");
        int target = int.Parse(Console.ReadLine());

        int index = test.FindElementBinary(target);

        if (index != -1)
        {
            Console.WriteLine($"Элемент {target} найден на {index}");
        }
        else
        {
            Console.WriteLine($"Элемент {target} не найден");
        }
    }
}