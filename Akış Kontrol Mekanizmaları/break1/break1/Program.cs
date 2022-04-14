using System;
class Break1
{
    static void Main()
    {
        char ch;

        do
        {
            Console.Write("Bir karakter giriniz: ");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'q' || ch == 'Q')
                break;
            else
                Console.WriteLine("Döngüye devam...");
        } while (true);

        Console.WriteLine("Döngü dışı");
    }
}