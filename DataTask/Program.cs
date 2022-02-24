using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTask.Tasks;

namespace DataTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
        reload:
            Console.Clear();

            Console.WriteLine(String.Format("Выберите функцию:\n" +
                                                 "1 - {0}\n" +
                                                 "2 - {1}\n" +
                                                 "3 - {2}\n" +
                                                 "4 - {3}\n" +
                                                 "5 - {4}\n" +
                                                 "6 - {5}\n" +
                                                 "7 - {6}\n" +
                                                 "Остальное - Выход.",

                                                 "Делимость двух чисел.",
                                                 "Разложение числа на простые множители.",
                                                 "Проверка числа на простоту.",
                                                 "Нахождение простых чисел в интервале.",
                                                 "Нахождение простых чисел в интервале с записью в файл.",
                                                 "Поиск пар чисел близнецов.",
                                                 "Нахождение простых чисел решетом Эратосфена."
                                                 ));
            ConsoleKey key = Console.ReadKey().Key;
            Console.Clear();

            switch (key) 
            {
                case ConsoleKey.D1:
                    DiviseTask dm = new DiviseTask();
                    int b;
                    int a;

                    while (true)
                    {
                        a = dm.GetNum("делимое");
                        b = dm.GetNum("делитель");

                        Console.WriteLine(dm.Dividing(a, b));

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D2:
                    while (true)
                    {
                        FactorTask fc = new FactorTask();
                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D3:
                    while (true) 
                    {
                        Console.Write("Введите число: ");
                        PrimeNumbersTask prime = new PrimeNumbersTask(Console.ReadLine());

                        if (prime.IsPrime())
                            Console.WriteLine("Число ПРОСТОЕ!\n");
                        else
                            Console.WriteLine("Число НЕ является простым!\n");

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D4:
                    while (true)
                    {
                        Console.Write("Введите начало интервала: ");
                        string start = Console.ReadLine();

                        Console.Write("Введите конец интервала: ");
                        string end = Console.ReadLine();

                        PrimeNumbersTask prime = new PrimeNumbersTask();
                        Console.WriteLine(prime.PrimesInInterval(start, end));

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D5:
                    while (true)
                    {
                        Console.Write("Введите начало интервала: ");
                        string start = Console.ReadLine();

                        Console.Write("Введите конец интервала: ");
                        string end = Console.ReadLine();

                        PrimeNumbersTask prime = new PrimeNumbersTask();
                        prime.PrimesInInterval(start, end, true);

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D6:
                    while (true)
                    {
                        Console.Write("Введите начало интервала: ");
                        string start = Console.ReadLine();

                        Console.Write("Введите конец интервала: ");
                        string end = Console.ReadLine();

                        PrimeNumbersTask prime = new PrimeNumbersTask();
                        Console.WriteLine(prime.TwinsInInterval(start, end));

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

                case ConsoleKey.D7:
                    while (true)
                    {
                        Console.Write("Введите верхнюю границу решета: ");
                        string start_ = Console.ReadLine();

                        PrimeNumbersTask prime = new PrimeNumbersTask();

                        if (int.TryParse(start_, out int start)) 
                        {
                            List<int> erat = prime.EratosthenesSieve(start);

                            foreach(int i in erat)
                                Console.Write(i+"\n");
                            Console.WriteLine();
                        }
                        else
                            throw new Exception("Не число!");

                        Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу.");
                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            goto reload;
                    }

            }

            Console.ReadKey();

        }
    }
}
