using static System.Console;

WriteLine(Calculator.AddValues(2, 3));           // int + int
WriteLine(Calculator.AddValues(2.0f, 3.0f));     // float + float
WriteLine(Calculator.AddValues(2L, 3L));         // long + long

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    public static float AddValues(float c, float d)
    {
        WriteLine("Calculated by method: public static float AddValues(float c, float d)");
        return c + d;
    }

    public static long AddValues(long f, long g)
    {
        WriteLine("Calculated by method: public static long AddValues(long f, long g)");
        return f + g;
    }

    public static double AddValues(double h, double i)
    {
        WriteLine("Calculated by method: public static double AddValues(double h, double i)");
        return h + i;
    }
}
