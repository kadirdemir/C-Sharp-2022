using System;
class Is_desen_eslestirme
{
    static void Main()
    {
        object bakiye = 100;
        //sabit desen "null"

        if (bakiye is null)
        {
            return;
        }

        //tur deseni "decimal kullaniciBakiyesi"
        //decimal yerine int türü ile test edilse sonuç ekrana yazılabilirdi
        if (bakiye is decimal kullaniciBakiyesi)
        {
            Console.WriteLine("Kullanıcının bakiyesi " + kullaniciBakiyesi);
        }
    }
}