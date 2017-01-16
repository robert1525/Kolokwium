using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacje
{
    class Podroz : IStacja
    {
        protected Queue<Stacja> stacje = new Queue<Stacja>();
        protected double koszt;

        public Podroz()
        {
            //trasa = new Queue<Stacja>();
        }

        public virtual double KosztPoRabacie()
        {
            return koszt * 0.85d;
        }

        public override string ToString()
        {
            string output = "Podróż:\n";
            foreach (var s in stacje)
                output += s.ToString() + '\n';
            return output + "Koszt po rabacie: " + KosztPoRabacie().ToString("2N");
        }

        public void DodajStacje(string nazwa, bool oplata)
        {
            stacje.Enqueue(new Stacja(nazwa, oplata));
            if (oplata)
                koszt += 22;
        }

        public void Powrot()
        {
            stacje.Enqueue((Stacja)stacje.Peek().Clone());
        }

        public void UsunStacje()
        {
            stacje.Dequeue();
        }

        public void ZapiszPodroz()
        {
            using (StreamWriter plik = new StreamWriter("podroz.txt", true))
            {
                foreach (string s in ToString().Split('\n'))
                    plik.WriteLine(s);
                plik.Close();
            }
        }
    }
}
