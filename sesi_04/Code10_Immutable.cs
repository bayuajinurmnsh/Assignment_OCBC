using System;

class string3 
{
    static void Main()
    {
        string strAwal = "C# membuat string mudah.";

        string substr = strAwal.Substring(5, 12);

        Console.WriteLine($"stringawal : {strAwal}");
        Console.WriteLine($"substring : {substr}");
    }
}