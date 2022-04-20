using System;
class Sayac_degeri_kaydetme
{
    static void Main()
    {
        int sayi, sayac = 0;

    oku_sayi:
        Console.Write("Sayı giriniz: ");
        sayi = Convert.ToInt32(Console.ReadLine());

        sayac = sayac + 1;

        if (sayi == 5)
            Console.Write("Sayaç= " + sayac);
        else
            goto oku_sayi;

            Console.ReadLine();
    }
}