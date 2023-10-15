using System.Collections.Generic;
using System;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {

    Dictionary<char,int> Counter = new Dictionary<char, int>();

    foreach (var item in str)
    {
        if(Counter.ContainsKey(item))
        {
            Counter[item] += 1;
        }
        else
        {
            Counter.Add(item,1);
        }
    }
    
    
    
    return Counter;
  }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char,int> kata = Kata.Count("aba");

        foreach(KeyValuePair<char,int> n in kata)
        {
            Console.Write(n);
        }
        
    }
}