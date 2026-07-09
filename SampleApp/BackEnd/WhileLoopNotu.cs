/*
===================================================================
  C# WHILE LOOP (WHILE DÖNGÜSÜ) — DERS NOTU
===================================================================

 Yapısı    : while (koşul) { // kodlar ... sayaç_güncelleme; }
 Mantık    : Koşul doğru (true) olduğu sürece blok kesintisiz çalışır.
 break     : 'while (true)' gibi sonsuz döngüleri içeriden kırmak için idealdir.

*/

using System;

namespace CSharpTutorials
{
    class WhileLoopKullanimi
    {
        void StandartKullanim()
        {
            // 1. Sayaç ve Başlangıç Değeri Dışarıda Tanımlanır
            int i = 0; 

            // Koşul kontrol edilir
            while (i < 10) 
            {
                Console.WriteLine("i değeri: " + i);

                // Kural: Koşulu etkileyecek değişim içeride yapılmalıdır!
                i++; 
            }
        }

        void SonsuzDonguVeBreak()
        {
            int sayac = 0;

            // 2. Kasıtlı Sonsuz Döngü ve Koşullu Break Kullanımı
            while (true)
            {
                Console.WriteLine("Sayaç: " + sayac);
                sayac++;

                if (sayac > 5)
                {
                    break; // sayaç 5'i geçtiği an döngü kırılır.
                }
            }
        }

        void IcIceWhile()
        {
            int i = 0;
            
            // 3. İç İçe (Nested) While Döngüsü
            // Okunabilirliği azalttığı için çok mecbur kalınmadıkça önerilmez.
            while (i < 2)
            {
                Console.WriteLine("Dış döngü i: " + i);
                i++;

                int j = 1;
                while (j < 2)
                {
                    Console.WriteLine("İç döngü j: " + j);
                    j++;
                }
            }
        }
    }
}
