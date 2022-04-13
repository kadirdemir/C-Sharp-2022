using System;
class If_deyimi3
{
    static void Main()
    {
        int not;
        Console.Write("Notunuzu giriniz (0-100): ");
        not = Convert.ToInt32(Console.ReadLine());

        //0-100 arası değer girilmesi kontrolu
        //alinan nota gore harf notu atanmasi

        if (not < 0 || not > 100)
            Console.WriteLine("Yanlış not girdiniz.");
        else if (not > 90)
            Console.WriteLine("Notunuz: A");
        else if (not > 80)
            Console.WriteLine("Notunuz: B");
        else if (not > 70)
            Console.WriteLine("Notunuz: C");
        else if (not > 50)
            Console.WriteLine("Notunuz: D");
        else
            Console.WriteLine("Dersi Geçemediniz.");
    }
}