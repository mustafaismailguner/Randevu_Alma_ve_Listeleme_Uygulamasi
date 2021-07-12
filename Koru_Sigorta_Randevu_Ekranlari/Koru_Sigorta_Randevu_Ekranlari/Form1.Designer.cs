
namespace Koru_Sigorta_Randevu_Ekranlari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.musteriRandevuTarihiDateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriPoliceNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriTCKimlikNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriIlceTextBox = new System.Windows.Forms.TextBox();
            this.musteriIlTextBox = new System.Windows.Forms.TextBox();
            this.musteriTelefonNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriSoyadTextBox = new System.Windows.Forms.TextBox();
            this.musteriAdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.musteriRandevuTarihiDateTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.musteriPoliceNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriTCKimlikNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriIlceTextBox);
            this.groupBox1.Controls.Add(this.musteriIlTextBox);
            this.groupBox1.Controls.Add(this.musteriTelefonNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriSoyadTextBox);
            this.groupBox1.Controls.Add(this.musteriAdTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(11, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(759, 65);
            this.button2.TabIndex = 24;
            this.button2.Text = "Randevu Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musteriRandevuTarihiDateTime
            // 
            this.musteriRandevuTarihiDateTime.CustomFormat = "     ";
            this.musteriRandevuTarihiDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.musteriRandevuTarihiDateTime.Location = new System.Drawing.Point(257, 345);
            this.musteriRandevuTarihiDateTime.Name = "musteriRandevuTarihiDateTime";
            this.musteriRandevuTarihiDateTime.Size = new System.Drawing.Size(513, 31);
            this.musteriRandevuTarihiDateTime.TabIndex = 2;
            this.musteriRandevuTarihiDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tarih :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Poliçe Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "T.C Kimlik Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "İlçe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "İl :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad :";
            // 
            // musteriPoliceNumarasiTextBox
            // 
            this.musteriPoliceNumarasiTextBox.Location = new System.Drawing.Point(257, 304);
            this.musteriPoliceNumarasiTextBox.Name = "musteriPoliceNumarasiTextBox";
            this.musteriPoliceNumarasiTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriPoliceNumarasiTextBox.TabIndex = 14;
            // 
            // musteriTCKimlikNumarasiTextBox
            // 
            this.musteriTCKimlikNumarasiTextBox.Location = new System.Drawing.Point(257, 261);
            this.musteriTCKimlikNumarasiTextBox.Name = "musteriTCKimlikNumarasiTextBox";
            this.musteriTCKimlikNumarasiTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriTCKimlikNumarasiTextBox.TabIndex = 13;
            // 
            // musteriIlceTextBox
            // 
            this.musteriIlceTextBox.Location = new System.Drawing.Point(257, 218);
            this.musteriIlceTextBox.Name = "musteriIlceTextBox";
            this.musteriIlceTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriIlceTextBox.TabIndex = 12;
            // 
            // musteriIlTextBox
            // 
            this.musteriIlTextBox.Location = new System.Drawing.Point(257, 175);
            this.musteriIlTextBox.Name = "musteriIlTextBox";
            this.musteriIlTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriIlTextBox.TabIndex = 11;
            // 
            // musteriTelefonNumarasiTextBox
            // 
            this.musteriTelefonNumarasiTextBox.Location = new System.Drawing.Point(257, 132);
            this.musteriTelefonNumarasiTextBox.Name = "musteriTelefonNumarasiTextBox";
            this.musteriTelefonNumarasiTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriTelefonNumarasiTextBox.TabIndex = 10;
            this.musteriTelefonNumarasiTextBox.Text = "0";
            // 
            // musteriSoyadTextBox
            // 
            this.musteriSoyadTextBox.Location = new System.Drawing.Point(257, 89);
            this.musteriSoyadTextBox.Name = "musteriSoyadTextBox";
            this.musteriSoyadTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriSoyadTextBox.TabIndex = 9;
            // 
            // musteriAdTextBox
            // 
            this.musteriAdTextBox.Location = new System.Drawing.Point(257, 46);
            this.musteriAdTextBox.Name = "musteriAdTextBox";
            this.musteriAdTextBox.Size = new System.Drawing.Size(513, 31);
            this.musteriAdTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(794, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yönetici Ekranı \r\n=>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Koru Sigorta - Randevu Alma Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox musteriPoliceNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriTCKimlikNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriIlceTextBox;
        private System.Windows.Forms.TextBox musteriIlTextBox;
        private System.Windows.Forms.TextBox musteriTelefonNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriSoyadTextBox;
        private System.Windows.Forms.TextBox musteriAdTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker musteriRandevuTarihiDateTime;
        private System.Windows.Forms.Button button2;
    }
}

