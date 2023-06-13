public class Kata {
  public static int SameCase(char a, char b)
    {
       if (char.IsLetter(a) && char.IsLetter(b))
        {
            if (char.IsUpper(a) && char.IsUpper(b)) {return 1;}
            else if (char.IsLower(a) && char.IsLower(b)) {return 1;}
            else {return 0;}
        }
        return -1;
    }
}