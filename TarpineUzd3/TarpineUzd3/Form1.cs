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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Rankine> rankiniu_sarasas = new List<Rankine>();

        Rankine rankine1 = new Rankine("Ruda rankinė 8x15x20", 17, "S");
        Rankine rankine2 = new Rankine("Juoda rankinė 8x18x42", 29, "S");
        Rankine rankine3 = new Rankine("Smėlinė rankinė 10x32x55", 35, "S");

        List<Kuprine> kupriniu_sarasas = new List<Kuprine>();

        Kuprine kuprine1 = new Kuprine("Raudona kuprinė 15x30x50", 39, "M");
        Kuprine kuprine2 = new Kuprine("Mėlyna kuprinė 15x32x55", 45, "M");
        Kuprine kuprine3 = new Kuprine("Juoda kuprinė 18x35x61", 59, "M");

        List<Lagaminas> lagaminu_sarasas = new List<Lagaminas>();

        Lagaminas lagaminas1 = new Lagaminas("Juodas lagaminas 32x32x55", 39, "L");
        Lagaminas lagaminas2 = new Lagaminas("Pilkas lagaminas 35x35x60", 45, "L");
        Lagaminas lagaminas3 = new Lagaminas("Raudonas lagaminas 37x35x61", 59, "L");

        Font defaultFont = SystemFonts.DefaultFont;
        string dydis = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rankines.Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);
            kuprines.Font = defaultFont;
            lagaminai.Font = defaultFont;

            preke.Items.Clear();
            rankiniu_sarasas.Clear();
            rankiniu_sarasas.Add(rankine1);
            rankiniu_sarasas.Add(rankine2);
            rankiniu_sarasas.Add(rankine3);
            
            foreach (var item in rankiniu_sarasas)
            {
                preke.Items.Add(item.Pavadinimas);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rankines.Font = defaultFont;
            kuprines.Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);
            lagaminai.Font = defaultFont;

            preke.Items.Clear();
            kupriniu_sarasas.Clear();
            kupriniu_sarasas.Add(kuprine1);
            kupriniu_sarasas.Add(kuprine2);
            kupriniu_sarasas.Add(kuprine3);

            foreach (var item in kupriniu_sarasas)
            {
                preke.Items.Add(item.Pavadinimas);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rankines.Font = defaultFont;
            kuprines.Font = defaultFont;
            lagaminai.Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);

            preke.Items.Clear();
            lagaminu_sarasas.Clear();
            lagaminu_sarasas.Add(lagaminas1);
            lagaminu_sarasas.Add(lagaminas2);
            lagaminu_sarasas.Add(lagaminas3);

            foreach (var item in lagaminu_sarasas)
            {
                preke.Items.Add(item.Pavadinimas);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (preke.SelectedItem.ToString() == rankine1.Pavadinimas)
            {
                kaina.Text = rankine1.Kaina.ToString();
                dydis = rankine1.Dydis;
            }
            else if (preke.SelectedItem.ToString() == rankine2.Pavadinimas)
            {
                kaina.Text = rankine2.Kaina.ToString();
                dydis = rankine2.Dydis;
            }
            else if (preke.SelectedItem.ToString() == rankine3.Pavadinimas)
            {
                kaina.Text = rankine3.Kaina.ToString();
                dydis = rankine3.Dydis;
            }
            else if (preke.SelectedItem.ToString() == kuprine1.Pavadinimas)
            {
                kaina.Text = kuprine1.Kaina.ToString();
                dydis = kuprine1.Dydis;
            }
            else if (preke.SelectedItem.ToString() == kuprine2.Pavadinimas)
            {
                kaina.Text = kuprine2.Kaina.ToString();
                dydis = kuprine2.Dydis;
            }
            else if (preke.SelectedItem.ToString() == kuprine3.Pavadinimas)
            {
                kaina.Text = kuprine3.Kaina.ToString();
                dydis = kuprine3.Dydis;
            }
            else if (preke.SelectedItem.ToString() == lagaminas1.Pavadinimas)
            {
                kaina.Text = lagaminas1.Kaina.ToString();
                dydis = lagaminas1.Dydis;
            }
            else if (preke.SelectedItem.ToString() == lagaminas2.Pavadinimas)
            {
                kaina.Text = lagaminas2.Kaina.ToString();
                dydis = lagaminas2.Dydis;
            }
            else if (preke.SelectedItem.ToString() == lagaminas3.Pavadinimas)
            {
                kaina.Text = lagaminas3.Kaina.ToString();
                dydis = lagaminas3.Dydis;
            }
            else
            {
                kaina.Text = "0";
            }
            suma.Text = "";
            kiekis.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (kiekis.Text.Length > 0)
            {
                suma.Text = (Convert.ToDouble(kiekis.Text) * Convert.ToDouble(kaina.Text)).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] masyvas = new string[5];
            masyvas[0] = preke.SelectedItem.ToString();
            masyvas[1] = dydis;
            masyvas[2] = kaina.Text;
            masyvas[3] = kiekis.Text;
            masyvas[4] = suma.Text;

            ListViewItem prekiuSarasas = new ListViewItem(masyvas[0]);

            prekiuSarasas.SubItems.Add(masyvas[1]);
            prekiuSarasas.SubItems.Add(masyvas[2]);
            prekiuSarasas.SubItems.Add(masyvas[3]);
            prekiuSarasas.SubItems.Add(masyvas[4]);
            prekiu_krepselis.Items.Add(prekiuSarasas);
            
            visoForm1.Text = (Convert.ToDouble(visoForm1.Text) + Convert.ToDouble(suma.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (prekiu_krepselis.SelectedItems.Count > 0)
            {
                for (int i = 0; i < prekiu_krepselis.Items.Count; i++)
                {
                    if (prekiu_krepselis.Items[i].Selected)
                    {
                        visoForm1.Text = (Convert.ToDouble(visoForm1.Text) - Convert.ToDouble(prekiu_krepselis.Items[i].SubItems[4].Text)).ToString();
                        prekiu_krepselis.Items[i].Remove();
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void viso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(prekiu_krepselis, visoForm1.Text);

            form2.Width = this.Width;
            form2.Height = this.Height;

            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Location.X, this.Location.Y);

            this.Visible = false;

            form2.ShowDialog();

            this.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }    
    }
}
