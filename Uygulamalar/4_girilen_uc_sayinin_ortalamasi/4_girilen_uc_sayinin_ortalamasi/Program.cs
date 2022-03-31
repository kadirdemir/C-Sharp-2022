using System;

class Program
{

	static void Main()
	{
		int s1, s2, s3, ort;

		Console.Write("İlk sayıyı giriniz: ");
		s1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("İkinci sayıyı giriniz: ");
		s2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Üçüncü sayıyı giriniz: ");
		s3 = Convert.ToInt32(Console.ReadLine());
		
		ort = (s1 + s2 + s3) / 3;

		Console.WriteLine("Üç sayının ortalaması: " + ort);
		Console.Read();
	}
}
