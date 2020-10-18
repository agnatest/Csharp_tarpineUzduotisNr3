namespace TarpineUzd3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.prekiu_paslaugu_krepselis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visoForm2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.siuntosKainuSuma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siuntimoBudas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prekiuSuma = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // prekiu_paslaugu_krepselis
            // 
            this.prekiu_paslaugu_krepselis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.prekiu_paslaugu_krepselis.FullRowSelect = true;
            this.prekiu_paslaugu_krepselis.GridLines = true;
            this.prekiu_paslaugu_krepselis.HideSelection = false;
            this.prekiu_paslaugu_krepselis.Location = new System.Drawing.Point(36, 152);
            this.prekiu_paslaugu_krepselis.Name = "prekiu_paslaugu_krepselis";
            this.prekiu_paslaugu_krepselis.Size = new System.Drawing.Size(470, 251);
            this.prekiu_paslaugu_krepselis.TabIndex = 10;
            this.prekiu_paslaugu_krepselis.UseCompatibleStateImageBehavior = false;
            this.prekiu_paslaugu_krepselis.View = System.Windows.Forms.View.Details;
            this.prekiu_paslaugu_krepselis.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prekė / paslauga";
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Suma";
            this.columnHeader5.Width = 80;
            // 
            // visoForm2
            // 
            this.visoForm2.Enabled = false;
            this.visoForm2.Location = new System.Drawing.Point(406, 485);
            this.visoForm2.Name = "visoForm2";
            this.visoForm2.Size = new System.Drawing.Size(100, 22);
            this.visoForm2.TabIndex = 16;
            this.visoForm2.Text = "0";
            this.visoForm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.visoForm2.TextChanged += new System.EventHandler(this.viso_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(356, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Viso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 616);
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
            // siuntosKainuSuma
            // 
            this.siuntosKainuSuma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.siuntosKainuSuma.Enabled = false;
            this.siuntosKainuSuma.Location = new System.Drawing.Point(406, 446);
            this.siuntosKainuSuma.Name = "siuntosKainuSuma";
            this.siuntosKainuSuma.Size = new System.Drawing.Size(100, 22);
            this.siuntosKainuSuma.TabIndex = 8;
            this.siuntosKainuSuma.Text = "0";
            this.siuntosKainuSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.siuntosKainuSuma.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Siuntos kainų suma:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // siuntimoBudas
            // 
            this.siuntimoBudas.FormattingEnabled = true;
            this.siuntimoBudas.Location = new System.Drawing.Point(228, 96);
            this.siuntimoBudas.Name = "siuntimoBudas";
            this.siuntimoBudas.Size = new System.Drawing.Size(255, 24);
            this.siuntimoBudas.TabIndex = 5;
            this.siuntimoBudas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pasirinkti siuntimo būdą:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prekių suma:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // prekiuSuma
            // 
            this.prekiuSuma.Enabled = false;
            this.prekiuSuma.Location = new System.Drawing.Point(406, 409);
            this.prekiuSuma.Name = "prekiuSuma";
            this.prekiuSuma.Size = new System.Drawing.Size(100, 22);
            this.prekiuSuma.TabIndex = 20;
            this.prekiuSuma.Text = "0";
            this.prekiuSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.prekiuSuma.TextChanged += new System.EventHandler(this.prekiuSuma_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 616);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "Grįžti";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 683);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prekiuSuma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.visoForm2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siuntosKainuSuma);
            this.Controls.Add(this.prekiu_paslaugu_krepselis);
            this.Controls.Add(this.siuntimoBudas);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox visoForm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox siuntosKainuSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox siuntimoBudas;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListView prekiu_paslaugu_krepselis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox prekiuSuma;
    }
}

