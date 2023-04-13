using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //string aciklama = "Amasya elması";
            //int fiyat = 20;
            //int stokAdedi = 54;

            //string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 20;
            urun1.StokAdedi = 48;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyati = 80;
            urun2.StokAdedi = 32;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.StokAdedi);
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Efsane armut", 22, 87);
        }
    }
}
