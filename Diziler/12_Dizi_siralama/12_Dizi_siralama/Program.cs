using System;

class Dizi_siralama
{
    static void Main()
    {
        Array strArray = Array.CreateInstance(typeof(string), 6);
        strArray.SetValue ("Sefer", 0);
        strArray.SetValue ("Mehmet", 1);
        strArray.SetValue ("Tahir", 2);
        strArray.SetValue ("Yusuf", 3);
        strArray.SetValue ("Yunus", 4);
        strArray.SetValue ("Gökçen", 5);

        Console.WriteLine("Sırasız Dizi:\n");
        foreach(string isim in strArray)
            Console.Write(isim + "-");

        Console.WriteLine();

        Console.WriteLine("\nSıralı Dizi: \n");
            Array.Sort(strArray);

        foreach (string isim in strArray)
            Console.Write(isim + "-");

        Console.ReadLine();

    }
}