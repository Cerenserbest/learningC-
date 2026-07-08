/*


 Namespace Nedir? : İlgili sınıfları bir arada tutan, projeyi 
                    organize eden ve isim çakışmalarını önleyen kapsayıcılardır.
 'using'          : Farklı bir ad alanındaki sınıfı doğrudan kullanabilmek için 
                    dosyanın en üstünde o ad alanını projeye dahil ederiz.


*/

using System; // .NET'in dahili ad alanı (Console sınıfı bunun içindedir)

// C# 10 öncesi geleneksel yazım (Süslü parantezli):
namespace School
{
    class Student
    {
        // School.Student olarak çağrılır
    }

    class Course
    {
        // School.Course olarak çağrılır
    }
}
/*
============================================================
  EN PRATİK KULLANIM (USING KEYWORDÜ İLE)
===================================================================


// Bütün sınıfların tam adını yazmak yerine dosyanın en üstüne bunu ekleriz:
using School; 
using School.Education;

namespace CSharpTutorials
{
    class Program-Pratik
    {
        void Deneme()
        {
            // 'using' eklediğimiz için artık doğrudan sınıf isimlerini yazabiliriz:
            Student std = new Student();
            Teacher tchr = new Teacher();
        }
    }
}
*/