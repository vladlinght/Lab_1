using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usdRate;
            case "EUR":
                return amount * eurRate;
            case "PLN":
                return amount * plnRate;
            default:
                throw new ArgumentException("Unsupported currency.");
        }
    }

    public double ConvertFromUAH(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount / usdRate;
            case "EUR":
                return amount / eurRate;
            case "PLN":
                return amount / plnRate;
            default:
                throw new ArgumentException("Unsupported currency.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter conversion rates (USD, EUR, PLN):");
        double usdRate = Convert.ToDouble(Console.ReadLine());
        double eurRate = Convert.ToDouble(Console.ReadLine());
        double plnRate = Convert.ToDouble(Console.ReadLine());

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.WriteLine("Choose operation (1 - UAH to foreign currency, 2 - Foreign currency to UAH):");
        int operation = Convert.ToInt32(Console.ReadLine());

        if (operation == 1)
        {
            Console.Write("Enter amount in UAH: ");
            double amountUAH = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter target currency (USD, EUR, PLN): ");
            string targetCurrency = Console.ReadLine();

            double convertedAmount = converter.ConvertToUAH(amountUAH, targetCurrency);
            Console.WriteLine($"Converted amount: {convertedAmount} {targetCurrency}");
        }
        else if (operation == 2)
        {
            Console.Write("Enter amount in foreign currency: ");
            double amountForeignCurrency = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter source currency (USD, EUR, PLN): ");
            string sourceCurrency = Console.ReadLine();

            double convertedAmount = converter.ConvertFromUAH(amountForeignCurrency, sourceCurrency);
            Console.WriteLine($"Converted amount: {convertedAmount} UAH");
        }
        else
        {
            Console.WriteLine("Invalid operation.");
        }

        Console.ReadLine();
    }
}
