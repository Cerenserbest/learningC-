using System;
using System.Collections.Generic; // List<T> kullanmak için bu kütüphane ŞARTTIR!

namespace CSharpListNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // HAP BİLGİ 1: List<T>, ArrayList'in modern ve güvenli halidir. 
            // Boyutu dinamiktir ama sadece tek bir veri tipi kabul eder (Strongly Typed).
            // ============================================================
            List<int> rakamlar = new List<int>();
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(5);
            // rakamlar.Add("Ceren"); -> DERLEME HATASI! int listesine string atamazsın, korur.

            // Tanımlarken doğrudan eleman ekleme (Collection Initializer)
            List<string> sehirler = new List<string>() { "İzmir", "Aydın", "İstanbul" };


            // ============================================================
            // 2. TOPLU ELEMAN EKLEME (AddRange)
            // ============================================================
            string[] yeniSehirler = { "Manisa", "Eskişehir" };
            sehirler.AddRange(yeniSehirler); // Bir diziyi listenin sonuna topluca ekler


            // ============================================================
            // 3. ARAYA ELEMAN SIKIŞTIRMA (Insert)
            // ============================================================
            sehirler.Insert(1, "Turgutlu"); // 1. indekse (2. sıraya) bu veriyi ekler, diğerlerini kaydırır.


            // ============================================================
            // 4. ELEMAN SİLME VE KONTROL (Remove / RemoveAt / Contains)
            // ============================================================
            sehirler.Remove("İstanbul"); // Değere göre bulup ilk eşleşeni siler
            sehirler.RemoveAt(0);        // 0. indeksteki (en baştaki) elemanı siler

            // Eleman listede var mı yok mu sorgusu (Contains)
            bool varMi = sehirler.Contains("Aydın"); // Varsa true döner


            
            // HAP BİLGİ 2: Listelerin eleman sayısını öğrenmek için ".Count" özelliği kullanılır.
            // Ayrıca döngü haricinde ".ForEach()" metoduyla da hızlıca ekrana yazdırılabilir.
           
            Console.WriteLine($"Toplam Şehir Sayısı: {sehirler.Count}");

            // Listeye özel hızlı döngü yapısı (Lambda Expression)
            sehirler.ForEach(sehir => Console.WriteLine(sehir));


            
            // HAP BİLGİ : ArrayList arka planda Boxing/Unboxing (objeye dönüştürme) 
            // yaptığı için sistemi yorar. List<T> ise doğrudan tiple çalıştığı için ÇOK DAHA HIZLIDIR.
            
        }
    }
}