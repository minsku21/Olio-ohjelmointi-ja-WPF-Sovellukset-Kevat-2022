using System;
using System.Collections.Generic;
using System.Text;

namespace SM_Liiga
{
    class Joukkue
    {
        public string Nimi;
        public string Kotikaupunki;
        Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();

        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
        }

        public Pelaaja HaePelaaja(int numero)
        {
            if (pelaajat.ContainsKey(numero))
            {
                return pelaajat[numero];
            }
            else
            {
                return null;
            }
        }
        public void LisääPelaaja(Pelaaja pelaaja)
        {
            pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
        }
        public void PoistaPelaaja(Pelaaja pelaaja)
        {
            pelaajat.Remove(pelaaja.PelaajaNumero);
        }
        public List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> Temp = new List<Pelaaja>();

            foreach (var item in pelaajat.Values)
            {
                Temp.Add(item);
            }

            return Temp;
        }
    }
}
