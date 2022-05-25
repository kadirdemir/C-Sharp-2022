using System;
class Create_instance_dizi_tanimlama
{
    static void Main()
    {
        //5 elemanlı bir dizi oluşturuluyor
        Array dizi = Array.CreateInstance(typeof(int), 5);
        foreach(int i in dizi)
            Console.WriteLine(i);


        //Üç boyutlu dizi oluşturma
        //CreateInstance(Type, int, int, int);

        //Type türünden int ile verilen sayı kadar elemanı olan dizi tanımlama
        //CreateInstance(Type, int);

        //Çok boyutlu diziler oluşturma
        //CreateInstance(Type, int []);

        //İki boyutlu dizi oluşturma
        //CreateInstance(Type, int, int);



    }
}