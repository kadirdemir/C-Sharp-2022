using System;

class Calisma_zamaninda_dizi_boyutu_belirleme
{
    static void Main()
    {
        Console.Write("Dinamik dizinin boyutu: ");
        int val = Convert.ToInt32(Console.ReadLine());

        int [] dizi = new int [val];

        for (int i = 0; i < val; i++)
            Console.WriteLine(dizi[i]);
    }
}