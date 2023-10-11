using System;

class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;
        double taxRate = 0.10; // Податкова ставка 10% (можна змінити на потрібну)

        // Розрахунок окладу в залежності від посади та стажу
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "designer":
                baseSalary = 55000;
                break;
            default:
                Console.WriteLine("Invalid position.");
                return;
        }

        // Додатковий бонус для співробітників зі стажем
        if (experience >= 5)
        {
            baseSalary += 10000;
        }

        double salary = baseSalary;
        double tax = salary * taxRate;

        Console.WriteLine("Employee Information:");
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Position: " + position);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Tax: " + tax);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter position (manager/developer/designer): ");
        string position = Console.ReadLine();

        Console.Write("Enter years of experience: ");
        int experience = Convert.ToInt32(Console.ReadLine());

        Employee employee = new Employee(lastName, firstName);
        employee.CalculateSalary(position, experience);

        Console.ReadLine();
    }
}