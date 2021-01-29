using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için tmel kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici yetiştirme kampı", "Programlamaya başlangıç için tmel kurs", "Java", "Phyton" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
