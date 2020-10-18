using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TarpineUzd3
{
    public partial class Form2 : Form
    {

        public ListView _prekiu_krepselis { get; set; }
        

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ListView prekiu_krepselis, string visoForm1)
        {
            _prekiu_krepselis = prekiu_krepselis;
            InitializeComponent();

            siuntimoBudas.Items.Add("Siuntimas Lietuvoje paštu");
            siuntimoBudas.Items.Add("Siuntimas Lietuvoje kurjeriu");
            siuntimoBudas.Items.Add("Siuntimas Lietuvoje paštomatu");
            siuntimoBudas.Items.Add("Siuntimas į užsienį paštu");

            prekiuSuma.Text = visoForm1;
        }

        List<Siunta> siuntuS_sarasas = new List<Siunta>();

        STipas siuntaS1 = new STipas("Siuntimas Lietuvoje paštu", "S", 2.59);
        STipas siuntaS2 = new STipas("Siuntimas Lietuvoje kurjeriu", "S", 3.99);
        STipas siuntaS3 = new STipas("Siuntimas Lietuvoje paštomatu", "S", 2.79);
        STipas siuntaS4 = new STipas("Siuntimas į užsienį paštu", "S", 4.59);

        List<Siunta> siuntuM_sarasas = new List<Siunta>();

        MTipas siuntaM1 = new MTipas("Siuntimas Lietuvoje paštu", "M", 3.39);
        MTipas siuntaM2 = new MTipas("Siuntimas Lietuvoje kurjeriu", "M", 4.99);
        MTipas siuntaM3 = new MTipas("Siuntimas Lietuvoje paštomatu", "M", 3.49);
        MTipas siuntaM4 = new MTipas("Siuntimas į užsienį paštu", "M", 5.49);

        List<Siunta> siuntuL_sarasas = new List<Siunta>();

        LTipas siuntaL1 = new LTipas("Siuntimas Lietuvoje paštu", "L", 4.29);
        LTipas siuntaL2 = new LTipas("Siuntimas Lietuvoje kurjeriu", "L", 6.69);
        LTipas siuntaL3 = new LTipas("Siuntimas Lietuvoje paštomatu", "L", 4.39);
        LTipas siuntaL4 = new LTipas("Siuntimas į užsienį paštu", "L", 7.89);

        Font defaultFont = SystemFonts.DefaultFont;
        double siuntosKaina = 0;
        int siuntuKiekis = 0;
        double siuntuSuma = 0;
        string dydis = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            prekiu_paslaugu_krepselis.Items.AddRange((
                from ListViewItem item in _prekiu_krepselis.Items
                select (ListViewItem)item.Clone()).ToArray());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0; i<_prekiu_krepselis.Items.Count;i++)
            {
                if ((siuntimoBudas.SelectedItem.ToString() == siuntaS1.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaS1.Tipas))
                {
                    siuntosKaina = siuntaS1.Kaina;
                    dydis = siuntaS1.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaS1.Kaina * siuntuKiekis;
                   
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaS2.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaS2.Tipas))
                {
                    siuntosKaina = siuntaS2.Kaina;
                    dydis = siuntaS2.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaS2.Kaina * siuntuKiekis;
                    
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaS3.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaS3.Tipas))
                {
                    siuntosKaina = siuntaS3.Kaina;
                    dydis = siuntaS3.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaS3.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaS4.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaS4.Tipas))
                {
                    siuntosKaina = siuntaS4.Kaina;
                    dydis = siuntaS4.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaS4.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaM1.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaM1.Tipas))
                {
                    siuntosKaina = siuntaM1.Kaina;
                    dydis = siuntaM1.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaM1.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaM2.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaM2.Tipas))
                {
                    siuntosKaina = siuntaM2.Kaina;
                    dydis = siuntaM2.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaM2.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaM3.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaM3.Tipas))
                {
                    siuntosKaina = siuntaM3.Kaina;
                    dydis = siuntaM3.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaM3.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaM4.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaM4.Tipas))
                {
                    siuntosKaina = siuntaM4.Kaina;
                    dydis = siuntaM4.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaM4.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaL1.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaL1.Tipas))
                {
                    siuntosKaina = siuntaL1.Kaina;
                    dydis = siuntaL1.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaL1.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaL2.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaL2.Tipas))
                {
                    siuntosKaina = siuntaL2.Kaina;
                    dydis = siuntaL2.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaL2.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaL3.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaL3.Tipas))
                {
                    siuntosKaina = siuntaL3.Kaina;
                    dydis = siuntaL3.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaL3.Kaina * siuntuKiekis;
                }
                else if ((siuntimoBudas.SelectedItem.ToString() == siuntaL4.Pavadinimas) && (_prekiu_krepselis.Items[i].SubItems[1].Text == siuntaL4.Tipas))
                {
                    siuntosKaina = siuntaL4.Kaina;
                    dydis = siuntaL4.Tipas;
                    siuntuKiekis = Convert.ToInt32(_prekiu_krepselis.Items[i].SubItems[3].Text);
                    siuntuSuma = siuntaL4.Kaina * siuntuKiekis;
                }
                else
                {
                    siuntosKainuSuma.Text = "0";
                }

                string[] masyvas = new string[5];

                masyvas[0] = siuntimoBudas.Text;
                masyvas[1] = dydis;
                masyvas[2] = siuntosKaina.ToString();
                masyvas[3] = siuntuKiekis.ToString();
                masyvas[4] = siuntuSuma.ToString();

                ListViewItem prekiuSarasas = new ListViewItem(masyvas[0]);

                prekiuSarasas.SubItems.Add(masyvas[1]);
                prekiuSarasas.SubItems.Add(masyvas[2]);
                prekiuSarasas.SubItems.Add(masyvas[3]);
                prekiuSarasas.SubItems.Add(masyvas[4]);
                prekiu_paslaugu_krepselis.Items.Add(prekiuSarasas);

                siuntosKainuSuma.Text = (Convert.ToDouble(siuntosKainuSuma.Text) + Convert.ToDouble(siuntuSuma)).ToString();
                visoForm2.Text =(Convert.ToDouble(siuntosKainuSuma.Text) + Convert.ToDouble(prekiuSuma.Text)).ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prekiuSuma_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (visoForm2.Text != "0")
            {
                MessageBox.Show("Apsipirkot !", "Sveikinu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nėra prekių krepšelyje \narba \nnėra nurodyto siuntimo būdo. \nBandykite dar kartą.", "Kažkas negerai", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
