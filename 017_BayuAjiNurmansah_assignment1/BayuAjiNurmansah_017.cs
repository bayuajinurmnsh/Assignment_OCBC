using System;  

public class Assign
{
    public static void Main(string[] args)
    {
        int pilihan;
        string exit;
    do{
        
        Console.WriteLine("\n=============================================");
        Console.WriteLine("=               Selamat Datang              =");
        Console.WriteLine("=                Assignment 1               =");
        Console.WriteLine("=============================================\n");
        Console.WriteLine("Nama Lengkap : Bayu Aji Nurmansah");
        Console.WriteLine("Kode Peserta : FSDO001ONL017");
        Console.WriteLine("Untuk lebih lengkap silahkan pilih menu biodata saya");
        
        Console.WriteLine("\n=============================================");
        Console.WriteLine("                      MENU                   ");
        Console.WriteLine("=============================================");
        Console.WriteLine("1. Soal Nomor 1");
        Console.WriteLine("2. Soal Nomor 2");
        Console.WriteLine("3. Soal Nomor 3");
        Console.WriteLine("4. Soal Nomor 4");
        Console.WriteLine("5. Soal Nomor 5");
        Console.WriteLine("6. Soal Nomor 6");
        Console.WriteLine("7. Biodata saya\n");
        Console.Write("Silahlan pilih nomor menu 1 sampai 7 : ");
        pilihan = int.Parse(Console.ReadLine());

        while (pilihan > 7 || pilihan < 1 )
        {
            Console.Write("Silahlan pilih nomor menu 1 sampai 7 : ");
            pilihan = int.Parse(Console.ReadLine());
        }

        switch (pilihan)
            {
                case 1:{
                    
                    char huruf='A';
                    int i, perulangan, j, huruf_urut, reverse_huruf; 

                    Console.Write("Masukkan total perulangan Segitiga Huruf: ");
                    perulangan = int.Parse(Console.ReadLine());


                    for(i=1; i<=perulangan; i++)      
                    {      
                        for(j=perulangan-1; j>=i; j--)
                        {
                            Console.Write(" ");      
                        }
                        
                        for(huruf_urut=1;huruf_urut<=i;huruf_urut++)
                        {
                            Console.Write(huruf);
                            huruf++;
                        }

                        huruf--;
                        for(reverse_huruf=1;reverse_huruf<i;reverse_huruf++)      
                        {
                            Console.Write(--huruf);      
                        }
                        
                        Console.Write("\n");
                    }

                    break;
                }//case1
                case 2:{
                    int angka=1;
                    int i, perulangan, j, huruf_urut, reverse_huruf; 

                    Console.Write("Masukkan total perulangan Segitiga Angka: ");
                    perulangan = int.Parse(Console.ReadLine());


                    for(i=1; i<=perulangan; i++)      
                    {      
                        for(j=perulangan-1; j>=i; j--)
                        {
                            Console.Write(" ");      
                        }
                        
                        for(huruf_urut=1;huruf_urut<=i;huruf_urut++)
                        {
                            Console.Write(angka);
                            angka++;
                        }

                        angka--;
                        for(reverse_huruf=1;reverse_huruf<i;reverse_huruf++)      
                        {
                            Console.Write(--angka);      
                        }
                        
                        Console.Write("\n");
                    }
                    break;
                }//case2
                case 3:{
                    int i, total, range; 
                    Console.Write("Masukkan Range : ");
                    range = int.Parse(Console.ReadLine());

                    total = 1;

                    for(i=1; i<= range; i++ )
                    {
                        total = total*i;
                    }

                    Console.WriteLine($"Hasil dari Faktorial {range}! = {total}");
                    break;
                }
                case 4:{
                    string str, str1 = ""; 
                    int i,l;			

                    Console.Write("Masukkan String : ");
                    str = Console.ReadLine();

                    l = str.Length-1;
                    for (i=l;i>=0;i--)
                    {
                        str1 = str1 + str[i];
                    }

                    Console.WriteLine("Reverse String : {0}", str1);
                    Console.Write("\n");
                    break;
                }
                case 5:{
                    string input;
                    char[] arrInput;
                    int converToInt;
                    int len;

                    Console.Write("Masukkan input : ");
                    input = Console.ReadLine();

                    arrInput = input.ToCharArray();
                    
                    len = arrInput.Length;
                    for (int i=0; i<len; i++)
                    {   
                        converToInt = (int)Char.GetNumericValue(arrInput[i]);
                        if (converToInt == 0) Console.Write("Zero ");
                        if (converToInt == 1) Console.Write("One ");
                        if (converToInt == 2) Console.Write("Two ");
                        if (converToInt == 3) Console.Write("Three ");
                        if (converToInt == 4) Console.Write("Four ");
                        if (converToInt == 5) Console.Write("Five ");
                        if (converToInt == 6) Console.Write("Six ");
                        if (converToInt == 7) Console.Write("Seven ");
                        if (converToInt == 8) Console.Write("Eight ");
                        if (converToInt == 9) Console.Write("Nine ");
                    }
                    break;
                }
                case 6:{
                    string str, str1 = ""; 
                    int i,l;			

                    Console.Write("Masukkan String (Katak) : ");
                    str = Console.ReadLine();

                    l = str.Length-1;
                    for (i=l;i>=0;i--)
                    {
                        str1 = str1 + str[i];
                    }

                    Console.WriteLine("Hasil : {0}", str1);
                    if (str1 == str)
                        Console.WriteLine("Ini palindrom\n");
                    else
                        Console.WriteLine("Ini Bukan palindrom\n");
                    break;
                }
                case 7:{
                    Console.WriteLine("Halo, Perkenalkan saya adalah ");
                    Console.WriteLine("Nama                 : Bayu Aji Nurmansah ");
                    Console.WriteLine("Kode Peserta         : FSDO001ONL017");
                    Console.WriteLine("Alamat               : Medan ");
                    Console.WriteLine("Umur                 : 23 tahun ");
                    Console.WriteLine("Alumni               : Universitas Sumatera Utara ");
                    Console.WriteLine("Bahasa Pemrograman   : Python, PHP, C#, C++, Java, Python-Flask, PHP-CI, Machine Learning");
                    break;
                }
                default:{
                    Console.Write("Pilihan salah !");
                    break;
                }
            }
        
        Console.Write("\nIngin kembali ke menu awal ? (y/n)");
        exit = Console.ReadLine();
        exit = exit.ToLower();
        Console.Clear();
    }//do
    while(exit == "y");
    
    }
}