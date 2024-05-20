using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AddCheckDigit("036532"));
        Console.WriteLine(AddCheckDigit("12388878"));
        Console.WriteLine(AddCheckDigit("111111111"));
    }

    public static string AddCheckDigit(string number)
    {
        string checkDigit = string.Empty;
        int[] numbers = new int[number.Length];
        int[] multiplicationFactors = new int[number.Length];
        int[] multiplicationResult = new int[number.Length];
        int mf = 2;

        Regex pattern = new Regex(@"\d");
        MatchCollection match = pattern.Matches(number);

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(match[i].Value);
        }

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (mf == 8)
            {
                mf = 2;
                multiplicationFactors[i] = mf;
                mf++;
            }
            else
            {
                multiplicationFactors[i] = mf;
                mf++;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            multiplicationResult[i] = numbers[i] * multiplicationFactors[i];
        }

        int reminder = multiplicationResult.Aggregate((a, b) => a + b) % 11;

        Console.WriteLine(reminder);

        if(reminder == 0)
        {
            checkDigit = reminder.ToString();
        }
        else if(reminder == 1)
        {
            checkDigit = "X";
        }
        else
        {
            checkDigit = (11 - reminder).ToString();   
        }



        return number + checkDigit;
    }
}