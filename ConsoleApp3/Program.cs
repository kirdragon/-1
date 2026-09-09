using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.Write("Введите количество операций от 2 до 40: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n >= 2 && n <= 40)
                    break;

                Console.WriteLine("Ошибка! Введите число от 2 до 40.");
            }

            string[] names = new string[n];
            double[] prices = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nВведите название товара или услуги: ");
                names[i] = Console.ReadLine();

                Console.Write("Введите сумму: ");
                prices[i] = Convert.ToDouble(Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("\n===== МЕНЮ =====");
                Console.WriteLine("1 - Вывод данных");
                Console.WriteLine("2 - Статистика");
                Console.WriteLine("3 - Сортировка по цене");
                Console.WriteLine("4 - Конвертация валюты");
                Console.WriteLine("5 - Поиск по названию");
                Console.WriteLine("0 - Выход");

                Console.Write("Выберите пункт: ");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine("\n===== РАСХОДЫ =====");

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(names[i] + " - " + prices[i] + " руб.");
                    }
                }

                if (menu == 2)
                {
                    double sum = 0;
                    double max = prices[0];
                    double min = prices[0];

                    for (int i = 0; i < n; i++)
                    {
                        sum += prices[i];

                        if (prices[i] > max)
                            max = prices[i];

                        if (prices[i] < min)
                            min = prices[i];
                    }

                    Console.WriteLine("\n===== СТАТИСТИКА =====");
                    Console.WriteLine("Сумма: " + sum + " руб.");
                    Console.WriteLine("Среднее: " + sum / n + " руб.");
                    Console.WriteLine("Максимальная трата: " + max + " руб.");
                    Console.WriteLine("Минимальная трата: " + min + " руб.");
                }

                if (menu == 3)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        for (int j = 0; j < n - i - 1; j++)
                        {
                            if (prices[j] > prices[j + 1])
                            {
                                double tempPrice = prices[j];
                                prices[j] = prices[j + 1];
                                prices[j + 1] = tempPrice;

                                string tempName = names[j];
                                names[j] = names[j + 1];
                                names[j + 1] = tempName;
                            }
                        }
                    }

                    Console.WriteLine("\n===== СОРТИРОВКА ПО ЦЕНЕ =====");

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(names[i] + " - " + prices[i] + " руб.");
                    }
                }

                if (menu == 4)
                {
                    Console.WriteLine("\n1 - Доллары");
                    Console.WriteLine("2 - Евро");
                    Console.WriteLine("3 - Ввести свой курс");

                    Console.Write("Выберите валюту: ");
                    int currency = Convert.ToInt32(Console.ReadLine());

                    double kurs = 0;

                    if (currency == 1)
                        kurs = 80;

                    if (currency == 2)
                        kurs = 90;

                    if (currency == 3)
                    {
                        Console.Write("Введите курс: ");
                        kurs = Convert.ToDouble(Console.ReadLine());
                    }

                    if (kurs > 0)
                    {
                        Console.WriteLine("\n===== КОНВЕРТАЦИЯ =====");

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(names[i] + " - " + prices[i] / kurs);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                    }
                }

                if (menu == 5)
                {
                    Console.Write("\nВведите слово для поиска: ");
                    string search = Console.ReadLine();

                    bool found = false;

                    for (int i = 0; i < n; i++)
                    {
                        if (names[i].ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(names[i] + " - " + prices[i] + " руб.");
                            found = true;
                        }
                    }

                    if (found == false)
                        Console.WriteLine("Ничего не найдено.");
                }

                if (menu == 0)
                {
                    break;
                }
            }
        }
    }
}