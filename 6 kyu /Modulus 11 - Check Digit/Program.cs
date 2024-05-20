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

        Regex pattern = new Regex(@"\d");
        MatchCollection match = pattern.Matches(number);

        foreach (var item in match)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");

        
        
        
        
        
        

        return number + checkDigit;
    }
}