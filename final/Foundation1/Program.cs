using System;

public class Program
{
    static void Main()
    {
        var kmToMiConverter = new KilometerToMileCoverter();
        var lbToKgCoverter = new PoundToKilogramCoverter();

        Console.Write("Enter value to convert: ");
        double value = double.Parse(Console.ReadLine());

        Console.Write("Enter initial unit of measurement: ");
        string initialUnit = Console.ReadLine();

        Console.Write("Enter target unit of measurement: ");
        string targetUnit = Console.ReadLine();

        double convertedValue = 0;

        try
        {
            if (initialUnit == targetUnit)
            {
                convertedValue = value;
            }

            else if (initialUnit == "km" && targetUnit == "mi")
            {
                convertedValue = kmToMiConverter.Convert(value, initialUnit, targetUnit);
            }

            else if (initialUnit == "lb" && targetUnit == "kg")
            {
                convertedValue = lbToKgCoverter.Convert(value, initialUnit, targetUnit);
            }

            else
            {
                throw new ArgumentException("Invalid units for conversion");
            }

            Console.WriteLine("{0} {1} = {2} {3}", value, initialUnit, convertedValue, targetUnit);
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error occured: {0}", ex.Message);
        }

        Console.ReadKey();
    }
}