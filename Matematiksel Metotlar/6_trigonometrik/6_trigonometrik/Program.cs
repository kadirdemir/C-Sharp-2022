using System;
class Trigonometrik
{
    static void Main()
    {
        Console.Write("Trigonometrik değeri hesaplanacak sayıyı giriniz: ");
        double girilenSayi = Convert.ToDouble(Console.ReadLine());
        double sinDegeri = Math.Sin(girilenSayi * Math.PI / 180); //dereceye çevirme işlemi
        double cosDegeri = Math.Cos(girilenSayi * Math.PI / 180);
        double tanDegeri = Math.Tan(girilenSayi * Math.PI / 180);
        Console.WriteLine("{0}{1}", "Girilen sayının sinüs değeri: ", sinDegeri);
        Console.WriteLine("{0}{1}", "Girilen sayının kosinüs değeri: ", cosDegeri);
        Console.WriteLine("{0}{1}", "Girilen sayının tanjant değeri: ", tanDegeri);
        Console.ReadLine();


    }
}