using System;
using System.Collections; // Non-generic koleksiyonlar (ArrayList) için gerekli
using System.Collections.Generic; // Generic koleksiyonlar (List) için gerekli

namespace CSharpGenericsNotu
{
    // ============================================================
    // MANTIĞI: <T> geçici bir yer tutucudur (boş bir kalıptır).
    // Kod yazılırken veri tipi belli değildir, nesne üretilirken kesinleşir.
    // ============================================================

    // 1. GENERIC SINIF (Senin Örneğin)
    class DataStore<T>
    {
        public T Data { get; set; } // T ne gelirse Data o tipe bürünür
    }

    // 2. GENERIC METOT (Senin Örneğin)
    class Printer
    {
        // Metot yanındaki <T>, gelen her tipe uyum sağlayan bir kalıptır
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

    // Not: C# kuralları gereği kodu denemek istersen bu yapıyı kullanabilirsin
    class Test
    {
        public void Calistir()
        {
            // --------------------------------------------------------
            // HAP BİLGİ 1: Aynı kalıbı farklı tiplerle kullanıp kod tekrarını önleriz.
            // --------------------------------------------------------
            
            // Kalıba <string> döktük -> T artık string oldu
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World!"; 

            // Aynı kalıba <int> döktük -> T artık int oldu
            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100; 

            // --------------------------------------------------------
            // HAP BİLGİ 2: Tür Güvenliği (Type Safety) sağlar. 
            // strStore.Data = 123; yaparsan C# derleme aşamasında hata verir, korur.
            // --------------------------------------------------------


            // --------------------------------------------------------
            // HAP BİLGİ 3: Sadece metotları da generic (kalıp) yapabiliriz.
            // --------------------------------------------------------
            Printer printer = new Printer();
            
            printer.Print<int>(100);       // T yerine int geçer
            printer.Print<string>("Hello");// T yerine string geçer


            // ============================================================
            // YENİ EKLEME: NON-GENERIC VS GENERIC COLLECTIONS
            // ============================================================

            // A) Non-generic: İçine her veri tipini karışık alabilir (YAVAŞTIR)
            ArrayList nonGenericListe = new ArrayList();
            nonGenericListe.Add(100);       // int ekledik
            nonGenericListe.Add("Ceren");   // string ekledik
            nonGenericListe.Add(true);      // bool ekledik

            // B) Generic: Sadece tanımlanan veri tipini alabilir (ÇOK HIZLIDIR ve GÜVENLİDİR)
            List<string> genericListe = new List<string>();
            genericListe.Add("İzmir");
            genericListe.Add("Aydın");
            // genericListe.Add(123); -> HATA! Sadece string ekleyebilirsin, derleyici seni korur.
        }
    }
}