internal class Program
{
    public void BasicTest()
    {
        GiveChange(365);
        GiveChange(217);
    }

    public static int[] GiveChange(int amount)
    {
        int[] banknotes = { 1, 5, 10, 20, 50, 100 };
        int[] bills = new int[6];

        for (int i = bills.Length - 1; i >= 0; i--)
        {
            bills[i] = amount / banknotes[i];
            amount = amount - (banknotes[i] * bills[i]);
        }
        return bills;
    }

    private static void Main(string[] args)
    {
        Program test = new Program();
        test.BasicTest();
    }
}
