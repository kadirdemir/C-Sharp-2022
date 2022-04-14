using System;
class For_ornek3
{
    static void Main()
    {
        int satir, sutun;
        Console.Write("Satır sayısını giriniz: ");
        satir = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sütun sayısını giriniz: ");
        sutun = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();

        for (int i=0; i<sutun; i++)
        {
            for (int j = 0; j < satir; ++j)
                Console.Write("*");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}