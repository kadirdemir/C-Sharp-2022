using System;
class Dizinin_tum_elemanlarini_yazdirma
{
    static void Main()
    {
        int[] dizi1 = new int[10];
        bool[] dizi2 = new bool[10];
        string[] dizi3 = new string[10];

        for (int i = 0; i < 10; ++i)
        {
            Console.Write("{0,5}", dizi1[i]);
            Console.Write("{0,6}", dizi2[i]);
            //null değerlerin herhangi bir ekran çıktısı olmadığı için
            //dizi3 dizisinin elemanları ekranda görüntülenmemektedir
            Console.WriteLine("{0,5}", dizi3[i]); 
        }
    }
}