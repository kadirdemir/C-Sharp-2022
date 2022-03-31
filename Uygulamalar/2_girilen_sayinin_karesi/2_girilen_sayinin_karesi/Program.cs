using System;

class girilen_sayinin_karesi
{
    static void Main()
    {
        int sayi, kare;

        Console.WriteLine("Sayı gir:");

        sayi = Convert.ToInt32(Console.ReadLine());

        kare = sayi * sayi;

        Console.Write(("Sayının karesi:" + kare));

        Console.Read();
    }
}