using System;
class Ekrandan_belli_adet_sayi_alma
{
    static void Main()
    {
        int adet, sayi, top = 0, sayac = 0;

        Console.Write("Adet: ");
        adet =Convert.ToInt32(Console.ReadLine());

    oku:
        Console.Write("Sayı Gir: ");
        sayi =Convert.ToInt32(Console.ReadLine());

        sayac = sayac + 1;

        top = top + sayi;

        if (sayac < adet)
            goto oku;
        else
            Console.WriteLine("toplam" + top);
        Console.ReadLine();
    }
}