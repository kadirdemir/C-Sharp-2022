using System;
class Switch_case_desen_eslestirme
{
    static void Main()
    {
        object nesne = 10;
        switch (nesne)
        {
            case String c: //tür deseni
                Console.WriteLine("Yazı değeri: " + c);
                break;
            case int s when (s > 10): //koşullu case ifadesi
                Console.WriteLine("Sayı 10'dan büyükse");
                break;
            case int s: //tür deseni
                Console.WriteLine("nesne int tipinden ve 10'dan büyük değilse");
                break;
            case null: //Sabit desen
                break;
            default:
                Console.WriteLine("<tanımlanamayan nesne>");
                break;

        }
    }

    
}