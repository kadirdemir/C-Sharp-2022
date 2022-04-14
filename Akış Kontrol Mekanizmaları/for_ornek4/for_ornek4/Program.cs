using System;
class For_ornek4
{
    static void Main()
    {
        byte sayi;

        Console.Write("Sayı giriniz (0-255): ");
        sayi = Convert.ToByte(Console.ReadLine());

        for (byte j = 8; j>=1; j--)
        {
            byte hane = 1;
            for (int k = 1; k <= j - 1; k++)
                hane *= 2;

            byte bit = (byte)((sayi & hane) >> j - 1);
            Console.Write(bit);
        }

    }
}