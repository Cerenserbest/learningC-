using System;

namespace CSharpArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // 1. DIZI TANIMLAMA VE ILKLENDIRME YONTEMLERI
            

            // Yöntem A: Boyut belirterek (Açık yazım)
            int[] nums1 = new int[5] { 2, 4, 6, 8, 10 };

            // Yöntem B: Boyut belirtmeden (Eleman sayısından otomatik anlar - En popüler)
            int[] nums2 = { 2, 4, 6, 8, 10 };

            // Yöntem C: 'var' anahtar kelimesi ile
            var nums3 = new int[] { 2, 4, 6, 8, 10 };

            // Yöntem D: Geç Tanımlama (Late Initialization)
            int[] nums4;
            nums4 = new int[] { 2, 4, 6, 8, 10 };


            // ==========================================
            // 2. ELEMANLARA ERISIM VE INDEKS MANTIGI
            // ==========================================
            // İndeksler her zaman 0'dan başlar. Son indeks: (Boyut - 1)
            string[] cities = { "Mumbai", "London", "New York" };
            cities[0] = "İzmir"; // İlk elemanı "İzmir" olarak güncelledik


            // ==========================================
            // 3. DONGULER ILE DIZIYI DONME (ITERATION)
            // ==========================================

            // A) for Döngüsü (Elemanları güncellemek veya indeks gerektiren durumlar için)
            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] += 10; // Her elemana 10 ekler (Diziyi günceller)
            }

            // B) foreach Döngüsü (Sadece elemanları sırayla okumak için - Güvenli ve pratik)
            foreach (var city in cities)
            {
                Console.WriteLine(city); // Elemanları ekrana basar
            }
        }
    }
}