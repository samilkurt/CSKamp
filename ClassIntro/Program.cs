using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ali";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Şamil Kurt";
            kurs1.IzlenmeOrani = 489;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Şamil Kurt";
            kurs2.IzlenmeOrani = 324;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C";
            kurs3.Egitmen = "Şamil Kurt";
            kurs3.IzlenmeOrani = 873;

            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in Kurslar)
            {
                Console.WriteLine("Kurs adı: " + kurs.KursAdi+" " + "Eğitmen: " + kurs.Egitmen +" " + "İzlenme Oranı: " + kurs.IzlenmeOrani);
            }
        }
    }
    class Kurs 
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
