using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TarpineUzd3
{
    public class Preke
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public string Dydis { get; set; }

        public Preke(string pavadinimas, double kaina, string dydis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Dydis = dydis;
        }
    }
    public class Rankine : Preke 
    { 
        public Rankine(string pavadinimas, float kaina, string dydis) : base(pavadinimas, kaina, dydis)
        {

        }
    }

    public class Kuprine : Preke
    {
        public Kuprine(string pavadinimas, float kaina, string dydis) : base(pavadinimas, kaina, dydis)
        {

        }
    }

    public class Lagaminas : Preke
    {
        public Lagaminas(string pavadinimas, float kaina, string dydis) : base(pavadinimas, kaina, dydis)
        {

        }
    }

}
