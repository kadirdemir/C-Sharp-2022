using System;
class Logaritma
{
    static void Main()
    {
        Console.Write("Logaritması alınacak sayıyı giriniz: ");
        double logSayi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Logaritma tabanı olacak sayıyı giriniz: ");
        double tabanSayi = Convert.ToDouble(Console.ReadLine());
        double islem = Math.Log(logSayi, tabanSayi);
        Console.WriteLine("Hesaplanan değer: {0}", islem);
        Console.ReadLine();

    }
}