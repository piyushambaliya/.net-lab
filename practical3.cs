using System;
using System.Collections.Generic;

namespace ExpenseTracker
{
    class Expense
    {
        public string Category { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }

    class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("\n=.=.=.=.= Expense Tracker =.=.=.=.=");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddExpense();
                            break;
                        case 2:
                            ViewExpenses();
                            break;
                        case 3:
                            TotalExpense();
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric choice.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            } while (choice != 4);
        }

        static void AddExpense()
        {
            try
            {
                Expense exp = new Expense();

                Console.Write("Enter Category: ");
                exp.Category = Console.ReadLine();

                Console.Write("Enter Amount: ");
                exp.Amount = Convert.ToDouble(Console.ReadLine());

                if (exp.Amount <= 0)
                    throw new Exception("Amount must be greater than zero.");

                Console.Write("Enter Date (yyyy-mm-dd):-s ");
                exp.Date = Convert.ToDateTime(Console.ReadLine());

                expenses.Add(exp);

                Console.WriteLine("Expense added successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ViewExpenses()
        {
            try
            {
                if (expenses.Count == 0)
                    throw new Exception("No expenses found.");

                Console.WriteLine("\nCategory\tAmount\tDate");

                foreach (Expense exp in expenses)
                {
                    Console.WriteLine($"{exp.Category}\t\t{exp.Amount}\t{exp.Date.ToShortDateString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void TotalExpense()
        {
            try
            {
                double total = 0;

                foreach (Expense exp in expenses)
                {
                    total += exp.Amount;
                }

                Console.WriteLine("Total Expense: ₹" + total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
