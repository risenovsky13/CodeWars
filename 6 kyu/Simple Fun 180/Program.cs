public struct Ocurrence
{
    public int firstIndex;
    public int lastIndex;
    public char name;

    public Ocurrence(int firstIndex, int lastIndex, char name)
    {
        this.firstIndex = firstIndex;
        this.lastIndex = lastIndex;
        this.name = name;
    }
}

public class Kata
{
    public static int RepeatAdjacent(string s)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";
        string input = s;

        List<Ocurrence> ocurrencesList = new();

        for (int i = 0; i < letters.Length; i++)
        {
            if (input.Contains(letters[i]))
            {
                Ocurrence ocurrence =
                    new(input.IndexOf(letters[i]), input.LastIndexOf(letters[i]), letters[i]);
                ocurrencesList.Add(ocurrence);
            }
        }

        for (int i = 0; i < ocurrencesList.Count; i++)
        {
            if (ocurrencesList[i].firstIndex == ocurrencesList[i].lastIndex)
            {
                ocurrencesList.RemoveAt(i);
                i--;
            }
        }

        foreach (var item in ocurrencesList)
        {
            Console.WriteLine($"{item.name} => f:{item.firstIndex} l:{item.lastIndex}");
        }

        int bigGrupsCount = 0;
        for (int i = 0; i < ocurrencesList.Count; i++)
        {
            if (
                i + 1 < ocurrencesList.Count
                && ocurrencesList[i].lastIndex == ocurrencesList[i + 1].firstIndex - 1
            )
            {
                /* ...NOTE:  finished here*/
            }
        }

        //coding and coding..
        return 0;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Kata.RepeatAdjacent( /* 3 */
            "ccccoodeffffiiighhhhhhhhhhttttttts"
        );
        // Kata.RepeatAdjacent( /* 0 */
        //     "soooooldieeeeeer"
        // );
        // Kata.RepeatAdjacent( /* 1 */
        //     "ccccoooooooooooooooooooooooddee"
        // );
        // Kata.RepeatAdjacent( /* 1 */
        //     "chaaallengee"
        // );
        // Kata.RepeatAdjacent( /* 2 */
        //     "wwwwaaaarrioooorrrrr"
        // );
        // Kata.RepeatAdjacent( /* 2 */
        //     "gztxxxxxggggggggggggsssssssbbbbbeeeeeeehhhmmmmmmmitttttttlllllhkppppp"
        // );
    }
}
