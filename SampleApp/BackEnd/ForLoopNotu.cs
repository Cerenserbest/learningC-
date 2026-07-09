/*
===================================================================
 C# FOR LOOP (FOR DÖNGÜSÜ)  NOTU
===================================================================

 Yapısı       : for (başlatıcı; koşul; yineleyici) { ... }
 break        : Döngüyü anında sonlandırmak (kırmak) için kullanılır.
 Çoklu Sayaç  : Aynı döngüde virgülle ayrılmış birden fazla sayaç yönetilebilir.


*/

using System;

namespace CSharpTutorials
{
    class ForLoopKullanimi
    {
        void StandartDongu()
        {
            // 0'dan 9'u dahil edene kadar 10 kez dönen döngü
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i değeri: " + i);
            }
        }

        void GeriyeVeOndalikliDongu()
        {
            // 1. Geriye Doğru Döngü (10'dan 1'e kadar)
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Geri sayım: " + i);
            }

            // 2. Double/Decimal Değişken Tipiyle Döngü
            for (double d = 1.01; d < 1.05; d += 0.01)
            {
                Console.WriteLine("Ondalıklı sayaç: " + d);
            }
        }

        void BreakVeCokluIfade()
        {
            // 1. break ile döngüyü erken bitirme
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break; // i 5 olduğu an döngü tamamen sonlanır.

                Console.WriteLine("Sayı: " + i);
            }

            // 2. Çoklu Sayaç Kullanımı (Virgülle ayrılmış)
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }
        }

        void IcIceDongu()
        {
            // 3. İç İçe (Nested) For Döngüsü
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"İç içe adım -> i: {i}, j: {j}");
                }
            }
        }
    }
}
