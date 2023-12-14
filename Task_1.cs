using System;

class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public void DisplayAddress()
    {
        Console.WriteLine("Index: " + Index);
        Console.WriteLine("Country: " + Country);
        Console.WriteLine("City: " + City);
        Console.WriteLine("Street: " + Street);
        Console.WriteLine("House: " + House);
        Console.WriteLine("Apartment: " + Apartment);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address();
        myAddress.Index = "42001";
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Main Street";
        myAddress.House = "321";
        myAddress.Apartment = "56";

        Console.WriteLine("My Address:");
        myAddress.DisplayAddress();

        Console.ReadLine();
    }
}
