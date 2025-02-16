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
            Console.WriteLine("Добро пожаловать в систему управления финансами!");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n1. Добавить доход/расход  \n2. Показать отчет  \n3. Рассчитать баланс  \n4. Прогноз на следующий месяц  \n5. Статистика\n6. Выход  \n");
                Console.Write("\nВыберите действие: ");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите категорию (Доход, Продукты, Транспорт, Развлечения): ");
                string category = Console.ReadLine();
                Console.Write("Введите сумму: ");
                double x = Convert.ToDouble(Console.ReadLine());
                AddTransaction(x, category, categories);
                Console.WriteLine("Запись добавлена.");
                //switch (category)
                //{
                //    case "Доход":
                //        AddTransaction(x, category, categories);
                //        Console.WriteLine("Запись добавлена.");
                //        break;
                //    case "Продукты":
                //        break;
                //    case "Транспорт":
                //        break;
                //    case "Развлечения":
                //        break;
                //}
            }
            foreach (var sum in categories["Доход"])
            {
                Console.WriteLine(sum);
            }

            foreach (var sum in categories["Продукты"])
            {
                Console.WriteLine(sum);
            }
            foreach (var sum in categories["Транспорт"])
            {
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
        public static double AddTransaction(double x, string category, Dictionary<string, List<double>> categories)
        {
            categories[category].Add(x);
            return x;
        }
    }
}
