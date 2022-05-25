using System;
class Binary_search_ile_dizilerde_arama
{
    static void Main()
    {
        string[] dizi = new string[5];
        string str;
        int indeks;

        dizi.SetValue("Sefer", 0);
        dizi.SetValue("Feride", 1);
        dizi.SetValue("Gökçen", 2);
        dizi.SetValue("İhsan", 3);
        dizi.SetValue("Yusuf", 4);

        Console.WriteLine("Aranacak Yazı: ");

        str = Console.ReadLine();

        Array.Sort(dizi);

        indeks =Array.BinarySearch(dizi,str);

        if (indeks <= -1)
            Console.WriteLine("Yazı bulunamadı...");
        else
            Console.WriteLine("{0}. indekste bulundu", indeks);

    }
}