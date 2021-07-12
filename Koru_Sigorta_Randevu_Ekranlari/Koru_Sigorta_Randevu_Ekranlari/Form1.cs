using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Koru_Sigorta_Randevu_Ekranlari
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3FHIL8A;Initial Catalog=Koru_Sigorta_Randevu_DB;Integrated Security=True");

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                araclar.UserAdd(connection, musteriAdTextBox.Text, musteriSoyadTextBox.Text, musteriTelefonNumarasiTextBox.Text, musteriIlTextBox.Text, musteriIlceTextBox.Text, musteriTCKimlikNumarasiTextBox.Text, musteriPoliceNumarasiTextBox.Text, musteriRandevuTarihiDateTime.Value);

                MessageBox.Show("Randevunuz oluşturuldu.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Bir hata meydana geldi. Daha sonra tekrar deneyiniz." + " " + error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            form1.Hide();
            form2.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            musteriRandevuTarihiDateTime.CustomFormat = "dd/MM/yyyy";
        }
    }
}
