using System;
internal class Program
{
    public static bool Interlockable(ulong a, ulong b) => (a & b) == 0;
    public static void SampleTests()
    {
        Interlockable(9UL, 4UL);
        Interlockable(5UL, 6UL);
        Interlockable(2UL, 5UL);
        Interlockable(7UL, 1UL);
        Interlockable(0UL, 8UL);
    }
    public static void Main(string[] args)
    {
        SampleTests();
    }
}