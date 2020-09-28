namespace rent_a_car
{
    partial class AracIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbYakıt = new System.Windows.Forms.ComboBox();
            this.cbVites = new System.Windows.Forms.ComboBox();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.tbYıl = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbHasaryok = new System.Windows.Forms.RadioButton();
            this.rbHasarVar = new System.Windows.Forms.RadioButton();
            this.cbKasa = new System.Windows.Forms.ComboBox();
            this.cbCekis = new System.Windows.Forms.ComboBox();
            this.cbHasar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbkapı = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbYakıt);
            this.groupBox1.Controls.Add(this.cbVites);
            this.groupBox1.Controls.Add(this.cbMotor);
            this.groupBox1.Controls.Add(this.tbKM);
            this.groupBox1.Controls.Add(this.tbYıl);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbMarka);
            this.groupBox1.Controls.Add(this.tbPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Temel Bilgiler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbYakıt
            // 
            this.cbYakıt.FormattingEnabled = true;
            this.cbYakıt.Items.AddRange(new object[] {
            "Benzin",
            "Lpg",
            "IPG",
            "Hibrit"});
            this.cbYakıt.Location = new System.Drawing.Point(309, 155);
            this.cbYakıt.Name = "cbYakıt";
            this.cbYakıt.Size = new System.Drawing.Size(257, 21);
            this.cbYakıt.TabIndex = 23;
            this.cbYakıt.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbVites
            // 
            this.cbVites.FormattingEnabled = true;
            this.cbVites.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.cbVites.Location = new System.Drawing.Point(309, 190);
            this.cbVites.Name = "cbVites";
            this.cbVites.Size = new System.Drawing.Size(257, 21);
            this.cbVites.TabIndex = 22;
            this.cbVites.SelectedIndexChanged += new System.EventHandler(this.cbVites_SelectedIndexChanged);
            // 
            // cbMotor
            // 
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Items.AddRange(new object[] {
            "1000CC",
            "2000CC",
            "3000CC",
            "4000CC",
            "5000CC",
            ">5000CC"});
            this.cbMotor.Location = new System.Drawing.Point(309, 248);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(257, 21);
            this.cbMotor.TabIndex = 21;
            // 
            // tbKM
            // 
            this.tbKM.Location = new System.Drawing.Point(309, 222);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(257, 20);
            this.tbKM.TabIndex = 19;
            // 
            // tbYıl
            // 
            this.tbYıl.Location = new System.Drawing.Point(309, 122);
            this.tbYıl.Name = "tbYıl";
            this.tbYıl.Size = new System.Drawing.Size(257, 20);
            this.tbYıl.TabIndex = 16;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(309, 96);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(257, 20);
            this.tbModel.TabIndex = 15;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(309, 69);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(257, 20);
            this.tbMarka.TabIndex = 14;
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(309, 37);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(257, 20);
            this.tbPlaka.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(214, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Motor Gücü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(240, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Son KM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(258, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vites:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(258, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Yakıt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(275, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yıl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(253, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(252, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plaka:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Resim Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 196);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.rbHasaryok);
            this.groupBox2.Controls.Add(this.rbHasarVar);
            this.groupBox2.Controls.Add(this.cbKasa);
            this.groupBox2.Controls.Add(this.cbCekis);
            this.groupBox2.Controls.Add(this.cbHasar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbkapı);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(676, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ehliyet/Diğer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = " Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbHasaryok
            // 
            this.rbHasaryok.AutoSize = true;
            this.rbHasaryok.Location = new System.Drawing.Point(246, 209);
            this.rbHasaryok.Name = "rbHasaryok";
            this.rbHasaryok.Size = new System.Drawing.Size(44, 17);
            this.rbHasaryok.TabIndex = 24;
            this.rbHasaryok.TabStop = true;
            this.rbHasaryok.Text = "Yok";
            this.rbHasaryok.UseVisualStyleBackColor = true;
            this.rbHasaryok.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbHasarVar
            // 
            this.rbHasarVar.AutoSize = true;
            this.rbHasarVar.Location = new System.Drawing.Point(155, 207);
            this.rbHasarVar.Name = "rbHasarVar";
            this.rbHasarVar.Size = new System.Drawing.Size(41, 17);
            this.rbHasarVar.TabIndex = 24;
            this.rbHasarVar.TabStop = true;
            this.rbHasarVar.Text = "Var";
            this.rbHasarVar.UseVisualStyleBackColor = true;
            // 
            // cbKasa
            // 
            this.cbKasa.FormattingEnabled = true;
            this.cbKasa.Items.AddRange(new object[] {
            "Yeni kasa",
            "Eski kasa"});
            this.cbKasa.Location = new System.Drawing.Point(100, 132);
            this.cbKasa.Name = "cbKasa";
            this.cbKasa.Size = new System.Drawing.Size(257, 21);
            this.cbKasa.TabIndex = 23;
            this.cbKasa.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // cbCekis
            // 
            this.cbCekis.FormattingEnabled = true;
            this.cbCekis.Items.AddRange(new object[] {
            "Ön çekiş",
            "Arka çekiş ",
            "4 *4"});
            this.cbCekis.Location = new System.Drawing.Point(100, 56);
            this.cbCekis.Name = "cbCekis";
            this.cbCekis.Size = new System.Drawing.Size(257, 21);
            this.cbCekis.TabIndex = 23;
            // 
            // cbHasar
            // 
            this.cbHasar.FormattingEnabled = true;
            this.cbHasar.Items.AddRange(new object[] {
            "Beyaz",
            "Siyah",
            "Kırmızı",
            "Sarı",
            "Lacivert",
            "Gri"});
            this.cbHasar.Location = new System.Drawing.Point(100, 167);
            this.cbHasar.Name = "cbHasar";
            this.cbHasar.Size = new System.Drawing.Size(257, 21);
            this.cbHasar.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(49, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Kasa";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cbkapı
            // 
            this.cbkapı.FormattingEnabled = true;
            this.cbkapı.Items.AddRange(new object[] {
            "4 kapı standart",
            "tek kapı"});
            this.cbkapı.Location = new System.Drawing.Point(100, 91);
            this.cbkapı.Name = "cbkapı";
            this.cbkapı.Size = new System.Drawing.Size(257, 21);
            this.cbkapı.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(49, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 10;
            this.label13.Text = "Hasar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(49, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Renk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(49, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Çekiş";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(49, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Kapı";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AracIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AracIslemleri";
            this.Text = "AracIslemleri";
            this.Load += new System.EventHandler(this.AracIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbYakıt;
        private System.Windows.Forms.ComboBox cbVites;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.TextBox tbYıl;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbKasa;
        private System.Windows.Forms.ComboBox cbCekis;
        private System.Windows.Forms.ComboBox cbHasar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbkapı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbHasaryok;
        private System.Windows.Forms.RadioButton rbHasarVar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}