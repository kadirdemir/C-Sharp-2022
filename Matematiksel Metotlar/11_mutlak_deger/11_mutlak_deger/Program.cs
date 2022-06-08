using System;
class Mutlak_deger
{
    static void Main()
    {
        Console.Write("Mutlak değeri alınacak sayıyı giriniz: ");
        int girilenSayi = Convert.ToInt32(Console.ReadLine());
        int mutlakDeger = Math.Abs(girilenSayi);
        Console.WriteLine("{0}{1}", "Girilen sayının mutlak değeri: ", mutlakDeger);
        Console.ReadLine();
    }
}