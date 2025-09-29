using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class UnitConverterCLI
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Unit Converter");
                Console.WriteLine("1. Length (meters -> kilometers)");
                Console.WriteLine("2. Temperature (Celsius -> Fahrenheit)");
                Console.WriteLine("3. Weight (kilograms -> pounds)");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertLength();
                        break;
                    case "2":
                        ConvertTemperature();
                        break;
                    case "3":
                        ConvertWeight();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ConvertLength()
        {
            Console.Write("Enter meters: ");
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine($"{meters} meters = {kilometers} kilometers");
            Console.ReadLine();
        }

        static void ConvertTemperature()
        {
            Console.Write("Enter Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            Console.ReadLine();
        }

        static void ConvertWeight()
        {
            Console.Write("Enter kilograms: ");
            double kg = double.Parse(Console.ReadLine());
            double pounds = kg * 2.20462;
            Console.WriteLine($"{kg} kg = {pounds} lbs");
            Console.ReadLine();
        }
    }

}
