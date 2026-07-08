/*
===================================================================
  C# VAR ANAHTAR KELİMESİ VE KULLANIM KURALLARI
===================================================================

 var Nedir? : Bir veri tipi değildir. Değişkenin tipini açıkça yazmak 
              yerine, tip belirleme işini C# derleyicisine bıraktığımız 
              bir kolaylıktır. Derleyici, eşittir işaretinin sağındaki 
              değere bakarak tipi otomatik çıkarır (Type Inference).
*/

using System;

namespace CSharpTutorials
{
    class VarKurallari
    {
        void Kurallar()
        {
            // Tanımlama Tipleri
            int sayi1 = 10; // Açık (Explicit) tanımlama
            var sayi2 = 10; // Örtük (Implicit) tanımlama -> Derleyici bunu otomatik 'int' yapar.


            // 1. Tanımlandığı An Değer Atanmalıdır
            // var kullanılan bir değişkene aynı satırda değer verilmek zorundadır.
            // Derleyici sağ tarafta bir değer görmezse tipini tahmin edemez ve hata verir.
            
            // var x; // HATA! (Derleyici tipini anlayamadı)
            // x = 100;
            
            var x = 100; // DOĞRU!


            // 2. Tek Satırda Birden Fazla var Tanımlanamaz
            // Virgülle ayırarak aynı satırda çoklu var deklarasyonu yapılamaz.
            
            // var i = 10, j = 20; // HATA!
        }

        void DonguKullanimi()
        {
            // 4. Döngülerde (For ve Foreach) Harika Çalışır
            // Döngü sayaçlarında veya koleksiyonları dönerken var kullanmak çok pratiktir.
            
            for (var i = 0; i < 10; i++) 
            { 
                // i otomatik int olur 
            }
        }
    }
}
