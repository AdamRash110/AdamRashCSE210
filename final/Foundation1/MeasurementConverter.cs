using System;

public abstract class MeasurementConverter
{
    public abstract double Convert(double value, string initialUnit, string targetUnit);
}