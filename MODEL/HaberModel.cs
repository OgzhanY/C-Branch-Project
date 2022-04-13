using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class HaberModel
    {
        public int HaberID { get; set; }
        public int HaberKatID { get; set; }
        public int Haber_O_Sayisi { get; set; }
        public string HaberBaslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
    }
}
