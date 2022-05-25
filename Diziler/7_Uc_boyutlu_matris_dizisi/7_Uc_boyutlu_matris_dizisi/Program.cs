using System;

class Uc_boyutlu_matris_diziler
{
    static void Main()
    {
        //3 boyutlu matris dizisi oluşturma
        int[,,] dizi = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

        //İç içe geçmiş 3 tane for döngüsü ile matris dizisini ekrana yazdırma
        for (int i = 0; i < dizi.GetLength(0); i++)
            for (int j = 0; j < dizi.GetLength(1); j++)
                for (int k = 0; k < dizi.GetLength(2); k++)
                Console.WriteLine("dizi[" + i + "," + j + "," + k + "] = " + dizi[i, j, k]);
    }
}