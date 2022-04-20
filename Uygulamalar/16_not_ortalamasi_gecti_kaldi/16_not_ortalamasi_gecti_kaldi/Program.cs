using System;
class Not_ortalamasi_gecti_kaldi
{
    static void Main()
    {
        int n1, n2, ort;

    n1_degeri:
        Console.Write("n1: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 < 0 || n1 > 100) goto n1_degeri;

    n2_degeri:
        Console.Write("n2: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n2 < 0 || n2 > 100) goto n2_degeri;

    ort = (n1 + n2) / 2;

        if (ort >= 50)
            Console.Write("Geçti");
        else
            Console.Write("Kaldı");

        Console.ReadLine();
    }
}