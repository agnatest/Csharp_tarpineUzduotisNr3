using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarpineUzd3
{
    public class Siunta
    {
        public string Pavadinimas { get; set; }
        public string Tipas { get; set; }
        public double Kaina { get; }


        public Siunta(string pavadinimas, string tipas, double kaina)
        {
            Pavadinimas = pavadinimas;
            Tipas = tipas;
            Kaina = kaina;
        }
    }

    public class STipas : Siunta
    {
        public STipas(string pavadinimas, string tipas, double kaina) : base(pavadinimas, tipas, kaina)
        {

        }
    }

    public class MTipas : Siunta
    {
        public MTipas(string pavadinimas, string tipas, double kaina) : base(pavadinimas, tipas, kaina)
        {

        }
    }

    public class LTipas : Siunta
    {
        public LTipas(string pavadinimas, string tipas, double kaina) : base(pavadinimas, tipas, kaina)
        {

        }
    }
}
