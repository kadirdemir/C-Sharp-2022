using System;
class Iki_farkli_deger_kontrolu
{
    static void Main()
    {
        int s1, s2;

        Console.Write("Sayı 1: ");
        s1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sayı 2: ");
        s2 = Convert.ToInt32(Console.ReadLine());

        if (s1 == s2)
            Console.Write("Sayı 1 = Sayı 2");
        else if (s1 < s2)
            Console.Write("Sayı 2 büyük");
        else if (s1 > s2)
            Console.Write("Sayı 1 büyük");

        Console.ReadLine();
    }
}