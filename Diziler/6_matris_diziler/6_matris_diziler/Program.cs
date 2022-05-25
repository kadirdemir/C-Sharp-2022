using System;

class Matris_diziler
{
    static void Main()
    {
        //3*2 boyutlu matris dizisi oluşturma
        int[,] dizi = { { 1,2 }, { 3, 4 }, { 5, 6 } };

        //İç içe for döngüsü ile matris dizisini ekrana yazdırma
        for(int i = 0; i < dizi.GetLength(0); i++)
            for(int j = 0; j < dizi.GetLength(1); j++)
                Console.WriteLine("dizi[" + i + "," + j + "] = " + dizi[i,j]);
    }
}