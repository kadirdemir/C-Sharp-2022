using System;

class Isleapyear_artik_yil
{
    static void Main()
    {
        Console.Write("Hesaplanacak yıl bilgisi giriniz: ");
        int tarih = Convert.ToInt32(Console.ReadLine());
        bool hesapla = DateTime.IsLeapYear(tarih);
        if (hesapla)
            Console.WriteLine("Verilen tarihte Şubat ayı 29 gündür");
        else
            Console.WriteLine("Verilen tarihte Şubat ayı 28 gündür");
        Console.ReadLine();
    }
}