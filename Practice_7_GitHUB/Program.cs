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
            List<double> list = new List<double>();
            Dictionary<string, List<double>> categories = new Dictionary<string, List<double>>()
            {
                {"Доход", null },
                {"Продукты", null },
                {"Транспорт", null },
                {"Развлечения", null }
            };
            Console.WriteLine("Добро пожаловать в систему управления финансами!");
            Console.WriteLine("\n1. Добавить доход/расход  \n2. Показать отчет  \n3. Рассчитать баланс  \n4. Прогноз на следующий месяц  \n5. Статистика\n6. Выход  \n");
            Console.Write("\nВыберите действие: ");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите категорию (Доход, Продукты, Транспорт, Развлечения): ");
            string str = Console.ReadLine();
            Console.Write("Введите сумму: ");
            double x = Convert.ToInt32(Console.ReadLine());
            switch (str)
            {
                case "Доход":
                    categories["Доход"] = list.Add(x);
                    break;
                case "Продукты":
                    break;
                case "Транспорт":
                    break;
                case "Развлечения":
                    break;
            }
            Console.WriteLine();

            Console.ReadKey();
        }
        public static int AddTransaction(double x)
        {
            
            return x;
        }
    }
}
