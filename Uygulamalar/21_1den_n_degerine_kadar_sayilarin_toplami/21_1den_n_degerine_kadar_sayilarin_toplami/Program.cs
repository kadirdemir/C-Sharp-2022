using System;
class Birden_n_degerine_kadar_sayilarin_toplami
{
    static void Main()
    {
        int top=0, s=0, n;

        Console.Write("n:");
        n = Convert.ToInt32(Console.ReadLine());

    sayac_artirma:
        s = s + 1;
        top = top + s;

        if (s < n)
            goto sayac_artirma;
        else
            Console.WriteLine("Toplam= " + top);
        Console.ReadLine();
    }
}