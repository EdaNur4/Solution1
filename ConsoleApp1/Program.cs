using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalıi butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }






            if (sistemGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.Write(kategoriEtiketi);

            

            

            




        }
    }
}

