using System;

namespace ClassIntro3
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Eda";
            int yaş = 19;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.izlenmeOranı = 68;


            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.izlenmeOranı = 64;


            kurs kurs3 = new kurs();
            kurs3.kursAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.izlenmeOranı = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Eğitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Eğitmen);

            }





            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int izlenmeOranı { get; set; }


    }
       
}
