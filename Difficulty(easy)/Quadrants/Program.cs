public static class Kata
{
    public static int Quadrant(int x, int y)
    {
        int quadrantValue;

        if (x > 0 && y > 0)
        {
            quadrantValue = 1;
        }
        else if (x < 0 && y > 0)
        {
            quadrantValue = 2;
        }
        else if (x < 0 && y < 0)
        {
            quadrantValue = 3;
        }
        else
        {
            quadrantValue = 4;
        }

        return quadrantValue;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(Quadrant(1, 2));
        Console.WriteLine(Quadrant(3, 5));
        Console.WriteLine(Quadrant(-10, 100));
        Console.WriteLine(Quadrant(-1, -9));
        Console.WriteLine(Quadrant(19, -56));
        Console.WriteLine(Quadrant(1, 1));
        Console.WriteLine(Quadrant(-60, -12));
    }
}
