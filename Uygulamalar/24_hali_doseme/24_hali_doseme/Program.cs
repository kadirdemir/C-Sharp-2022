using System;

class Hali_doseme
{
    static void Main()
    {
        int metrekare, ucret, doseme=100, birimfiyat=35;

        Console.Write("Metrekare giriniz: ");
        metrekare = Convert.ToInt32(Console.ReadLine());

        ucret = metrekare * birimfiyat + doseme;

        Console.Write("Ucret: " + ucret);

        Console.ReadLine();

    }
}