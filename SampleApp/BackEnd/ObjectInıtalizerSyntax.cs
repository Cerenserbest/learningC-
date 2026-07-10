using System;

namespace ObjectInitializerDemo
{
    // Öğrenci Sınıfı (Constructor içermez)
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. YÖNTEM: Klasik Yöntem (Satır Satır Atama)
            Student stdKlasik = new Student();
            stdKlasik.StudentID = 1;
            stdKlasik.StudentName = "Bill";
            stdKlasik.Age = 20;
            stdKlasik.Address = "New York";

            // 2. YÖNTEM: Object Initializer Yöntemi (Daha Temiz ve Okunabilir)
            Student stdYeni = new Student() 
            { 
                StudentID = 1, 
                StudentName = "Bill", 
                Age = 20, 
                Address = "New York"   
            };

            // Object Initializer, kod yazımını kısaltır ve okunabilirliği artırır.
            Console.WriteLine($"Öğrenci: {stdYeni.StudentName}, Şehir: {stdYeni.Address}");
        }
    }
}