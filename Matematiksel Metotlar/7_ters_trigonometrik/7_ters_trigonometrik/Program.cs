using System;
class Trigonometrik
{
    static void Main()
    {
        double sinDegeri = 0.5;
        double cosDegeri = 0.866025403784439;
        double tanDegeri = 0.577350269189626;
        double sin = Math.Asin(sinDegeri)*(180/Math.PI); //dereceye çevirme işlemi
        double cos = Math.Acos(cosDegeri) * (180 / Math.PI);
        double tan = Math.Atan(tanDegeri) * (180 / Math.PI);
        Console.WriteLine("{0}{1}", "Girilen sayının sinüs değeri: ", sin);
        Console.WriteLine("{0}{1}", "Girilen sayının kosinüs değeri: ", cos);
        Console.WriteLine("{0}{1}", "Girilen sayının tanjant değeri: ", tan);
        Console.ReadLine();


    }
}