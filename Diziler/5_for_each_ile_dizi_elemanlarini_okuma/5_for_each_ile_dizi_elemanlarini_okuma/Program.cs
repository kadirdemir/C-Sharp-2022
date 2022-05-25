using System;

class For_each_ile_dizi_elemanlarini_okuma
{
    static void Main()
    {
        int [] dizi = { 1, 2, 3, 4, 5};
        //foreach döngüsü ile bir dizinin elemanlarına sadece okumak için erişilir
        //foreach ile dizi elemanı değiştirmeye çalışılırsa hata ile karşılaşılır
        foreach (int eleman in dizi) 
            Console.WriteLine(eleman);
    }
}