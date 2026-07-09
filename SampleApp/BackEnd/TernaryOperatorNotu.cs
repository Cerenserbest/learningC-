/*
===================================================================
  C# TERNARY OPERATOR (?:) — DERS NOTU
===================================================================

 Tanım         : Basit 'if-else' bloklarını tek satırda yazma yoludur.
 Tip Uyumluluğu: Soru işareti (?) ve iki nokta (:) sonrasındaki değerlerin 
                 veri tipleri birbiriyle tamamen aynı veya uyumlu olmalıdır.
 İç İçe (Nested): Birden fazla koşul arka arkaya eklenerek 'else-if' mantığı kurulabilir.


*/

using System;

namespace CSharpTutorials
{
    class TernaryKullanimi
    {
        void TemelKarsilastirma()
        {
            int x = 20, y = 10;

            // 1. Geleneksel if-else Yazımı:
            string sonucIf;
            if (x > y)
                sonucIf = "x büyüktür";
            else
                sonucIf = "y büyüktür veya eşittir";

            // 2. Ternary Operator İle Tek Satırda Yazımı:
            // x > y doğru (true) ise ilk metin, yanlış (false) ise ikinci metin 'sonucTernary'ye atanır.
            string sonucTernary = x > y ? "x büyüktür" : "y büyüktür veya eşittir";
            
            Console.WriteLine(sonucTernary);
        }

        void IcIceTernary()
        {
            int x = 10, y = 100;

            // 3. İç İçe (Nested) Kullanım (if - else if - else yapısının karşılığı)
            string sonuc = x > y ? "x büyüktür y" : 
                           x < y ? "x küçüktür y" : 
                           x == y ? "x eşittir y" : "Geçersiz durum";

            Console.WriteLine(sonuc); // Çıktı: x küçüktür y
        }
    }
}
