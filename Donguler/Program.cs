using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "c#";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs","Java", "c#" };

            for (int i = 0; i < kurslar.Length;i++)//kursları dolaş.
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {

            }

            for
            Console.WriteLine("Sayfa sonu");
        }
    }
}
