/*
===================================================================
  C# DEĞİŞKENLER VARIABLES NOTU
===================================================================

 Değişken Nedir? : Bellekte belirli bir veri türündeki değeri saklamak 
                  için kullanılan, değeri değiştirilebilen alanlardır.
 Sözdizimi       : <veri_tipi> <degisken_adi> = <deger>;
 Güçlü Tipli Dil : C# güçlü tipli (strongly-typed) bir dildir. Bir 'int' 
                  değişkene doğrudan 'string' (metin) atanamaz.

===================================================================
  DEĞİŞKEN TANIMLAMA KURALLARI
===================================================================
 1. İsimler benzersiz olmalıdır.
 2. Sadece harf, rakam ve alt çizgi (_) içerebilir. Rakamla BAŞLAYAMAZ.
 3. Büyük/küçük harfe duyarlıdır (case-sensitive). 'num' ve 'Num' farklıdır.
 4. C# anahtar kelimeleri (int, class vb.) doğrudan isim olamaz. 
    Kullanılacaksa başına '@' eklenmelidir.


*/

using System;

namespace CSharpTutorials
{
    class VariablesOrnek
    {
        void TemelTipler()
        {
            int num = 100;              // Tam sayılar
            float rate = 10.2f;         // Ondalıklı sayılar (f/F eki zorunlu)
            decimal amount = 100.50M;   // Finansal ondalıklılar (m/M eki zorunlu)
            char code = 'C';            // Tek bir karakter (Tek tırnak)
            bool isValid = true;        // Doğru (true) veya Yanlış (false)
            string name = "Steve";      // Metin ifadeleri (Çift tırnak)
        }

        void KullanımMantigi()
        {
            // 1. Geç Başlatma (Late Initialization)
            int i;
            // int j = i; // İlk değer atanmadan değişken kullanılamaz.
            i = 100; // Artık kullanılabilir.

            // 2. Tek Satırda Birden Çok Tanımlama
            int x = 10, y = 20, z = 30;

            // 3. Değer Değiştirme
            int sayi = 50;
            sayi = 200; // Değişkenin yeni değeri artık 200'dür.

            // 4. Değişkeni Başka Değişkene Atama
            int a = 100;
            int b = a; // b'nin değeri de 100 olur.
        }
    }
}
