using System;

public static class ObjectiveFunction
{
    public static double Calculate(double[] pos)
    {
        double x = pos[0];
        double y = pos[1];

        double result = (4 - 2.1 * Math.Pow(x, 2) + Math.Pow(x, 4) / 3.0) * Math.Pow(x, 2)
                        + x * y
                        + (-4 + 4 * Math.Pow(y, 2)) * Math.Pow(y, 2);

        return result;
    }
}
