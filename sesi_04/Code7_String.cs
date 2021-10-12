using System;

public class String_Code7
{
    static void Main(string[] args)
    {
        char[] arrChar = { '1', ' ', 's', 't', 'r', 'i', 'n', 'g', '.',};
        string str1 = new string(arrChar);
        string str2 = "String lain.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}