using System;
using System.Collections.Generic; // Generic Queue<T> kullanmak için şart!

namespace CSharpQueueNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // 1. TANIMLAMA VE ELEMAN EKLEME (Enqueue)
            // ============================================================
            Queue<int> sira = new Queue<int>();

            // Sırayla 1, 2, 3, 4 ekliyoruz. En başta '1' olacak.
            sira.Enqueue(1);
            sira.Enqueue(2);
            sira.Enqueue(3);
            sira.Enqueue(4);

            // HAP BİLGİ 1: Döngüyle dönüldüğünde elemanlar ilk girenden 
            // son girene doğru (1, 2, 3, 4) sırasıyla basılır.
            foreach (var item in sira)
            {
                Console.Write(item + ", "); // Çıktı: 1, 2, 3, 4,
            }


            // ============================================================
            // 2. EN BAŞTAKİ ELEMANI SİLEREK ALMA (Dequeue)
            // ============================================================
            // HAP BİLGİ 2: Dequeue() sıranın en başındaki elemanı söküp alır.
            // Boş bir kuyrukta Dequeue() çağırmak InvalidOperationException fırlatır.
            // Bu yüzden her zaman ".Count > 0" kontrolü yapılmalıdır.
            if (sira.Count > 0)
            {
                int ilkGiren = sira.Dequeue(); // '1' değerini alır ve kuyruktan siler.
                Console.WriteLine($"\nDequeue ile silinen: {ilkGiren}");
            }


            // ============================================================
            // 3. EN BAŞTAKİ ELEMANA SİLMEDEN BAKMA (Peek)
            // ============================================================
            // HAP BİLGİ 3: Peek() sıranın en başındaki elemanı sadece okur, sırayı bozmaz.
            if (sira.Count > 0)
            {
                Console.WriteLine($"Peek ile bakılan: {sira.Peek()}"); // Sıranın başında şu an '2' var, onu yazar.
                Console.WriteLine($"Peek sonrası adet: {sira.Count}"); // Adet azalmaz, hala 3 eleman var.
            }


            // ============================================================
            // 4. ELEMAN KONTROLÜ (Contains)
            // ============================================================
            bool varMi = sira.Contains(3); // Varsa true, yoksa false döner.
        }
    }
}