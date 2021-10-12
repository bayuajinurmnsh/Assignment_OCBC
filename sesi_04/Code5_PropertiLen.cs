using System;

public class Code5_PropertiLen
{
    public static void Main(string[] args)
    {
        int[] angka = new int[10];

        Console.WriteLine("Panjang array adalah "+angka.Length);

        for (int i = 0; i < angka.Length; i++)
            angka[i] = i * i;
        
        Console.WriteLine();
        Console.Write("Berikut adalah array angka : ");
        for(int j = 0; j<angka.Length; j++)
            Console.Write(angka[j] + " ");
        
        Console.WriteLine();
    }
}