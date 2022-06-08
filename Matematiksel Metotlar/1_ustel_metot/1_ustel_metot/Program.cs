using System;
class Ustel_metot
{
    static void Main()
    {
        Console.Write("Dairenin yarıçapını giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());

        double daireninAlani = (3.14) * Math.Pow(girilenSayi, 2);
        Console.WriteLine("Dairenin hesaplanan alanı: {0}", daireninAlani);
        Console.ReadLine();
    }
}