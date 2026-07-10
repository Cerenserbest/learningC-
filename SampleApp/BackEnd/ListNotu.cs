using System;
using System.Collections; // YENİ: Non-generic Hashtable kullanabilmek için şart!
using System.Collections.Generic; // List, SortedList ve Dictionary için şarttır!

namespace CSharpListNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // 1. GENERIC LIST<T> (NORMAL LİSTE) - EN ÖNEMLİ YAPI
            // ============================================================
            // HAP BİLGİ 1: List<T> dinamiktir, sadece tek tipe (Strongly Typed) izin verir.
            // Arka planda objeye dönüştürme (Boxing) yapmadığı için ArrayList'ten ÇOK DAHA HIZLIDIR.
            List<int> rakamlar = new List<int>();
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(5);

            // Tanımlarken doğrudan eleman ekleme (Collection Initializer)
            List<string> sehirler = new List<string>() { "İzmir", "Aydın", "İstanbul" };

            // 2. TOPLU ELEMAN EKLEME (AddRange)
            string[] yeniSehirler = { "Manisa", "Eskişehir" };
            sehirler.AddRange(yeniSehirler); // Bir diziyi listenin sonuna topluca ekler

            // 3. ARAYA ELEMAN SIKIŞTIRMA (Insert)
            sehirler.Insert(1, "Turgutlu"); // 1. indekse bu veriyi ekler, diğerlerini kaydırır.

            // 4. ELEMAN SİLME VE KONTROL (Remove / RemoveAt / Contains)
            sehirler.Remove("İstanbul"); // Değere göre bulup ilk eşleşeni siler
            sehirler.RemoveAt(0);        // 0. indeksteki (en baştaki) elemanı siler

            // Eleman listede var mı yok mu sorgusu (Contains)
            bool varMi = sehirler.Contains("Aydın"); // Varsa true döner
            
            // HAP BİLGİ 2: Listelerin eleman sayısını öğrenmek için ".Count" özelliği kullanılır.
            Console.WriteLine($"Toplam Şehir Sayısı: {sehirler.Count}");

            // Listeye özel hızlı döngü yapısı (Lambda Expression)
            sehirler.ForEach(sehir => Console.WriteLine(sehir));


            // ============================================================
            // 2. GENERIC SORTEDLIST<TKey, TValue> (OTOMATİK SIRALI SÖZLÜK)
            // ============================================================
            // HAP BİLGİ 3: Verileri Anahtar-Değer (Key-Value) çifti olarak tutar.
            // Sen karışık eklesen bile Key alanına göre listeyi arka planda OTOMATİK SIRALAR (1, 2, 3...).
            // KURAL: Key'ler benzersiz (unique) olmalı ve null olamaz!
            SortedList<int, string> ogrenciler = new SortedList<int, string>();
            ogrenciler.Add(3, "Selinay");
            ogrenciler.Add(1, "Ceren"); // Otomatik olarak en başa taşınır
            ogrenciler.Add(2, "Rabia");

            ogrenciler.Remove(1); // Key'i 1 olan elemanı doğrudan siler.


            // ============================================================
            // 3. GENERIC DICTIONARY<TKey, TValue> (HIZLI / SIRASIZ SÖZLÜK)
            // ============================================================
            // HAP BİLGİ 4: Tıpkı SortedList gibi Key-Value mantığıyla çalışır ama verileri SIRASIZ tutar.
            // Sıralama zahmetine girmediği için eleman ekleme ve silme hızı SortedList'ten ÇOK DAHA YÜKSEKTİR.
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("Apple", "Elma");
            sozluk.Add("Car", "Araba");

            // Güvenli veri okuma ve güncelleme:
            if (sozluk.ContainsKey("Apple"))
            {
                Console.WriteLine($"Anlamı: {sozluk["Apple"]}"); // Doğrudan Key ile çağırdık
            }
            sozluk["Apple"] = "Kırmızı Elma"; // Değer güncelleme (Indexer)

            sozluk.Remove("Car"); // Key'e göre siler


            // ============================================================
            // 4. YENİ EKLEME: NON-GENERIC HASHTABLE (KARIŞIK / SIRASIZ SÖZLÜK)
            // ============================================================
            // HAP BİLGİ 5: Dictionary yapısının eski nesil (Non-generic) halidir. Key-Value mantığıyla çalışır.
            // EN BÜYÜK FARKI: Key ve Value kısımlarına her veri tipini (int, string, bool) KARIŞIK ekleyebilirsin.
            // DEZAVANTAJI: Veriyi okurken açıkça tip dönüşümü (Type Cast) yapmak zorundasın ve yavaştır. Modern C#'ta Dictionary tercih edilir.
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add("UK", "London");

            // Veri Okuma Örneği (Explicit Casting Şarttır!)
            string ukSehir = (string)ht["UK"]; 

            ht.Remove("UK"); // Key'e göre siler
        }
    }
}