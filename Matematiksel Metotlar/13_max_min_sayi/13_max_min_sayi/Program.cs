using System;

class Min_max_sayi
{
    static void Main()
    {
        Console.Write("Sayı 1 giriniz: ");
        double girilenSayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Sayı 2 giriniz: ");
        double girilenSayi2 = Convert.ToDouble(Console.ReadLine());

        double buyuk = Math.Max(girilenSayi1, girilenSayi2);
        double kucuk = Math.Min(girilenSayi1, girilenSayi2);

        Console.WriteLine("En büyük sayı: {0}", buyuk);
        Console.WriteLine("En küçük sayı: {0}", kucuk);

        Console.ReadLine();
    }
}