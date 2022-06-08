using System;
class Sayi_isareti
{
    static void Main()
    {
        Console.Write("İşaretli bir sayı giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());
        double kontrol = Math.Sign(girilenSayi);

        if (kontrol == (-1))
            Console.WriteLine("Negatif");
        else if (kontrol == (1))
            Console.WriteLine("Pozitif");
        else
            Console.WriteLine("0");
        Console.ReadLine();
    }
}