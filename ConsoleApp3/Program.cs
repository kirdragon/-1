using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("Хлеб", 80, 20, Category.Еда));

            while (true)
            {
                Console.WriteLine("\n Магазин:");
                Console.WriteLine("1 - Добавить товар");
                Console.WriteLine("2 - Изменить цену");
                Console.WriteLine("3 - Заказать поставку");
                Console.WriteLine("4 - Продать товар");
                Console.WriteLine("5 - Показать товары");
                Console.WriteLine("6 - Поиск товара");
                Console.WriteLine("0 - Выход");

                Console.Write("Выберите пункт: ");
                int menu;

                if (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("Ошибка! Введите число!");
                    continue;
                }
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Введите название: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите цену: ");
                        double price;
                        while (!double.TryParse(Console.ReadLine(), out price) || price<0)
                        {
                            Console.WriteLine("Ошибка! Цена не может содержать буквы или быть отрицательной: ");
                        }
                        int quantity;
                        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity<0)
                        {
                            Console.WriteLine("Ошибка! Количество не может быть нецелым, отрицательным числом или содержать буквы: ");
                        }

                        Console.WriteLine("1 - Еда");
                        Console.WriteLine("2 - Одежда");
                        Console.WriteLine("3 - Техника");

                        Console.Write("Выберите категорию: ");

                        int categoryNumber = Convert.ToInt32(Console.ReadLine());

                        Category category;

                        if (categoryNumber == 1)
                            category = Category.Еда;

                        else if (categoryNumber == 2)
                            category = Category.Одежда;

                        else
                            category = Category.Техника;    
                }
            }
        }
    }


    enum Category
    {
        Еда,
        Одежда,
        Техника
    }

    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public Category Category;

        public Product(string name, double price, int quantity, Category category)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}