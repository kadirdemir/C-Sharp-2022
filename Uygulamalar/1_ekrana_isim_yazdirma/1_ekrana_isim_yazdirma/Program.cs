using System;
class Ekrana_isim_yazdirma
{

    static void Main()
    {
        //değişkenlerin tanımlanması
        string ad;

        //konsol ekranına "Adınızı yazınız:" ifadesinin yazdırılması
        Console.Write("Adınızı yazınız:");

        //konsola yazılan verinin okunması ve ad değişkenine atanması
        ad = Console.ReadLine();

        //Merhaba (girilen ad) ifadesinin yazdırılması
        Console.WriteLine("Merhaba " + ad);

        //pencerenin kapanmasının engellenmesi
        Console.ReadLine();
    }
}
