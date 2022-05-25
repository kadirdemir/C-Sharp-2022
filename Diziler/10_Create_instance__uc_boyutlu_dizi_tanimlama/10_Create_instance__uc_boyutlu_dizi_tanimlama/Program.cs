using System;

class Create_instance__uc_boyutlu_dizi_tanimlama
{
    static void Main()
    {
        Array dizi = Array.CreateInstance(typeof(int), 5,4,3);

        for (int i = 0; i <= dizi.GetUpperBound(0); i++)
            for(int j = 0; j <= dizi.GetUpperBound(1); j++)
                for(int k = 0; k <= dizi.GetUpperBound(2); k++)
                    dizi.SetValue(i+j+k, i, j, k);

        for (int i = 0; i <= dizi.GetUpperBound(0); i++)
            for (int j = 0; j <= dizi.GetUpperBound(1); j++)
                for (int k = 0; k <= dizi.GetUpperBound(2); k++)
                    Console.WriteLine(dizi.GetValue(i,j,k));
    }
}