using System;
using System.Globalization;

class DataTypesLab
{
    public static string FormatCurrency(double amount)
    {
        return amount.ToString("C", CultureInfo.CreateSpecificCulture("en-IN"));
    }

    public static string FormatDate(DateTime date)
    {
        return date.ToString("dd MMM yyyy");
    }

    public static bool ParseBool(string input)
    {
        return bool.TryParse(input, out bool result) ? result : false;
    }

    public static DateTime? ParseDate(string input)
    {
        return DateTime.TryParse(input, out DateTime result) ? result : null;
    }

    public static double? ParseDouble(string input)
    {
        return double.TryParse(input, out double result) ? result : null;
    }

    public static int SafeLength(string? input)
    {
        return input?.Length ?? 0;
    }

    public static string SafeString(string? input, string defaultValue = "N/A")
    {
        return input ?? defaultValue;
    }

    static void Main()
    {
        Console.WriteLine(" Welcome to DataTypesLab ");

        Console.Write("Enter an amount to format as currency: ");
        string amountInput = Console.ReadLine();
        double? amount = ParseDouble(amountInput);
        Console.WriteLine("Formatted Currency: " + (amount.HasValue ? FormatCurrency(amount.Value) : "Invalid amount"));

        Console.Write("Enter a date (e.g., 2025-09-23): ");
        string dateInput = Console.ReadLine();
        DateTime? date = ParseDate(dateInput);
        Console.WriteLine("Formatted Date: " + (date.HasValue ? FormatDate(date.Value) : "Invalid date"));


        Console.Write("Enter a boolean value (true/false): ");
        string boolInput = Console.ReadLine();
        Console.WriteLine("Parsed Boolean: " + ParseBool(boolInput));

        Console.Write("Enter a string to check its length (or leave blank): ");
        string? strInput = Console.ReadLine();
        Console.WriteLine("Safe Length: " + SafeLength(strInput));

        Console.Write("Enter a string (or leave blank to use default): ");
        string? strDefault = Console.ReadLine();
        Console.WriteLine("Safe String: " + SafeString(strDefault));
    }
}
