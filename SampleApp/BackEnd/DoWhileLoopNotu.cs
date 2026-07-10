/*
===================================================================
 C# DO-WHILE LOOP (DO-WHILE DÖNGÜSÜ) — DERS NOTU
===================================================================

 Yapısı    : do { // kodlar... } while (koşul);
 Kural     : En sondaki 'while(koşul);' ifadesinin sonuna ';' konmalıdır.
 Farkı     : Koşul yanlış (false) olsa bile blok en az 1 kez çalıştırılır.önce do sonra koşul


*/

using System;

namespace CSharpTutorials
{
    class DoWhileKullanimi
    {
        void StandartKullanim()
        {
            int i = 0;

            // Koşul sağlandığı sürece dönecek klasik yapı
            do
            {
                Console.WriteLine("i değeri: " + i);
                i++;
            } while (i < 5);
        }

        void GarantiTekCalisma()
        {
            int sayı = 100;

            // Koşul (sayı < 10) daha en baştan Yanlıştır (false).
            // Normal while döngüsü hiç çalışmazdı ama do-while burayı 1 kez çalıştırır.
            do
            {
                Console.WriteLine("Koşul yanlış olsa bile bu satır 1 kez ekrana yazılır!");
            } while (sayı < 10);
        }

        void BreakKullanimi()
        {
            int i = 0;

            do
            {
                Console.WriteLine("İçerideki i: " + i);
                i++;

                if (i > 3)
                {
                    break; // i 3'ü geçtiği an döngü sonundaki koşula bakılmaksızın kırılır.
                }

            } while (i < 10);
        }
    }
}
