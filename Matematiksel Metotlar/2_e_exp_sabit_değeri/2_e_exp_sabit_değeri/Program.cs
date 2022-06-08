using System;

class E_exp_sabit_değeri
{
    static void Main()
    {
        //e değeri yaklaşık 2,71828 olan matematiksel bir sabittir.
        Console.Write("E kuvveti olacak sayıyı giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());
        double islem = Math.Exp(girilenSayi);
        Console.WriteLine("Hesaplanan değer:{0}", islem);
        Console.ReadLine();

    }
}