using System;
using System.Collections.Generic; // List<T> ve SortedList<TKey, TValue> için şarttır!

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
            // rakamlar.Add("Ceren"); -> DERLEME HATASI! int listesine string atamazsın, korur.

            // Tanımlarken doğrudan eleman ekleme (Collection Initializer)
            List<string> sehirler = new List<string>() { "İzmir", "Aydın", "İstanbul" };

            // 2. TOPLU ELEMAN EKLEME (AddRange)
            string[] yeniSehirler = { "Manisa", "Eskişehir" };
            sehirler.AddRange(yeniSehirler); // Bir diziyi listenin sonuna topluca ekler

            // 3. ARAYA ELEMAN SIKIŞTIRMA (Insert)
            sehirler.Insert(1, "Turgutlu"); // 1. indekse (2. sıraya) bu veriyi ekler, diğerlerini kaydırır.

            // 4. ELEMAN SİLME VE KONTROL (Remove / RemoveAt / Contains)
            sehirler.Remove("İstanbul"); // Değere göre bulup ilk eşleşeni siler
            sehirler.RemoveAt(0);        // 0. indeksteki (en baştaki) elemanı siler

            // Eleman listede var mı yok mu sorgusu (Contains)
            bool varMi = sehirler.Contains("Aydın"); // Varsa true döner
            
            // HAP BİLGİ 2: Listelerin eleman sayısını öğrenmek için ".Count" özelliği kullanılır.
            // Ayrıca döngü haricinde ".ForEach()" metoduyla da hızlıca ekrana yazdırılabilir.
            Console.WriteLine($"Toplam Şehir Sayısı: {sehirler.Count}");

            // Listeye özel hızlı döngü yapısı (Lambda Expression)
            sehirler.ForEach(sehir => Console.WriteLine(sehir));


            // ============================================================
            // 2. GENERIC SORTEDLIST<TKey, TValue> (ÖZET KISA NOT)
            // ============================================================
            // HAP BİLGİ 3: Verileri "Anahtar-Değer" (Key-Value) çifti olarak tutar.
            // Sen karışık eklesen bile Key alanına göre listeyi OTOMATİK SIRALAR (1, 2, 3...).
            // KURAL: Key'ler benzersiz (unique) olmalı ve null olamaz! Value'lar tekrar edebilir.
            SortedList<int, string> ogrenciler = new SortedList<int, string>();
            ogrenciler.Add(3, "Selinay");
            ogrenciler.Add(1, "Ceren"); // Otomatik olarak en başa taşınır
            ogrenciler.Add(2, "Rabia");

            // Kısa Kullanım Özetleri:
            bool keyVarMi = ogrenciler.ContainsKey(2); // 2 numaralı key var mı? (Güvenlik için)
            ogrenciler.Remove(1); // Key'i 1 olan elemanı (Ceren) doğrudan siler.

            // HAP BİLGİ 4 (MÜLAKAT): Arama (retrieval) hızı çok iyidir. Ancak her ekleme/silmede 
            // listeyi baştan sıraladığı için yazma operasyonları List<T>'ye göre daha yavaştır.
        }
    }
}