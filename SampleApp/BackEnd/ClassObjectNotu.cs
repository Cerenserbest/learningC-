/*

 C# CLASS & OBJECT DERS NOTU


 Sınıf (Class) : Bir nesnenin şablonu, kalıbı veya mimari planıdır. 
 Nesne (Object): O kalıptan üretilen somut örnektir.
*/

using System;

namespace CSharpTutorials
{
    //CLASS TANIMI
    class Student 
    {
        // 1.Alan
        // Sınıf içi değişkenlerdir.
        private int id; 


        // 2. PROPERTY
        // Gizli field'lara güvenli erişim sağlayan kapılardır.
        // get: Veriyi okurken, set: Veriyi yazarken/atarken tetiklenir.
        public int StudentId 
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }


        // 3. AUTO-IMPLEMENTED PROPERTY
        
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // 4. CONSTRUCTOR (Yapıcı Metot)
        // Nesne 'new' ile ilk kez oluşturulduğunda OTOMATİK çalışan ilk metottur.
        // Kural: İsmi sınıf ismiyle aynı olmak zorundadır ve geri dönüş tipi yazılmaz.
        public Student() 
        {
            // Nesne doğarken varsayılan değerleri atayabiliriz
            FirstName = "İsimsiz";
            LastName = "Soyadsız";
        }


        // 5. METHOD (Metot / Davranış)
        // Nesnenin yapabileceği eylemlerdir. Geriye bir şey dönmüyorsa 'void' yazılır.
        public string GetFullName() 
        {
            return FirstName + " " + LastName; 
        }


        // 6. PARAMETRELİ METHOD VE GEÇİCİ DEĞİŞKENLER
        // num1 ve num2 dışarıdan gelen parametrelerdir. 
        // 'total' ise sadece bu metot çalışırken yaşayan geçici yerel değişkendir.
        public int Sum(int num1, int num2) 
        {
            var total = num1 + num2; 
            return total; // Sonucu çağrıldığı yere fırlatır
        }
    }

    
}
