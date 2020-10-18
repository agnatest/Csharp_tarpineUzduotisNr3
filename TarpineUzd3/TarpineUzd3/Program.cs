using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarpineUzd3
{
    static class Program
    {
        // Tarpinė užduotis Nr3 - Agna Semaškaitė

        // Sukurti mini parduotuvės programą:
        // Parduotuvė turi turėti:
        // Prekes;
        // Prekių krepšelį;
        // Siuntas;
        // Siuntos turi būti Lietuvoje, siuntimas į namus per paštą, per kurjerius,
        // į paštomatą, tarptautinis siuntimas.
        // Siuntos turi gebėti apskaičiuoti siuntos kainą.
        // Siuntos kaina sudaro siuntos dydis + už kokią sumą yra perkama.
        // Automatinis nustatymas S, M, L tipo siuntos.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
