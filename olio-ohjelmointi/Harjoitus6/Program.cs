using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();

            Koira koira1 = new Koira("Mopsi", 3);
            Koira koira2 = new Koira("Saksanpaimenkoira", 7);
            Kissa kissa1 = new Kissa("Mainecoon", 5);
            Kissa kissa2 = new Kissa("Ragdoll", 12);

            kissa1.Ääntele();
            koira1.Ääntele();
            
            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Koira.KuinkaMonta();

            kissa2.Ääntele();
            koira2.Ääntele();
        }
    }
}
