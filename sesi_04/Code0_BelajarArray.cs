using System;

class Array_1
{
    static void Main()
    {
        int [] aAngka = new int[5]
        {
            1,2,3,4,5
        };
        string[] aNama = new string[] {"Bayu","Aji","Nurmansah"};
        object[] aObjek = {20.33 , "Lorem", DateTime.Now.Date, 'D'};

        for(int i = 0; i<aAngka.Length; i++)
            Console.Write(aAngka[i] + " ");
        
        Console.WriteLine();
        for(int i = 0; i<aNama.Length; i++)
            Console.Write($" {aNama[i] }");
        
        Console.WriteLine();
        for(int i = 0; i<aObjek.Length; i++)
            Console.Write($" {aObjek[i] }");
    }
}