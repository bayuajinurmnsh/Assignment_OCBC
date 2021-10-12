using System;

public class Code1_TampilkanArray
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4]
        {
            "Bayu", "Aji", "Nurmansah", "23 tahun"
        };

        Console.WriteLine("Menampilkan semua data di Array\n");
        
        foreach (string item in contoh)
        {
            Console.WriteLine(item);
        }
    }
}