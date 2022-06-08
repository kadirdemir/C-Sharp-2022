using System;
class Dizi_ters_cevirme_reverse_metodu_olmadan
{
    static void Main()
    {
        char [] dizi = {'a', 'b', 'c', 'd', 'e'};
        char gecici;

        for(int i = 0; i < dizi.Length/2; ++i)
        {
            gecici = dizi[i];
            dizi[i] = dizi[dizi.Length-i-1];
            dizi[dizi.Length-i-1] = gecici;
        }

        foreach (char c in dizi)
            Console.WriteLine(c);
    }
}