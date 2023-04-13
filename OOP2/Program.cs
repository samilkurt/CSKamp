using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Ali";
            musteri1.Id = 2;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.SirketAdi = "Avo";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
        }
    }
}
