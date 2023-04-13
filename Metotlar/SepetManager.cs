using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler, sepete eklendi.");
        }

        public void Ekle2(string urunAdı, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler, sepete eklendi." + urunAdı);
        }
    }
}
