/*
===================================================================
 C# STATIC CLASS & MEMBERS — DERS NOTU
===================================================================

 Static Sınıf   : Nesnesi üretilemez, tüm üyeleri statik olmak zorundadır.
 Static Üye     : Normal sınıflarda da bulunabilir. Tüm nesneler arasında ORTAK paylaştırılır.
 Statik Yapıcı  : Parametresizdir. Sınıf ilk kez tetiklendiğinde sadece 1 KEZ çalışır.
 Bellek Yönetimi: Statik üyeler 'High-Frequency Heap' adı verilen özel bir alanda tutulur.


*/

using System;

namespace CSharpTutorials
{
	// 1. TAMAMEN STATIC BİR SINIF ÖRNEĞİ
	public static class Calculator
	{
		public static string Type = "Aritmetik";

		public static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}
	}

	// 2. NORMAL SINIF İÇİNDE STATIC KULLANIMI
	public class StopWatch
	{
		// Ortak paylaşılan statik değişken (Nesne sayısını sayacağız)
		public static int NoOfInstances = 0;
		public string InstanceName { get; set; } // Normal nesne değişkeni

		// STATIK CONSTRUCTOR (Parametresiz ve erişim belirteçsiz)
		static StopWatch()
		{
			Console.WriteLine("Statik constructor çalıştı (Sadece 1 kez görürsün).");
		}

		// NORMAL CONSTRUCTOR
		public StopWatch(string name)
		{
			this.InstanceName = name;
			StopWatch.NoOfInstances++; // Her nesne üretildiğinde ortak sayacı artırırız.
		}

		// STATIK METOT
		public static void DisplayInfo()
		{
			Console.WriteLine("Statik metot çağrıldı.");
			// Console.WriteLine(InstanceName); // HATA! Statik metot içinden normal değişkene erişilemez.
			Console.WriteLine("Toplam nesne sayısı: " + NoOfInstances); // Doğru! Statik alana erişebilir.
		}
	}

	/*
    ===================================================================
     🚀 KULLANIM ŞABLONU
    ===================================================================
    */
	class StaticKullanimi
	{
		void Test()
		{
			// Statik sınıf kullanımı (Doğrudan sınıf ismiyle)
			int sonuc = Calculator.Sum(10, 20);
			Calculator.Type = "Bilimsel";

			// Statik Üye Paylaşım Testi
			StopWatch sw1 = new StopWatch("Saat 1");
			StopWatch sw2 = new StopWatch("Saat 2");

			// Ortak sayaç çıktısı 2 olacaktır, çünkü alan paylaşımlıdır.
			Console.WriteLine(StopWatch.NoOfInstances); // Çıktı: 2

			// Statik metot çağrısı
			StopWatch.DisplayInfo();
		}
	}
}
