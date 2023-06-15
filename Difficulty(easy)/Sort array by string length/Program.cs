internal class Program
{
    /*
        Method uses bubble sort method.
        in next attempt i will use a recursion
        in order to make it faster    
    */
    public static string[] SortByLength(string[] array)
    {
        string[] arrayCopy = array;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (arrayCopy[i].Length < arrayCopy[j].Length)
                {
                    string buffor = arrayCopy[i];
                    arrayCopy[i] = array[j];
                    array[j] = buffor;
                }
            }
        }

        return arrayCopy;
    }

    public static void ExampleTests()
    {
        Display(SortByLength(new string[] { "Beg", "Life", "I", "To" }));
        Display(SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
        Display(SortByLength(new string[] { "Longer", "Longest", "Short" }));
    }

    public static void Display(string[] array)
    {
        foreach (var s in array)
        {
            Console.Write(s + ",");
        }

        Console.WriteLine();
    }

    public static void MyTests()
    {
        string[] txt = { "Beg", "Life", "I", "To" };
        string[] wtf = txt;

        for (int i = 0; i < txt.Length; i++)
        {
            for (int j = 0; j < txt.Length; j++)
            {
                if (wtf[i].Length < txt[j].Length)
                {
                    string buffor = wtf[i];
                    wtf[i] = txt[j];
                    txt[j] = buffor;
                }
            }
        }
        foreach (var item in wtf)
        {
            Console.Write(item + " ");
        }
    }

    private static void Main(string[] args)
    {
        // MyTests();
        ExampleTests();
    }
}
