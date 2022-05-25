using System;
class Dizinin_elemanlarini_tanimlama
{
    static void Main()
    {
        string[] dizi1 = {"Bir", "İki", "Üç"};
        int[] dizi2 = {11,22,33};
        float[] dizi3 = {1f, 2f, 3f};

        for (int i = 0; i < dizi1.Length; ++i)
        {
            Console.Write("{0,5}", dizi1[i]);
            Console.Write("{0,6}", dizi2[i]);
            Console.WriteLine("{0,5}", dizi3[i]);
        }
    }
}
