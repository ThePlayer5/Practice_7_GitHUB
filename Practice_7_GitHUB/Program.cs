using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_GitHUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> categories = new Dictionary<string, List<double>>()
            {
                {"Доход", new List<double>() },
                {"Продукты", new List<double>() },
                {"Транспорт", new List<double>() },
                {"Развлечения", new List<double>() }
            };
            double x = 0;
            bool cycle = true;
            Console.WriteLine("Добро пожаловать в систему управления финансами!");
            while (cycle)
            {
                Console.WriteLine("\n1. Добавить доход/расход  \n2. Показать отчет  \n3. Рассчитать баланс  \n4. Прогноз на следующий месяц  \n5. Статистика\n6. Выход  \n");
                Console.Write("\nВыберите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.Write("Введите категорию (Доход, Продукты, Транспорт, Развлечения): ");
                        string category = Console.ReadLine();
                        Console.Write("Введите сумму: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        AddTransaction(x, category, categories);
                        Console.WriteLine("Запись добавлена.");
                        break;
                    case 2:
                        Console.WriteLine("Финансовый отчёт:");
                        PrintFinanceReport(categories);
                        break;
                    case 3:
                        Console.WriteLine($"Текущий баланс: {CalculateBalance(categories)}");
                        break;
                    case 4:
                        Console.WriteLine(4);
                        break;
                    case 5:
                        Console.WriteLine(5);
                        break;
                    case 6:
                        Console.WriteLine("Выход из программы.");
                        cycle = false;
                        break;
                }
            }
            //foreach (var sum in categories["Доход"])
            //{
            //    Console.WriteLine(sum);
            //}

            Console.ReadKey();
        }
        public static double AddTransaction(double x, string category, Dictionary<string, List<double>> categories)
        {
            categories[category].Add(x);
            return x;
        }
        public static Dictionary<string, List<double>> PrintFinanceReport(Dictionary<string, List<double>> categories)
        {
            if (categories["Доход"].Count() != 0)
            {
                Console.WriteLine($"Доход: {categories["Доход"].Sum()} руб. - {categories["Доход"].Count()} операций");
            }
            if (categories["Продукты"].Count() != 0)
            {
                Console.WriteLine($"Продукты: {categories["Продукты"].Sum()} руб. - {categories["Продукты"].Count()} операций");
            }
            if (categories["Транспорт"].Count() != 0)
            {
                Console.WriteLine($"Транспорт: {categories["Транспорт"].Sum()} руб. - {categories["Транспорт"].Count()} операций");
            }
            if (categories["Развлечения"].Count() != 0)
            {
                Console.WriteLine($"Развлечения: {categories["Развлечения"].Sum()} руб. - {categories["Развлечения"].Count()} операций");
            }
            return categories;
        }
        public static double CalculateBalance(Dictionary<string, List<double>> categories)
        {
            return categories["Доход"].Sum() - (categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum());
        }
    }
}
