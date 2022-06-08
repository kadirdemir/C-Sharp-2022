using System;
class Compare_metodu
{
    static void Main()
    {
        //tarih bilgisini 13.05.2022 formatında giriniz
        Console.Write("İlk tarihi giriniz: ");
        DateTime ilkTarih = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Son tarihi giriniz: ");
        DateTime sonTarih = Convert.ToDateTime(Console.ReadLine());

        int sonuc = DateTime.Compare(ilkTarih, sonTarih);
        if (sonuc == 0)
            Console.WriteLine("İki tarih bilgisi birbirine eşittir.");
        else
            Console.WriteLine("İki tarih bilgisi birbirinden farklıdır.");
        Console.ReadLine();

    }
}