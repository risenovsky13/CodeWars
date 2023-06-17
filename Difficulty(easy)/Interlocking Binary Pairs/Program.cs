using System;
internal class Program
{

    public static char[] ReverseBinaryArray(char[] binaryCharArray)
    {
        string reversed = "";

        for (int i = binaryCharArray.Length - 1; i >= 0; i--)
        {
            reversed += binaryCharArray[i];
        }
        char[] reversedToArray = reversed.ToCharArray();

        return reversedToArray;
    }

    public static char[] GetBinaryCode(ulong n)
    {
        string binary = Convert.ToString((int)n, 2);
        char[] binaryArray = binary.ToCharArray();

        return binaryArray;
    }
    public static void SampleTests()
    {
        Interlockable(9UL, 4UL);
        Interlockable(5UL, 6UL);
        Interlockable(2UL, 5UL);
        Interlockable(7UL, 1UL);
        Interlockable(0UL, 8UL);
    }

    public static bool Compare(char[] a, char[] b)
    {
        if (a.Length < b.Length)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1' && b[i] == '1')
                {
                    return false;
                }
            }
        }
        else
        {
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i] == '1' && b[i] == '1')
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static bool Interlockable(ulong a, ulong b)
    {
        char[] binary_A = GetBinaryCode(a);
        char[] binary_B = GetBinaryCode(b);

        binary_A = ReverseBinaryArray(binary_A);
        binary_B = ReverseBinaryArray(binary_B);

        return Compare(binary_A, binary_B);
    }
    public static void Main(string[] args)
    {
        SampleTests();
    }
}