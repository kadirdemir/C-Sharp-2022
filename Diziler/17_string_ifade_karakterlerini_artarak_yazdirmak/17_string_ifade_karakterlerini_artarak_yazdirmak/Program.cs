Console.Write("Metin giriniz: ");
string metin =Console.ReadLine();

metin = metin.ToUpper();

for (int i = 0; i <= metin.Length; i++)
    Console.WriteLine(metin.Substring(0,i));

Console.ReadLine();
