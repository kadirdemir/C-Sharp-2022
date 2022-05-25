using System;

class Cocuk_halisi
{
    static void Main()
    {
        string kod;
        double alan, ucret = 0;

        Console.Write("Halı Tipi seçiniz (T/B/S): ");
        kod = Convert.ToString(Console.ReadLine());

        Console.Write("Kaç metre halı döşenecek: ");
        alan = Convert.ToDouble(Console.ReadLine());

        if (kod == "T")
            ucret = alan * 18.8;
        else if (kod == "B")
            ucret = alan * 17.8;
        else if (kod == "S")
            ucret = alan * 19.2;

        Console.Write("Ödenmesi gereken ücret: " + ucret);

        Console.ReadLine();

    }
}