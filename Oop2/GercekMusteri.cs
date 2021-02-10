using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class GercekMusteri : Musteri     //İndivicual   //Bu nir entities dir operasyon yazılmaz burda
                   //Burda Musteri ebevyndir   //Buna İnheritence mirastır
    {
       
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
