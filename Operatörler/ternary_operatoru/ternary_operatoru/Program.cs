using System;
class Ternary_operatoru
{
    static void Main()
    {
        int sayi;
        Console.Write("Kalem sayısını giriniz: ");
        sayi=Convert.ToInt32(Console.ReadLine());
        string str = "kalem";
        str = str + (sayi == 1 ? " " : "ler");
        Console.WriteLine(str);
    }
}