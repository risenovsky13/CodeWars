internal class Program
{
    private static void Main(string[] args)
    {
        // your text: "BORN IN 2015!", shift 1
        Console.WriteLine(playPass("MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015", 2));
    }

    public static string? playPass(string s, int n)
    {
        string userInput = s.ToUpper();
        int shiftSpaces = n;

        string shiftResult = "";

        for (int i = 0; i < userInput.Length; i++)
        {
            char currentLetter = userInput[i];

            if (Char.IsLetter(currentLetter))
            {
                currentLetter += (char)shiftSpaces;

                if (currentLetter > 90)
                {
                    int difference = (int)currentLetter - 90;
                    currentLetter = (char)(64 + difference);
                    shiftResult += currentLetter;
                }
                else
                {
                    shiftResult += currentLetter;
                }
            }
            else if (Char.IsWhiteSpace(currentLetter))
            {
                shiftResult += currentLetter;
            }
            else if (Char.IsDigit(currentLetter))
            {
                int currentDigit = 9 - int.Parse(currentLetter.ToString());
                shiftResult += currentDigit.ToString();
            }
            else
            {
                shiftResult += currentLetter;
            }

        }

        string lowerUpperResult = string.Empty;

        for (int i = 0; i < shiftResult.Length; i++)
        {

            string currentLetter = shiftResult[i].ToString();

            if (i % 2 == 0 || i == 0 && Char.IsLetter(char.Parse(currentLetter)))
            {
                currentLetter = currentLetter.ToUpper();
                lowerUpperResult += currentLetter;
            }
            else if (i % 1 == 0 || Char.IsLetter(char.Parse(currentLetter)))
            {
                currentLetter = currentLetter.ToLower();
                lowerUpperResult += currentLetter;
            }
            else
            {
                lowerUpperResult += currentLetter;
            }
        }

        char[] result = lowerUpperResult.ToCharArray();
        Array.Reverse(result);

        return new string(result);
    }

    /*

        "MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015"
        "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"

        Example:
        your text: "BORN IN 2015!", shift 1

        1 + 2 + 3 -> "CPSO JO 7984!"

        4 "CpSo jO 7984!"

        5 "!4897 Oj oSpC"

    */



}