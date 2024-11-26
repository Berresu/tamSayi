using System;
class HelloWorld {
	static void Main() {
		Console.Write("Tam Sayı Giriniz: ");
		int sayi = int.Parse(Console.ReadLine());
		Console.WriteLine($"Girdiğiniz Sayı: {sayi}");
	}
}
