/*
===================================================================
  C# OPERATÖRLER (OPERATORS) — DERS NOTU
===================================================================

 Tanım        : Değerler ve değişkenler üzerinde işlem yapan sembollerdir.
 Öncelik Sırası: Matematikteki gibi parantez (), çarpma/bölme, toplama/çıkarma sırasıyla gider.
 Bileşik Atama: x += 5 ifadesi, x = x + 5 yazmanın kısa yoludur.
*/

using System;

namespace CSharpTutorials
{
    class OperatorlerKullanimi
    {
        void AritmetikVeAtama()
        {
            // 1. Temel Aritmetik
            int toplam = 10 + 5;        // 15
            int kalan = 5 % 2;          // Mod alma (Bölümden kalan): 1
            
            // 2. String ile Toplama (Birleştirme)
            string mesaj = "Hello " + "World!"; // "Hello World!"

            // 3. Arttırma ve Azaltma
            int sayi = 10;
            sayi++;                     // sayi artık 11
            
            // 4. Bileşik Atama
            int x = 20;
            x += 5;                     // x = x + 5 ile aynıdır. x artık 25.
        }

        void KarsilastirmaVeMantik()
        {
            int a = 10;
            int b = 20;

            // 1. Karşılaştırma (Sonuç daima bool döner)
            bool esitMi = (a == b);     // false
            bool buyukMu = (a > b);     // false

            // 2. Mantıksal Operatörler
            bool kosul1 = true;
            bool kosul2 = false;

            bool veSonuc = kosul1 && kosul2;  // false (İkisi de true olmalıydı)
            bool veyaSonuc = kosul1 || kosul2;// true (Bir tanesinin true olması yeterli)
            bool degilSonuc = !kosul1;        // false (true olan değeri tersine çevirdi)
        }

        void OncelikSirasi()
        {
            // Çarpma toplama işleminden önceliklidir
            int sonuc1 = 5 + 3 * 3;     // Önce 3*3 yapılır, sonra 5 eklenir. Sonuç: 14
            
            // Parantez önceliği değiştirir
            int sonuc2 = (5 + 3) * 3;   // Önce parantez içi yapılır. Sonuç: 24
        }
    }
}
