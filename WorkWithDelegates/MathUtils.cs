namespace WorkWithDelegates;

public static class MathUtils
{
    // public delegate double F(double x);

    public static double Trapz(Func<double, double> f, double a, double b, int N = 1000)
    {
        var res = 0.0;
        var dx = (b - a) / (N - 1);
        var x = a;
        while (x <= b)
        {
            res += f(x) * dx;
            x += dx;
        }

        res += -f(a) * dx / 2 - f(b) * dx / 2;

        return res;
    }

    public static void Say(Action<string> sayMethod, string name)
    {
        Console.WriteLine("We are here");
        sayMethod?.Invoke(name);
    }
}