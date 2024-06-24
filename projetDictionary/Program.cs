using System;

class MainProgram
{
    public static void Main(string[] args)
    {
        Dictionary<char,string> dic = new Dictionary<char,string>();
        dic['a'] = "alphabet";
        dic['b'] = "balade";
        dic['c'] = "croisade";

        dic.Remove('c');

        foreach (char c in dic.Keys)
        {
            Console.WriteLine(c);
        }

    }
}

