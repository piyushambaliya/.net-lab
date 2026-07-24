using System;

interface IPayroll
{
    double CalculateSalary();
}

class Employee : IPayroll
{
    public int Id;
    public string Name;
    public double PerDaySalary;
    public int WorkingDays;

    public Employee(int id, string name, double perDaySalary, int workingDays)
    {
        Id = id;
        Name = name;
        PerDaySalary = perDaySalary;
        WorkingDays = workingDays;
    }

    public double CalculateSalary()
    {
        return PerDaySalary * WorkingDays;
    }

    public void Display()
    {
        Console.WriteLine("\nEmployee Details");
        Console.WriteLine("Employee ID : " + Id);
        Console.WriteLine("Employee Name : " + Name);
        Console.WriteLine("Per Day Salary : " + PerDaySalary);
        Console.WriteLine("Working Days : " + WorkingDays);
        Console.WriteLine("Total Salary : " + CalculateSalary());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Employee ID : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("\nSelect Employee Type");
        Console.WriteLine("1. Full Time");
        Console.WriteLine("2. Part Time");
        Console.Write("Enter Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double perDaySalary = 0;

        if (choice == 1)
        {
            perDaySalary = 2500;
        }
        else if (choice == 2)
        {
            perDaySalary = 1000;
        }
        else
        {
            Console.WriteLine("Invalid Choice");
            return;
        }

        Console.Write("Enter Working Days : ");
        int workingDays = Convert.ToInt32(Console.ReadLine());

        Employee emp = new Employee(id, name, perDaySalary, workingDays);

        emp.Display();

        Console.ReadKey();
    }
}
