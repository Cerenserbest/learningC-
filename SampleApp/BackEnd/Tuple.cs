using System;

namespace CSharpTupleNotu
{
    class Test
    {
        public void Calistir()
        {
            // ============================================================
            // 1. ESKİ NESİL TUPLE (REFERENCE TYPE)
            // ============================================================
            // HAP BİLGİ 1: Eski Tuple bir Class'tır (Referans Tipi). Heap bellekte tutulur, maliyetlidir.
            // En büyük gıcıklığı elemanlara sadece Item1, Item2 diye erişilmesidir ve en fazla 8 eleman alır.
            var eskiTuple = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine($"Eski Tuple ID: {eskiTuple.Item1}");


            // ============================================================
            // 2. MODERN VALUETUPLE (VALUE TYPE) - C# 7.0+
            // ============================================================
            // HAP BİLGİ 2: ValueTuple bir Struct'tır (Değer Tipi). Stack bellekte tutulur ve ÇOK HIZLIDIR.
            // 8 eleman sınırı yoktur. Parantez () kullanılarak çok kolay tanımlanır.
            var yeniTuple = (1, "Bill", "Gates");

            // HAP BİLGİ 3 (EFSANE ÖZELLİK): Elemanlara Item1 yerine kendi verdiğin isimlerle erişebilirsin!
            var person = (Id: 1, FirstName: "Ceren", LastName: "Serbest");
            Console.WriteLine($"Kişi: {person.FirstName} {person.LastName}"); // Item2 yerine doğrudan isimle çağrıldı


            // ============================================================
            // 3. METOTLARDA KULLANIMI (PARAMETRE & RETURN)
            // ============================================================
            // Metottan dönen isimlendirilmiş veriyi okuma
            var ogrenci = GetStudent();
            Console.WriteLine($"Öğrenci: {ogrenci.No} - {ogrenci.Ad}");


            // ============================================================
            // 4. DECONSTRUCTION (PARÇALARA AYIRMA) & DISCARD
            // ============================================================
            // Tuple içindeki verileri tek seferde ayrı değişkenlere çıkartabiliriz:
            (int siraNo, string isim, _) = (10, "Rabia", "Kaya");
            // HAP BİLGİ 4: Alt çizgi (_) "discard" anlamına gelir. Kullanılmayacak veriyi belleğe almaz, çöpe atar.
            Console.WriteLine($"Sıra No: {siraNo}, İsim: {isim}");
        }

        // Metot tanımlarken dönüş tipine doğrudan isim verebiliriz
        static (int No, string Ad) GetStudent()
        {
            return (No: 45, Ad: "Selin");
        }
    }
}