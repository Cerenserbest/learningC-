using System;
using System.Collections.Generic; // Generic Stack<T> kullanmak için şart!

namespace CSharpStackNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // 1. TANIMLAMA VE ELEMAN EKLEME (Push)
            // ============================================================
            Stack<int> yigin = new Stack<int>();

            // Sırayla 1, 2, 3, 4 ekliyoruz. En üstte '4' olacak.
            yigin.Push(1);
            yigin.Push(2);
            yigin.Push(3);
            yigin.Push(4); 

            // HAP BİLGİ 1: Döngüyle dönüldüğünde elemanlar son girenden 
            // ilk girene doğru (4, 3, 2, 1) sırasıyla gelir.
            foreach (var item in yigin)
            {
                Console.Write(item + ", "); // Çıktı: 4, 3, 2, 1,
            }


            // ============================================================
            // 2. EN ÜSTTEKİ ELEMANI SİLEREK ALMA (Pop)
            // ============================================================
            // HAP BİLGİ 2: Pop() metodu en üstteki elemanı listeden söker alır.
            // Boş bir stack üzerinde Pop() çağırmak hata fırlatır (InvalidOperationException).
            // Bu yüzden her zaman ".Count > 0" kontrolü yapılmalıdır.
            if (yigin.Count > 0)
            {
                int enUstteki = yigin.Pop(); // '4' değerini alır ve listeden siler.
                Console.WriteLine($"\nPop ile silinen: {enUstteki}"); 
            }


            // ============================================================
            // 3. EN ÜSTTEKİ ELEMANA SİLMEDEN BAKMA (Peek)
            // ============================================================
            // HAP BİLGİ 3: Peek() en üstteki elemanı sadece okur, listeye dokunmaz.
            if (yigin.Count > 0)
            {
                Console.WriteLine($"Peek ile bakılan: {yigin.Peek()}"); // Şu an en üstte '3' var, onu yazar.
                Console.WriteLine($"Peek sonrası adet: {yigin.Count}"); // Adet azalmaz, hala 3 eleman var.
            }


            // ============================================================
            // 4. ELEMAN KONTROLÜ (Contains)
            // ============================================================
            bool varMi = yigin.Contains(2); // Varsa true, yoksa false döner.
        }
    }
}