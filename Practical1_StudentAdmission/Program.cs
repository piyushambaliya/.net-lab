using System;

// Class to manage student admission
class Student
{
    // Private data members
    private string name, enrollNo, course;
    private int semester;
    private double fees, scholarship;

    // Constructor
    public Student(string n, string e, string c, int s, double f, double sc)
    {
        name = n;
        enrollNo = e;
        course = c;
        semester = s;
        fees = f;
        scholarship = sc;
    }

    // Display admission details
    public void Display()
    {
        double finalFees = fees - (fees * scholarship / 100);

        Console.WriteLine("\n===== STUDENT ADMISSION DETAILS =====");
        Console.WriteLine("Name              : " + name);
        Console.WriteLine("Enrollment No     : " + enrollNo);
        Console.WriteLine("Course            : " + course);
        Console.WriteLine("Semester          : " + semester);
        Console.WriteLine("Original Fees     : Rs. " + fees);
        Console.WriteLine("Scholarship       : " + scholarship + "%");
        Console.WriteLine("Final Fees        : Rs. " + finalFees);
        Console.WriteLine("Admission Status  : ADMISSION CONFIRMED");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== STUDENT ADMISSION MANAGEMENT =====");

        Console.Write("Student Name : ");
        string name = Console.ReadLine();

        Console.Write("Enrollment No : ");
        string enroll = Console.ReadLine();

        Console.WriteLine("\nSelect Course");
        Console.WriteLine("1. Computer Engineering");
        Console.WriteLine("2. Computer Science Engineering");
        Console.WriteLine("3. Information Technology");
        Console.Write("Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        string course = (choice == 1) ? "Computer Engineering" :
                        (choice == 2) ? "Computer Science Engineering" :
                        "Information Technology";

        Console.Write("Semester : ");
        int sem = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fees : ");
        double fees = Convert.ToDouble(Console.ReadLine());

        Console.Write("Scholarship (%) : ");
        double scholarship = Convert.ToDouble(Console.ReadLine());

        if (scholarship < 0 || scholarship > 100)
            scholarship = 0;

        // Creating object
        Student student = new Student(name, enroll, course, sem, fees, scholarship);

        // Display details
        student.Display();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}