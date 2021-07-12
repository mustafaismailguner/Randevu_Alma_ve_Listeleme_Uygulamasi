
namespace Koru_Sigorta_Randevu_Ekranlari
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.koru_Sigorta_Randevu_DBDataSet = new Koru_Sigorta_Randevu_Ekranlari.Koru_Sigorta_Randevu_DBDataSet();
            this.koruSigortaRandevuDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TarihCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.musteriRandevuTarihiDateTime = new System.Windows.Forms.DateTimePicker();
            this.musteriPoliceNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriTCKimlikNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriIlceTextBox = new System.Windows.Forms.TextBox();
            this.musteriIlTextBox = new System.Windows.Forms.TextBox();
            this.musteriTelefonNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.musteriSoyadTextBox = new System.Windows.Forms.TextBox();
            this.musteriAdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchDateTime2 = new System.Windows.Forms.DateTimePicker();
            this.searchDateTime1 = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koru_Sigorta_Randevu_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koruSigortaRandevuDBDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1347, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randevuları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1347, 487);
            this.dataGridView1.TabIndex = 1;
            // 
            // koru_Sigorta_Randevu_DBDataSet
            // 
            this.koru_Sigorta_Randevu_DBDataSet.DataSetName = "Koru_Sigorta_Randevu_DBDataSet";
            this.koru_Sigorta_Randevu_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // koruSigortaRandevuDBDataSetBindingSource
            // 
            this.koruSigortaRandevuDBDataSetBindingSource.DataSource = this.koru_Sigorta_Randevu_DBDataSet;
            this.koruSigortaRandevuDBDataSetBindingSource.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 593);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1359, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listeleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.TarihCheckBox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.searchDateTime2);
            this.tabPage2.Controls.Add(this.searchDateTime1);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.searchTextBox);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1359, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listeleme, Filtreleme ve Düzenleme";
            // 
            // TarihCheckBox
            // 
            this.TarihCheckBox.AutoSize = true;
            this.TarihCheckBox.Location = new System.Drawing.Point(13, 38);
            this.TarihCheckBox.Name = "TarihCheckBox";
            this.TarihCheckBox.Size = new System.Drawing.Size(132, 29);
            this.TarihCheckBox.TabIndex = 22;
            this.TarihCheckBox.Text = "Tarih Seç";
            this.TarihCheckBox.UseVisualStyleBackColor = true;
            this.TarihCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musteriRandevuTarihiDateTime);
            this.groupBox1.Controls.Add(this.musteriPoliceNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriTCKimlikNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriIlceTextBox);
            this.groupBox1.Controls.Add(this.musteriIlTextBox);
            this.groupBox1.Controls.Add(this.musteriTelefonNumarasiTextBox);
            this.groupBox1.Controls.Add(this.musteriSoyadTextBox);
            this.groupBox1.Controls.Add(this.musteriAdTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1014, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 540);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Kaydını Düzenle";
            // 
            // musteriRandevuTarihiDateTime
            // 
            this.musteriRandevuTarihiDateTime.CustomFormat = "";
            this.musteriRandevuTarihiDateTime.Location = new System.Drawing.Point(52, 499);
            this.musteriRandevuTarihiDateTime.Name = "musteriRandevuTarihiDateTime";
            this.musteriRandevuTarihiDateTime.Size = new System.Drawing.Size(287, 26);
            this.musteriRandevuTarihiDateTime.TabIndex = 27;
            // 
            // musteriPoliceNumarasiTextBox
            // 
            this.musteriPoliceNumarasiTextBox.Location = new System.Drawing.Point(52, 435);
            this.musteriPoliceNumarasiTextBox.Name = "musteriPoliceNumarasiTextBox";
            this.musteriPoliceNumarasiTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriPoliceNumarasiTextBox.TabIndex = 26;
            // 
            // musteriTCKimlikNumarasiTextBox
            // 
            this.musteriTCKimlikNumarasiTextBox.Location = new System.Drawing.Point(52, 371);
            this.musteriTCKimlikNumarasiTextBox.Name = "musteriTCKimlikNumarasiTextBox";
            this.musteriTCKimlikNumarasiTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriTCKimlikNumarasiTextBox.TabIndex = 25;
            // 
            // musteriIlceTextBox
            // 
            this.musteriIlceTextBox.Location = new System.Drawing.Point(52, 307);
            this.musteriIlceTextBox.Name = "musteriIlceTextBox";
            this.musteriIlceTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriIlceTextBox.TabIndex = 24;
            // 
            // musteriIlTextBox
            // 
            this.musteriIlTextBox.Location = new System.Drawing.Point(52, 243);
            this.musteriIlTextBox.Name = "musteriIlTextBox";
            this.musteriIlTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriIlTextBox.TabIndex = 23;
            // 
            // musteriTelefonNumarasiTextBox
            // 
            this.musteriTelefonNumarasiTextBox.Location = new System.Drawing.Point(52, 179);
            this.musteriTelefonNumarasiTextBox.Name = "musteriTelefonNumarasiTextBox";
            this.musteriTelefonNumarasiTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriTelefonNumarasiTextBox.TabIndex = 22;
            // 
            // musteriSoyadTextBox
            // 
            this.musteriSoyadTextBox.Location = new System.Drawing.Point(52, 115);
            this.musteriSoyadTextBox.Name = "musteriSoyadTextBox";
            this.musteriSoyadTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriSoyadTextBox.TabIndex = 21;
            // 
            // musteriAdTextBox
            // 
            this.musteriAdTextBox.Location = new System.Drawing.Point(52, 51);
            this.musteriAdTextBox.Name = "musteriAdTextBox";
            this.musteriAdTextBox.Size = new System.Drawing.Size(287, 26);
            this.musteriAdTextBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefon Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "İl :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "İlçe :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "T.C Kimlik Numarası :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Poliçe Numarası :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Randevu Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // searchDateTime2
            // 
            this.searchDateTime2.CustomFormat = "";
            this.searchDateTime2.Enabled = false;
            this.searchDateTime2.Location = new System.Drawing.Point(8, 228);
            this.searchDateTime2.Name = "searchDateTime2";
            this.searchDateTime2.Size = new System.Drawing.Size(341, 31);
            this.searchDateTime2.TabIndex = 9;
            this.searchDateTime2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // searchDateTime1
            // 
            this.searchDateTime1.CustomFormat = "";
            this.searchDateTime1.Enabled = false;
            this.searchDateTime1.Location = new System.Drawing.Point(8, 132);
            this.searchDateTime1.Name = "searchDateTime1";
            this.searchDateTime1.Size = new System.Drawing.Size(341, 31);
            this.searchDateTime1.TabIndex = 8;
            this.searchDateTime1.Value = new System.DateTime(2021, 7, 7, 12, 34, 28, 0);
            this.searchDateTime1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 510);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(341, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "Kaydı Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(341, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(341, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Kaydı Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Arama Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(8, 279);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(341, 31);
            this.searchTextBox.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(655, 531);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 617);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Koru Sigorta - Randevu Yönetim Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koru_Sigorta_Randevu_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koruSigortaRandevuDBDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Koru_Sigorta_Randevu_DBDataSet koru_Sigorta_Randevu_DBDataSet;
        private System.Windows.Forms.BindingSource koruSigortaRandevuDBDataSetBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker searchDateTime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker searchDateTime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox musteriAdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox musteriPoliceNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriTCKimlikNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriIlceTextBox;
        private System.Windows.Forms.TextBox musteriIlTextBox;
        private System.Windows.Forms.TextBox musteriTelefonNumarasiTextBox;
        private System.Windows.Forms.TextBox musteriSoyadTextBox;
        private System.Windows.Forms.DateTimePicker musteriRandevuTarihiDateTime;
        private System.Windows.Forms.CheckBox TarihCheckBox;
    }
}