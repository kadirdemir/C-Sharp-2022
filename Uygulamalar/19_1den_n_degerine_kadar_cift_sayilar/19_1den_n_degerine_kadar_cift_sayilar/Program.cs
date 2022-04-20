using System;
class Birden_n_degerine_kadar_cift_sayilar
{
    static void Main()
    {
        int n, s = 0;

        Console.Write("n değeri: ");
        n = Convert.ToInt32(Console.ReadLine());

    sayac_artirma:
        s = s + 2;

        Console.WriteLine(s);

        if (s < n-1) goto sayac_artirma;

        Console.ReadLine();

    }
}