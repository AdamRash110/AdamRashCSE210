using System;

public class KilometerToMileCoverter : MeasurementConverter
{
    public override double Convert(double value, string initialUnit, string targetUnit)
    {
        if (initialUnit != "km" || targetUnit != "mi")
            throw new ArgumentException("Invalid units for conversion");

        return value * 0.621371;
    }
}