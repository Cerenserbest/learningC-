/*
===================================================================
  C# SWITCH STATEMENT — DERS NOTU
===================================================================

 Tanım        : Tek bir değişkenin değerini farklı sabitlerle kıyaslayan karar yapısıdır.
 Tipler       : Switch bloğu char, string, bool, int veya enum tiplerini destekler.
 Kural        : case etiketlerindeki değerler sabit (constant) ve benzersiz olmalıdır.


*/

using System;

namespace CSharpTutorials
{
    class SwitchKullanimi
    {
        void StandartSwitch()
        {
            int x = 10;

            switch (x)
            {
                case 5:
                    Console.WriteLine("x değeri 5.");
                    break;
                case 10:
                    Console.WriteLine("x değeri 10."); // x = 10 olduğu için burası tetiklenir
                    break;
                default:
                    Console.WriteLine("Bilinmeyen değer.");
                    break;
            }
        }

        void BirlesikVeMetinselSwitch()
        {
            string kartTipi = "Ternary";

            switch (kartTipi)
            {
                case "IfElse":
                case "Ternary": // Birden fazla durum birleştirildi
                    Console.WriteLine("Koşullu karar yapısı seçildi.");
                    break;
                case "Switch":
                    Console.WriteLine("Switch yapısı seçildi.");
                    break;
                default:
                    Console.WriteLine("Tanımsız seçim.");
                    break;
            }
        }

        void IcIceSwitch()
        {
            int j = 5;

            // İç içe (Nested) Switch kullanımı mümkündür fakat kod karmaşasını artırabilir.
            switch (j)
            {
                case 5:
                    Console.WriteLine("Ana switch yakaladı: 5");
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine("İç switch yakaladı: 4");
                            break;
                    }
                    break;
            }
        }
    }
}
