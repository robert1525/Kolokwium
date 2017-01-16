using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacje
{
    class Stacja : ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;

        public Stacja(string nazwaStacji, bool oplataKlimatyczna)
        {
            this.nazwaStacji = nazwaStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;
        }

        public override string ToString()
        {
            return "Stacja: " + nazwaStacji + ", opłata klimatyczna: " + (oplataKlimatyczna ? "tak" : "nie") + '.';
        }

        public bool JakaOplata()
        {
            return oplataKlimatyczna;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
