using System;

class string_al_integer_donustur_yazdir
{
    static void Main()
    {
        string s1, s2;
        int sayi1, sayi2;
        int Toplam;

        Console.WriteLine("İlk sayıyı gir:");
        s1 = Console.ReadLine();

        Console.WriteLine("İkinci sayıyı gir:");
        s2 = Console.ReadLine();

        sayi1=Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);  
        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam =" + Toplam.ToString());

    }
}