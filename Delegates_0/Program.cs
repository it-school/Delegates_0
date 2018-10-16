using System;
namespace Delegates0
{
    // Создадим делегат
    delegate int IntOperation(int i, int j);

    class Program
    {
        // Организуем ряд методов
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Prz(int x, int y)
        {
            return x * y;
        }

        static int Del(int x, int y)
        {
            return x / y;
        }

        static void Main()
        {
            // Сконструируем делегат
            IntOperation op1 = new IntOperation(Sum);

            int result = op1(5, 10);
            Console.WriteLine("Сумма: " + result);

            // Изменим ссылку на метод
            op1 = new IntOperation(Prz);
            result = op1(5, 10);
            Console.WriteLine("Произведение: " + result);
            Console.ReadLine();
        }
    }
}
