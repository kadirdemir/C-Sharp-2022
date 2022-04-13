using System;
class Do_while1
{
    static void Main()
    {
        string yazi;
        do
        {
            Console.WriteLine("Şifreyi Giriniz: ");
            yazi = Console.ReadLine();

        } while (yazi != "sifre");
        Console.WriteLine("Şifreyi bildiniz");
    }
}