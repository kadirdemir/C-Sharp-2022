using System;
class If_deyimi4
{
    static void Main()
    {
        int sayi1, sayi2;
        string islem;

        Console.Write("Birinci sayıyı giriniz: ");
        sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nToplama---> t");
        Console.WriteLine("\nÇıkarma---> c");
        Console.WriteLine("\nÇarpma---> m");
        Console.WriteLine("\nBölme---> b");

        Console.WriteLine("İşleminizi seçiniz: ");
        islem = Console.ReadLine();

        //bolme isleminin kontrolu yapılıyor. bir sayiyi 0'a bolmek anlamsizdir.
        if (islem == "b")
            if (sayi2 != 0)
            {
                float sonuc = (float)sayi1 / (float)sayi2;
                Console.WriteLine("Sonuç: {0}", sonuc);
            }
            else
                Console.WriteLine("Bölen sıfır olamaz");
        else if (islem == "t")
            Console.WriteLine("Sonuç: {0}", sayi1 + sayi2);
        else if (islem == "m")
            Console.WriteLine("Sonuç: {0}", sayi1 * sayi2);
        else
            Console.WriteLine("Sonuç: {0}", sayi1 - sayi2);

    }
}