using System;
class Dizi_kopyalama
{
    static void Main()
    {
        int [] dizi1 = {1, 2, 3, 4, 5, 6, 7};
        int[] dizi2 = new int[10];

        //dizi1 dizi2'ye 5. indeksten 4 adet veri kopyalanıyor
        Array.Copy(dizi1, 2, dizi2, 5, 4);

        foreach(int i in dizi2)
            Console.Write(i);
    }
}