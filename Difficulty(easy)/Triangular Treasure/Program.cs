internal class Program
{
    public static void BasicTest()
    {
       Console.WriteLine(Compute(2));
       Console.WriteLine(Compute(3));
       Console.WriteLine(Compute(4));
       Console.WriteLine(Compute(10));
    }

    public static int Compute(int n)
    {
        if (n == 0)
            return 0;
        else
            return n + Compute(n - 1);
    }

    public static int Triangular(int n)
    {
        if (n <= 0)
            return 0;
        else
            return Compute(n);
    }

    private static void Main(string[] args)
    {
        BasicTest();
    }
}
