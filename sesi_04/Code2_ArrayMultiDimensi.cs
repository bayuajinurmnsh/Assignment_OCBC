using System;

public class Code2_ArrayMultiDimensi
{
    public static void Main(string[] args)
    {
        int t, i ;
        int[,] tabel = new int[3,4];
        
        for (t = 0; t<3; ++t)
        {
            for (i = 0; i<4; ++i)
            {
                tabel[t,i] = (t * 4) + i +1;
                Console.Write(tabel[t, i] + " ");
            }
        }
    }
}