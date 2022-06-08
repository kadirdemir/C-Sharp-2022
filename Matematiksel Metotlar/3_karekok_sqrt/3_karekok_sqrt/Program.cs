using System;

class Karekok_sqrt
{
    static void Main()
    {
        Console.Write("Karekökü alınacak sayıyı giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());
        double karekok = Math.Sqrt(girilenSayi);
        Console.WriteLine("Girilen sayının karekökü: {0}", karekok);
        Console.ReadLine();
    }
}