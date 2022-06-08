using System;
class Timespan_ve_subtract_metodu
{
    static void Main()
    {
        //girilecek tarih formatı 12.12.1987
        Console.Write("İlk tarihi giriniz: ");
        DateTime ilkTarih = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Son tarihi giriniz: ");
        DateTime sonTarih = Convert.ToDateTime(Console.ReadLine());
        TimeSpan fark = sonTarih.Subtract(ilkTarih);
        Console.WriteLine("İki tarih arasındaki fark: {0}", fark);
        Console.ReadLine();
    }
}