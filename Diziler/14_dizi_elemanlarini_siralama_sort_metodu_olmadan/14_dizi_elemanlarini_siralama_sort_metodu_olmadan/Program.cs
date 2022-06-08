using System;
class Dizi_elemanlarini_siralama_sort_metodu_olmadan
{
    static void Main()
    {
        int[] dizi = { 5, 2, 1, 4, 6, 0, 7 };
        int gecici, j;

        for (int i = 1; i < dizi.Length; ++i)
        {
            if (dizi[i] < dizi[i - 1])
            {
                gecici = dizi[i];
                for (j = i; j > 0 && gecici < dizi[j - 1]; --j)
                    dizi[j] = dizi[j - 1];
                dizi[j] = gecici;
            }
        }
        foreach (int i in dizi)
            Console.WriteLine(i);
    }
}