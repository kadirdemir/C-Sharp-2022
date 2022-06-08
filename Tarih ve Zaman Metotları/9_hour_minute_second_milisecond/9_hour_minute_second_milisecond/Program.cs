using System;
class Hour_minute_second_milisecond
{
    static void Main()
    {
        DateTime zaman =DateTime.Now;

        string saat = zaman.Hour.ToString();
        string dakika = zaman.Minute.ToString();
        string saniye = zaman.Second.ToString();
        string milisaniye = zaman.Millisecond.ToString();

        Console.Write("Sistem saati: ");
        Console.Write("{0}{1}", saat, " saat - ");
        Console.Write("{0}{1}", dakika, " dk - ");
        Console.Write("{0}{1}", saniye, " sn - ");
        Console.Write("{0}{1}", milisaniye, " msn olarak göstermektedir.");
        Console.ReadLine();

    }
}