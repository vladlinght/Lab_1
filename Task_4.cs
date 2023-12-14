using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("User Information:");
        Console.WriteLine("Login: " + login);
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Registration Date: " + registrationDate.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter login: ");
        string login = Console.ReadLine();

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}
