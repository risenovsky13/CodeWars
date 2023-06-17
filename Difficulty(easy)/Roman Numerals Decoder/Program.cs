using System;
using System.Collections.Generic;
internal class Program
{
    public static void Test()
    {
        Console.WriteLine(Solution("XXI"));
        Console.WriteLine(Solution("LXXX"));
        Console.WriteLine(Solution("XC"));
        Console.WriteLine(Solution("XL"));
    }
    public static int ConvertRomanToInt(string roman)
    {
        int numeral = 0;
        Dictionary<char, int> RomanAndNumeral = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        for (int i = 0; i < roman.Length; i++)
        {
            char currentChar = roman[i];
            RomanAndNumeral.TryGetValue(roman[i], out int num);
            if (i + 1 < roman.Length && RomanAndNumeral[roman[i+1]] > RomanAndNumeral[currentChar])
            {
                numeral -= num;
            }
            else
            {
                numeral += num;
            }
        }
        return numeral;
    }
    public static int Solution(string s)
    {
        int numeral = ConvertRomanToInt(s);
        return numeral;
    }
    public static void Main(string[] args)
    {
        Test();
    }
}