using System;

namespace practic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Open();
        }
        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
            Console.WriteLine("1. Сложите два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два чилса");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент из числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            Console.Write("Введите номер операции: ");
            Write(Convert.ToInt32(Console.ReadLine()));
        }
        static void Write(int e)
        {
            int number = 0;
            if (e == 1)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = value + value2;
            }
            else if (e == 2)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = value - value2;
            }
            else if (e == 3)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = value * value2;
            }
            else if (e == 4)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = value / value2;
            }
            else if (e == 5)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = Convert.ToInt32(Math.Pow(value, value2));
            }
            else if (e == 6)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                number = Convert.ToInt32(Math.Sqrt(value));
            }
            else if (e == 7)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int value2 = Convert.ToInt32(Console.ReadLine());
                number = value / 100 * value2;
            }
            else if (e == 8)
            {
                Console.Write("Введите первое число: ");
                int value = Convert.ToInt32(Console.ReadLine());
                number = 1;
                for (int i = 1; i <= value; i++)
                {
                    number *= i;
                    if (i == value) Console.Write($" {i}");
                    else Console.Write($" {i} * ");
                }
            }
            else if (e == 9)
            {
                Environment.Exit(0);
                return;
            }
            Console.WriteLine("Ответ: " + number);
            next(e);
        }
        static void next(int num)
        {
            Console.Write("Хотите продолжить? (Y,N) ");
            string button = Console.ReadLine();
            if (button == "Y" || button == "y") Write(num);
            else if (button == "N" || button == "n") Open();
        }
    }
}
