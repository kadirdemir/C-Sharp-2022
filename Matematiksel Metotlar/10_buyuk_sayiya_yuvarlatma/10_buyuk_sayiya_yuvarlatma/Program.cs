using System;
class Buyuk_tamsayiya_yuvarlatma
{
    static void Main()
    {
        //virgül kullanarak (,) ondalıklı sayı giriniz
        Console.Write("Ondalıklı bir sayı giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());
        double yuvarla = Math.Ceiling(girilenSayi);
        Console.WriteLine("Yuvarlanmış sayı: {0}", yuvarla);
        Console.ReadLine();
    }
}