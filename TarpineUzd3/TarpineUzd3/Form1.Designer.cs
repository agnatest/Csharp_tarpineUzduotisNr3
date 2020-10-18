namespace TarpineUzd3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rankines = new System.Windows.Forms.RadioButton();
            this.kuprines = new System.Windows.Forms.RadioButton();
            this.lagaminai = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.preke = new System.Windows.Forms.ComboBox();
            this.prekiu_krepselis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kiekis = new System.Windows.Forms.TextBox();
            this.kaina = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.TextBox();
            this.prideti_preke = new System.Windows.Forms.Button();
            this.naikinti_preke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visoForm1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // rankines
            // 
            this.rankines.AutoSize = true;
            this.rankines.Location = new System.Drawing.Point(73, 80);
            this.rankines.Name = "rankines";
            this.rankines.Size = new System.Drawing.Size(88, 21);
            this.rankines.TabIndex = 0;
            this.rankines.TabStop = true;
            this.rankines.Text = "Rankinės";
            this.rankines.UseVisualStyleBackColor = true;
            this.rankines.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // kuprines
            // 
            this.kuprines.AutoSize = true;
            this.kuprines.Location = new System.Drawing.Point(73, 107);
            this.kuprines.Name = "kuprines";
            this.kuprines.Size = new System.Drawing.Size(85, 21);
            this.kuprines.TabIndex = 1;
            this.kuprines.TabStop = true;
            this.kuprines.Text = "Kuprinės";
            this.kuprines.UseVisualStyleBackColor = true;
            this.kuprines.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lagaminai
            // 
            this.lagaminai.AutoSize = true;
            this.lagaminai.Location = new System.Drawing.Point(73, 134);
            this.lagaminai.Name = "lagaminai";
            this.lagaminai.Size = new System.Drawing.Size(94, 21);
            this.lagaminai.TabIndex = 3;
            this.lagaminai.TabStop = true;
            this.lagaminai.Text = "Lagaminai";
            this.lagaminai.UseVisualStyleBackColor = true;
            this.lagaminai.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bag MiniShop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // preke
            // 
            this.preke.FormattingEnabled = true;
            this.preke.Location = new System.Drawing.Point(185, 189);
            this.preke.Name = "preke";
            this.preke.Size = new System.Drawing.Size(255, 24);
            this.preke.TabIndex = 5;
            this.preke.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // prekiu_krepselis
            // 
            this.prekiu_krepselis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.prekiu_krepselis.FullRowSelect = true;
            this.prekiu_krepselis.GridLines = true;
            this.prekiu_krepselis.HideSelection = false;
            this.prekiu_krepselis.Location = new System.Drawing.Point(36, 354);
            this.prekiu_krepselis.Name = "prekiu_krepselis";
            this.prekiu_krepselis.Size = new System.Drawing.Size(470, 200);
            this.prekiu_krepselis.TabIndex = 10;
            this.prekiu_krepselis.UseCompatibleStateImageBehavior = false;
            this.prekiu_krepselis.View = System.Windows.Forms.View.Details;
            this.prekiu_krepselis.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prekė";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dydis";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kaina";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kiekis";
            this.columnHeader4.Width = 70;
            // 
            // kiekis
            // 
            this.kiekis.Location = new System.Drawing.Point(93, 249);
            this.kiekis.Name = "kiekis";
            this.kiekis.Size = new System.Drawing.Size(100, 22);
            this.kiekis.TabIndex = 7;
            this.kiekis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kaina
            // 
            this.kaina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.kaina.Enabled = false;
            this.kaina.Location = new System.Drawing.Point(249, 249);
            this.kaina.Name = "kaina";
            this.kaina.Size = new System.Drawing.Size(100, 22);
            this.kaina.TabIndex = 8;
            this.kaina.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // suma
            // 
            this.suma.Enabled = false;
            this.suma.Location = new System.Drawing.Point(406, 249);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(100, 22);
            this.suma.TabIndex = 9;
            this.suma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // prideti_preke
            // 
            this.prideti_preke.Location = new System.Drawing.Point(291, 298);
            this.prideti_preke.Name = "prideti_preke";
            this.prideti_preke.Size = new System.Drawing.Size(107, 30);
            this.prideti_preke.TabIndex = 10;
            this.prideti_preke.Text = "Pridėti prekę";
            this.prideti_preke.UseVisualStyleBackColor = true;
            this.prideti_preke.Click += new System.EventHandler(this.button1_Click);
            // 
            // naikinti_preke
            // 
            this.naikinti_preke.Location = new System.Drawing.Point(404, 298);
            this.naikinti_preke.Name = "naikinti_preke";
            this.naikinti_preke.Size = new System.Drawing.Size(102, 30);
            this.naikinti_preke.TabIndex = 11;
            this.naikinti_preke.Text = "Naikinti prekę";
            this.naikinti_preke.UseVisualStyleBackColor = true;
            this.naikinti_preke.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kiekis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kaina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Suma";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pasirinkti prekę:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // visoForm1
            // 
            this.visoForm1.Enabled = false;
            this.visoForm1.Location = new System.Drawing.Point(406, 578);
            this.visoForm1.Name = "visoForm1";
            this.visoForm1.Size = new System.Drawing.Size(100, 22);
            this.visoForm1.TabIndex = 16;
            this.visoForm1.Text = "0";
            this.visoForm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.visoForm1.TextChanged += new System.EventHandler(this.viso_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(354, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Viso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pirkti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Išeiti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Suma";
            this.columnHeader5.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.visoForm1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naikinti_preke);
            this.Controls.Add(this.prideti_preke);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.kaina);
            this.Controls.Add(this.kiekis);
            this.Controls.Add(this.prekiu_krepselis);
            this.Controls.Add(this.preke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lagaminai);
            this.Controls.Add(this.kuprines);
            this.Controls.Add(this.rankines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rankines;
        private System.Windows.Forms.RadioButton kuprines;
        private System.Windows.Forms.RadioButton lagaminai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox preke;
        private System.Windows.Forms.TextBox kiekis;
        private System.Windows.Forms.TextBox kaina;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.Button prideti_preke;
        private System.Windows.Forms.Button naikinti_preke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView prekiu_krepselis;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.TextBox visoForm1;
    }
}

