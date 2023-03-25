using System;

public class PoundToKilogramCoverter : MeasurementConverter
{
    public override double Convert(double value, string initialUnit, string targetUnit)
    {
        if (initialUnit != "lb" || targetUnit != "kg")
            throw new ArgumentException("Invalid units for conversion");

        return value * 0.453592;
    }
}