using System;
class Iki_deger_arasi_toplam
{
    static void Main()
    {
        int x, y, top=0;

        Console.Write("x değeri: ");
        x = Convert.ToInt32(Console.ReadLine());


        Console.Write("y değeri: ");
        y = Convert.ToInt32(Console.ReadLine());

        for (; x <= y; x++)
            top += x;

        Console.Write("toplam= " + top);
        Console.ReadLine();
    }
}