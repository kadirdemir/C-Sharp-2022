using System;

class Duzensiz_dizi_olusturma
{
    static void Main()
    {
        int[][] dizi = new int[3][];

        dizi[0] = new int[] { 1, 2, 3 };
        dizi[1] = new int[] { 4, 5, 6, 7 };
        dizi[2] = new int[] { 8, 9};

        for (int i = 0; i < dizi.GetLength(0); ++i)
            for (int j = 0; j < dizi[i].GetLength(0); ++j)
                Console.WriteLine("dizi[{0}][{1}]={2}", i, j, dizi[i][j]);
    }
}