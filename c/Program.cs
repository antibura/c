using System;
using System.IO;

namespace first_c_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("Data");
            if (di.Exists)
                di.Delete(true);

            di.Create();

            StreamWriter sw = File.CreateText("Data/Money.txt");

            // Приветствие пользователя
            Console.WriteLine("Hello!");

            // Ввод доходов
            int debitSum = 0;
            int debitInt = 0;

            for (int i = 0; i < 10; i++)
            {
                string debit = "";
                Console.Write("Enter income: ");
                debit = Console.ReadLine();

                int.TryParse(debit, out debitInt);

                debitSum += debitInt;
            }

            // Вывод суммарного дохода
            sw.WriteLine("Your debit is " + debitSum.ToString());
            sw.WriteLine();

            // Ввод расходов
            int creditSum = 0;
            int creditInt = 0;

            for (int i = 0; i < 10; i++)
            {
                string credit = "";
                Console.Write("Enter output: ");
                credit = Console.ReadLine();

                int.TryParse(credit, out creditInt);

                creditSum += creditInt;

            }

            // Вывод суммарного расхода
            sw.WriteLine("Your output is " + creditSum.ToString());
            sw.WriteLine();

            /* 
             * Перевод дохода и расхода
             * Подсчёт баланса
             */
            int balance = debitSum - creditSum;
            Console.WriteLine("Your balance is " + balance.ToString());

            if (balance > 0)
            {
                Console.WriteLine("You are great!");
            }
            else
            {
                Console.WriteLine("Poor boy...");
            }

            switch (balance > 10)
            {
                case true:
                    Console.WriteLine("Amazing");
                    break;
                default:
                    Console.WriteLine("Be better");
                    break;
            }

            string text = "Hello, your debit is {0}, credit is {1} and balance is {2}";
            string x = String.Format(text, debitSum, creditSum, balance);
            Console.WriteLine(x);

            sw.Close();

            Console.ReadKey();



        }
    }
}