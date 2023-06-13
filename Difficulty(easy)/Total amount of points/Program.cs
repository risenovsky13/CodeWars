public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int pointsEarned = 0;
        foreach (var score in games)
        {
            if ((int)score[0] > (int)score[2]){
                pointsEarned += 3;
            }
            else if ((int)score[0] == (int)score[2]){
                pointsEarned += 1;
            }
            else{
                continue;
            }
        }
        return pointsEarned;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("expected 30 => " + TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" })); 
        Console.WriteLine("expected 10 => " + TotalPoints(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" })); 
        Console.WriteLine("expected 0 => "  + TotalPoints(new[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }));
        Console.WriteLine("expected 15 => " + TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" })); 
    }
}
