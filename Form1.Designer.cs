namespace PSO_Algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownC2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaksIterasyon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUstSinir = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAltSinir = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKararDegiskeni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownParcacikSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBestFitness = new System.Windows.Forms.TextBox();
            this.textBoxBestSolution = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksIterasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUstSinir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltSinir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKararDegiskeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParcacikSayisi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parçacık Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Karar Değişkeni (D):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.numericUpDownC2);
            this.groupBox1.Controls.Add(this.numericUpDownC1);
            this.groupBox1.Controls.Add(this.numericUpDownMaksIterasyon);
            this.groupBox1.Controls.Add(this.numericUpDownUstSinir);
            this.groupBox1.Controls.Add(this.numericUpDownAltSinir);
            this.groupBox1.Controls.Add(this.numericUpDownKararDegiskeni);
            this.groupBox1.Controls.Add(this.numericUpDownParcacikSayisi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 330);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Parametreleri";
            // 
            // numericUpDownC2
            // 
            this.numericUpDownC2.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownC2.Location = new System.Drawing.Point(732, 216);
            this.numericUpDownC2.Name = "numericUpDownC2";
            this.numericUpDownC2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownC2.TabIndex = 12;
            // 
            // numericUpDownC1
            // 
            this.numericUpDownC1.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownC1.Location = new System.Drawing.Point(732, 148);
            this.numericUpDownC1.Name = "numericUpDownC1";
            this.numericUpDownC1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownC1.TabIndex = 11;
            // 
            // numericUpDownMaksIterasyon
            // 
            this.numericUpDownMaksIterasyon.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownMaksIterasyon.Location = new System.Drawing.Point(732, 85);
            this.numericUpDownMaksIterasyon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaksIterasyon.Name = "numericUpDownMaksIterasyon";
            this.numericUpDownMaksIterasyon.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMaksIterasyon.TabIndex = 10;
            // 
            // numericUpDownUstSinir
            // 
            this.numericUpDownUstSinir.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownUstSinir.Location = new System.Drawing.Point(279, 244);
            this.numericUpDownUstSinir.Name = "numericUpDownUstSinir";
            this.numericUpDownUstSinir.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownUstSinir.TabIndex = 9;
            // 
            // numericUpDownAltSinir
            // 
            this.numericUpDownAltSinir.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownAltSinir.Location = new System.Drawing.Point(279, 180);
            this.numericUpDownAltSinir.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAltSinir.Name = "numericUpDownAltSinir";
            this.numericUpDownAltSinir.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAltSinir.TabIndex = 8;
            // 
            // numericUpDownKararDegiskeni
            // 
            this.numericUpDownKararDegiskeni.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownKararDegiskeni.Location = new System.Drawing.Point(279, 117);
            this.numericUpDownKararDegiskeni.Name = "numericUpDownKararDegiskeni";
            this.numericUpDownKararDegiskeni.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKararDegiskeni.TabIndex = 7;
            // 
            // numericUpDownParcacikSayisi
            // 
            this.numericUpDownParcacikSayisi.BackColor = System.Drawing.Color.MediumPurple;
            this.numericUpDownParcacikSayisi.Location = new System.Drawing.Point(279, 59);
            this.numericUpDownParcacikSayisi.Name = "numericUpDownParcacikSayisi";
            this.numericUpDownParcacikSayisi.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownParcacikSayisi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(493, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğrenme Faktörü c2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(493, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Öğrenme Faktörü c1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(493, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maks. İterasyon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üst Sınır:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alt Sınır:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxBestFitness);
            this.groupBox2.Controls.Add(this.textBoxBestSolution);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(25, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1052, 330);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // textBoxBestFitness
            // 
            this.textBoxBestFitness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBestFitness.Location = new System.Drawing.Point(279, 221);
            this.textBoxBestFitness.Multiline = true;
            this.textBoxBestFitness.Name = "textBoxBestFitness";
            this.textBoxBestFitness.Size = new System.Drawing.Size(120, 32);
            this.textBoxBestFitness.TabIndex = 4;
            // 
            // textBoxBestSolution
            // 
            this.textBoxBestSolution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxBestSolution.Location = new System.Drawing.Point(279, 99);
            this.textBoxBestSolution.Multiline = true;
            this.textBoxBestSolution.Name = "textBoxBestSolution";
            this.textBoxBestSolution.Size = new System.Drawing.Size(120, 32);
            this.textBoxBestSolution.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(615, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 273);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(40, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "En İyi Uygunluk (f(x)):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(40, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "En İyi Çözüm:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(304, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(275, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(508, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "PARÇACIK SÜRÜ OPTİMİZASYONU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Yakınsama Grafiği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1125, 878);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "213311078   NESLİHAN CAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksIterasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUstSinir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltSinir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKararDegiskeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParcacikSayisi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownC1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaksIterasyon;
        private System.Windows.Forms.NumericUpDown numericUpDownUstSinir;
        private System.Windows.Forms.NumericUpDown numericUpDownAltSinir;
        private System.Windows.Forms.NumericUpDown numericUpDownKararDegiskeni;
        private System.Windows.Forms.NumericUpDown numericUpDownParcacikSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownC2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxBestFitness;
        private System.Windows.Forms.TextBox textBoxBestSolution;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

