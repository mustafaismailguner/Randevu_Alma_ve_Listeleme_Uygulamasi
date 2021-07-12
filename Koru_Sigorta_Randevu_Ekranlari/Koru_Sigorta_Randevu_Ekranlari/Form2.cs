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

namespace Koru_Sigorta_Randevu_Ekranlari
{
    public partial class Form2 : Form
    {

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3FHIL8A;Initial Catalog=Koru_Sigorta_Randevu_DB;Integrated Security=True");


        public void list_records()
        {
            string list = "Select * From Koru_Sigorta_Randevu_Bilgileri";

            SqlCommand command = new SqlCommand(list, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void list_records2()
        {
            string list = "Select * From Koru_Sigorta_Randevu_Bilgileri";

            SqlCommand command = new SqlCommand(list, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_records();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool tcNoSearch = long.TryParse(searchTextBox.Text, out long tckimlik);
            string search = "Select * From Koru_Sigorta_Randevu_Bilgileri Where musteri_ad=@musteriad " +
                            "OR musteri_soyad=@musterisoyad " +
                            "OR musteri_il=@musteriil " +
                            "OR musteri_ilce=@musteriilce " +
                            (tcNoSearch ? "OR musteri_tc_kimlik_numarasi=@musteritckimliknumarasi " : "") +
                            (TarihCheckBox.Checked ? "OR musteri_randevu_tarihi between @musterirandevutarihi and @musterirandevutarihi2" : "");

            SqlCommand command2 = new SqlCommand(search, connection);

            command2.Parameters.AddWithValue("@musteriad", searchTextBox.Text);
            command2.Parameters.AddWithValue("@musterisoyad", searchTextBox.Text);
            command2.Parameters.AddWithValue("@musteriil", searchTextBox.Text);

            command2.Parameters.AddWithValue("@musteriilce", searchTextBox.Text); command2.Parameters.AddWithValue("@musteritckimliknumarasi", tckimlik);
            command2.Parameters.AddWithValue("@musterirandevutarihi", searchDateTime1.Value);
            command2.Parameters.AddWithValue("@musterirandevutarihi2", searchDateTime2.Value);

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(command2);

            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        int i = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                araclar.UserUpdate(connection, (int)dataGridView1.Rows[i].Cells["musteri_id"].Value
                , musteriAdTextBox.Text, musteriSoyadTextBox.Text, musteriTelefonNumarasiTextBox.Text, musteriIlTextBox.Text, musteriIlceTextBox.Text, musteriTCKimlikNumarasiTextBox.Text, musteriPoliceNumarasiTextBox.Text, musteriRandevuTarihiDateTime.Value);
                list_records2();

                MessageBox.Show("Kayıt güncellendi.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Kayıt güncellenirken bir hata meydana geldi." + error.Message);
            }

        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            musteriAdTextBox.Text = dataGridView2.Rows[i].Cells["musteri_ad"].Value.ToString();
            musteriSoyadTextBox.Text = dataGridView2.Rows[i].Cells["musteri_soyad"].Value.ToString();
            musteriTelefonNumarasiTextBox.Text = dataGridView2.Rows[i].Cells["musteri_telefon_numarasi"].Value.ToString();
            musteriIlTextBox.Text = dataGridView2.Rows[i].Cells["musteri_il"].Value.ToString();
            musteriIlceTextBox.Text = dataGridView2.Rows[i].Cells["musteri_ilce"].Value.ToString();
            musteriTCKimlikNumarasiTextBox.Text = dataGridView2.Rows[i].Cells["musteri_tc_kimlik_numarasi"].Value.ToString();
            musteriPoliceNumarasiTextBox.Text = dataGridView2.Rows[i].Cells["musteri_police_numarasi"].Value.ToString();
            musteriRandevuTarihiDateTime.Value = (DateTime)dataGridView2.Rows[i].Cells["musteri_randevu_tarihi"].Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list_records2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                araclar.UserDelete(connection, id);
                list_records2();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchDateTime1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchDateTime2.CustomFormat = "dd/MM/yyyy";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            searchDateTime1.Enabled = TarihCheckBox.Checked;
            searchDateTime2.Enabled = TarihCheckBox.Checked;
        }
    }
}
