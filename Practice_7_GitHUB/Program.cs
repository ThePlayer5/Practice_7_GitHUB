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
                        Console.WriteLine($"Прогнозируемые расходы на следующий месяц: {Math.Round(PredictNextMonthExpenses(categories), 2)} руб.");
                        break;
                    case 5:
                        Console.WriteLine("Статистика расходов: ");
                        PrintStatistics(categories);
                        break;
                    case 6:
                        Console.WriteLine("Выход из программы.");
                        cycle = false;
                        break;
                }
            }

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
        public static double GetAverageExpense(Dictionary<string, List<double>> categories)
        {
            return (categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum()) /
                (categories["Продукты"].Count() + categories["Транспорт"].Count() + categories["Развлечения"].Count());
        }
        public static double PredictNextMonthExpenses(Dictionary<string, List<double>> categories)
        {
            return GetAverageExpense(categories) * 4;
        }
        public static double PrintStatistics(Dictionary<string, List<double>> categories)
        {
            Console.WriteLine($"Общая сумма расхожов: {categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum()} руб.");
            if (categories["Продукты"].Sum() > categories["Транспорт"].Sum() && categories["Продукты"].Sum() > categories["Развлечения"].Sum())
            {
                Console.WriteLine($"Самая затратнаая категория: Продукты ({categories["Продукты"].Sum()} руб.)");
            }
            else if (categories["Транспорт"].Sum() > categories["Продукты"].Sum() && categories["Транспорт"].Sum() > categories["Развлечения"].Sum())
            {
                Console.WriteLine($"Самая затратнаая категория: Транспорт ({categories["Транспорт"].Sum()} руб.)");
            }
            else Console.WriteLine($"Самая затратнаая категория: Развлечения ({categories["Развлечения"].Sum()} руб.)");

            if (categories["Продукты"].Count() > categories["Транспорт"].Count() && categories["Продукты"].Count() > categories["Развлечения"].Count())
            {
                Console.WriteLine($"Самая затратная категория: Продукты ({categories["Продукты"].Count()} операций)");
            }
            else if (categories["Транспорт"].Count() > categories["Продукты"].Count() && categories["Транспорт"].Count() > categories["Развлечения"].Count())
            {
                Console.WriteLine($"Самая затратная категория: Транспорт ({categories["Транспорт"].Count()} операций)");
            }
            else Console.WriteLine($"Самая затратная категория: Развлечения ({categories["Развлечения"].Count()} операций)");
            Console.WriteLine("Процентное распределение расходов: ");
            Console.WriteLine($"Продукты: {categories["Продукты"].Sum()} руб. ({Math.Round(categories["Продукты"].Sum() / (categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum()), 2)}%)");
            Console.WriteLine($"Транспорт: {categories["Транспорт"].Sum()} руб. ({Math.Round(categories["Транспорт"].Sum() / (categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum()), 2)}%)");
            Console.WriteLine($"Развлечения: {categories["Развлечения"].Sum()} руб. ({Math.Round(categories["Развлечения"].Sum() / (categories["Продукты"].Sum() + categories["Транспорт"].Sum() + categories["Развлечения"].Sum()), 2)}%)");
            return 0;
        }

    }
}
