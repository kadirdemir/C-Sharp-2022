using System;
class Diziye_ait_ortalama_min_mak_deger_bulma
{
    static void Main()
    {
        int[] dizi = new int[20];
        Random rnd = new();

        int max = 0, min = 100, toplam = 0;

        for(int i = 0; i < dizi.Length; ++i)
        {
            dizi[i] = rnd.Next(0,100);

            if(dizi[i] > max)
                max = dizi[i];
            if(dizi[i] < min)
                min = dizi[i];
            toplam += dizi[i];
        }

        foreach (int i in dizi)
            Console.Write(i+" ");

        Console.WriteLine("\nEn büyük: {0}", max);
        Console.WriteLine("En küçük: {0}", min);

        Console.WriteLine("Ortalama: {0}", (float)toplam/(float)dizi.Length);
    }
}