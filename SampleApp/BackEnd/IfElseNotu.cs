/*
===================================================================
  C# IF, ELSE IF, ELSE — DERS NOTU
===================================================================

 Tanım       : Belirli koşullara göre program akışını kontrol etmeyi sağlar.
 Kural       : İfadelerin içi daima 'bool' (true/false) sonuç vermelidir.
 Kısa Yol    : Çok basit if-else durumları yerine Ternary Operator (?:) kullanılabilir.

*/

using System;

namespace CSharpTutorials
{
    class IfElseKullanimi
    {
        void TemelAkis()
        {
            int i = 10;
            int j = 20;

            // 1. Standart if - else if - else Yapısı
            if (i == j)
            {
                Console.WriteLine("i, j'ye eşittir.");
            }
            else if (i > j)
            {
                Console.WriteLine("i, j'den büyüktür.");
            }
            else
            {
                Console.WriteLine("i, j'den küçüktür."); // Koşulların hiçbiri uymadığı için burası çalışır.
            }
        }

        void MetotIleKullanim()
        {
            int i = 10, j = 20;

            // Koşul kısmında bool değer dönen metotlar doğrudan çağrılabilir:
            if (IsGreater(j, i))
            {
                Console.WriteLine("j, i'den büyüktür.");
            }
        }

        bool IsGreater(int x, int y)
        {
            return x > y;
        }

        void IçIçeKullanim()
        {
            int i = 10;
            int j = 20;

            // 2. İç İçe (Nested) if Yapısı
            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i, j'den kesinlikle küçük.");
                }
                else if (i > j)
                {
                    Console.WriteLine("i, j'den kesinlikle büyük.");
                }
            }
            else
            {
                Console.WriteLine("Sayılar eşit.");
            }
        }
    }
}
