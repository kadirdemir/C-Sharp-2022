using System;

class Dizi_random_deger_grafik_olusturma
{
    static void Main()
    {
        //Rastgele sayı üretmek için random sınıfı türünden bir nesne tanımlanıyor
        //100 elemanlı bir dizi oluşturuluyor
        Random rnd = new();
        int[] RastGeleDizi = new int[100];

        //100 elemanlı dizi 1-10 arası sayılarla rastgele dolduruluyor
        for (int i = 0; i < 100; ++i)
            RastGeleDizi[i] = rnd.Next(1, 11);

        //10 elemanlı bir dizi oluşturuluyor
        int[] adet = new int[10];

        //her bir sayının kaç adet üretildiğini tutan dizinin elemanları hesaplanıyor
        //adet dizisinin 1. elemanının sayısı üretilen 1'lerin, 2. elemanının sayısı üretilen 2'lerin sayısını veriyor
        for (int i = 0; i < 100; ++i)
            adet[RastGeleDizi[i] - 1]++;

        //İç içe iki for döngüsü ile her bulunan sayı kadar ekrana yıldız karakteri yazdırılıyor
        //Her bir satır yazıldıktan sonra bir alt satıra geçiliyor
        for (int i = 0; i < 10; ++i)
        {
            Console.Write("{0,2} Adet {1,2}-->", adet[i], i+1);
            for(int j = 0; j < adet[i]; ++j)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}