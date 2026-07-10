using System;
using System.Collections; // ArrayList kullanmak için bu şarttır!

namespace CSharpArrayListNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // HAP BİLGİ 1: ArrayList dinamiktir. Normal Array (Dizi) gibi sabit boyutlu 
            // değildir; eleman ekledikçe kendi kendini otomatik büyütür.
            // ============================================================
            ArrayList arlist = new ArrayList();

            // ============================================================
            // HAP BİLGİ 2: İçine her veri tipini (int, string, bool, null) karışık alabilir.
            // Çünkü arka planda her şeyi "object" tipine dönüştürerek saklar (Heterojendir).
            // ============================================================
            arlist.Add(1);
            arlist.Add("Bill");
            arlist.Add(true);
            arlist.Add(null); 

            // Başka bir diziyi topluca sonuna ekleme (AddRange)
            int[] sayilar = { 100, 200, 300 };
            arlist.AddRange(sayilar);


            // ============================================================
            // 2. ARAYA ELEMAN EKLEME (Insert / InsertRange)
            // ============================================================
            // Belirtilen indekse (sıraya) eleman sıkıştırır, diğerlerini kaydırır.
            arlist.Insert(1, "Yeni Eleman"); // 1. indekse bu metni yerleştirir


            // ============================================================
            // 3. ELEMAN SİLME VE KONTROL (Remove / Contains)
            // ============================================================
            arlist.Remove("Bill"); // Değere göre siler
            arlist.RemoveAt(0);    // İndekse (sıraya) göre siler

            // Eleman listede var mı yok mu kontrolü (Contains)
            bool varMi = arlist.Contains(200); 


            // ============================================================
            // HAP BİLGİ 3: Normal dizilerde toplam boyutu öğrenmek için ".Length" kullanılırken,
            // ArrayList gibi dinamik koleksiyonlarda aktif eleman sayısını öğrenmek için ".Count" kullanılır.
            // ============================================================
            Console.WriteLine($"Toplam Eleman Sayısı: {arlist.Count}");

            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }

            // ============================================================
            // HAP BİLGİ 4 (PERFORMANS): İçine her tipi karışık alabildiği için arka planda sürekli 
            // tip dönüşümü (Boxing/Unboxing) yapar. Bu yüzden normal Array'lere göre ÇOK YAVAŞTIR.
            // Modern C#'ta bunun yerine generic "List<T>" kullanılması önerilir.
            // ============================================================
        }
    }
}