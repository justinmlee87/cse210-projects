using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60;
    }

    public override double GetPace()
    {
        return length / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}