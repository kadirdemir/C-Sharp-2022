using System;
class Sadece_pozitif_sayi_kare
{
    static void Main()
    {
        int x, kare;

    sayi_al:
        Console.Write("Sayi: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x < 0)
            goto sayi_al;

        kare = x * x;

        Console.Write("Sayı: " + x + " Karesi: " + kare);

        Console.ReadLine();
    }
                          
}