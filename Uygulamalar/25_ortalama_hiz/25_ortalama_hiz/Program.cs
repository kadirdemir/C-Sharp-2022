using System;

class Hiz_donusumu
{
    static void Main()
    {
        const int uzaklik = 453;
        double saat, hiz;

        Console.Write("Kaç saatte gittiğinizi giriniz: ");
        saat = Convert.ToDouble(Console.ReadLine());

        hiz = uzaklik / saat;

        Console.Write("Arabanın ortalama hızı: " + hiz);

        Console.ReadLine();


    }
}