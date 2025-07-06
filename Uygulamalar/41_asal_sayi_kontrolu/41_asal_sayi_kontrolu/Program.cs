using System;

class Asal_sayi_kontrolu
{
    static void Main()
    {
        Console.Write("Bir tam sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        bool asalMi = true;

        if (sayi < 2)
            asalMi = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
        }

        if (asalMi)
            Console.WriteLine("Sayı asaldır");
        else
            Console.WriteLine("Sayı asal değildir");

        Console.ReadLine();
    }
}
