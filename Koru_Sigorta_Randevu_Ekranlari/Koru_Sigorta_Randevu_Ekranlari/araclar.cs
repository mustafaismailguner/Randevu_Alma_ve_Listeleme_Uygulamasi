using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Koru_Sigorta_Randevu_Ekranlari
{
    static class araclar
    {

        public static bool TCKimlikDogrulama(string TCno)
        {
            int Algoritma_Adim_Kontrol = 0, TekBasamaklarToplami = 0, CiftBasamaklarToplami = 0;

            if (TCno.Length == 11) Algoritma_Adim_Kontrol = 1;
            foreach (char chr in TCno) { if (Char.IsNumber(chr)) Algoritma_Adim_Kontrol = 2; }
            if (TCno.Substring(0, 1) != "0") Algoritma_Adim_Kontrol = 3;

            int[] arrTC = System.Text.RegularExpressions.Regex.Replace(TCno, "[^0-9]", "").Select(x => (int)Char.GetNumericValue(x)).ToArray();

            for (int i = 0; i < TCno.Length; i++)
            {
                if (((i + 1) % 2) == 0)
                    if (i + 1 != 10) CiftBasamaklarToplami += Convert.ToInt32(arrTC[i]);
                    else
                    if (i + 1 != 11) TekBasamaklarToplami += Convert.ToInt32(arrTC[i]);
            }

            if (Convert.ToInt32(TCno.Substring(9, 1)) == (((TekBasamaklarToplami * 7) - CiftBasamaklarToplami) % 10)) Algoritma_Adim_Kontrol = 4;
            if (Convert.ToInt32(TCno.Substring(10, 1)) == ((arrTC.Sum() - Convert.ToInt32(TCno.Substring(10, 1))) % 10)) Algoritma_Adim_Kontrol = 5;

            if (Algoritma_Adim_Kontrol == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UserAdd(SqlConnection connection, string musteriad, string musterisoyad, string musteritelefonnumarasi, string musteriil, string musteriilce, string musteritckimliknumarasi, string musteripolicenumarasi, DateTime musterirandevutarihi)
        {
            if (!araclar.TCKimlikDogrulama(musteritckimliknumarasi)) throw new Exception("Girdiğiniz TC kimlik numarası geçersiz!");
            string register = "insert into Koru_Sigorta_Randevu_Bilgileri (musteri_ad, musteri_soyad, musteri_telefon_numarasi, musteri_il, musteri_ilce, musteri_tc_kimlik_numarasi, musteri_police_numarasi, musteri_randevu_tarihi)" +
                "values(@musteriad, @musterisoyad, @musteritelefonnumarasi, @musteriil, @musteriilce, @musteritckimliknumarasi, @musteripolicenumarasi, @musterirandevutarihi)";


            SqlCommand command = new SqlCommand(register, connection);
            command.Parameters.AddWithValue("@musteriad", musteriad);
            command.Parameters.AddWithValue("@musterisoyad", musterisoyad);
            command.Parameters.AddWithValue("@musteritelefonnumarasi", musteritelefonnumarasi);
            command.Parameters.AddWithValue("@musteriil", musteriil);
            command.Parameters.AddWithValue("@musteriilce", musteriilce);
            command.Parameters.AddWithValue("@musteritckimliknumarasi", musteritckimliknumarasi);
            command.Parameters.AddWithValue("@musteripolicenumarasi", musteripolicenumarasi);
            command.Parameters.AddWithValue("@musterirandevutarihi", musterirandevutarihi);

            command.ExecuteNonQuery();
        }

        public static void UserDelete(SqlConnection connection, int id)
        {
            string delete = "Delete From Koru_Sigorta_Randevu_Bilgileri Where musteri_id=@musteriid";

            SqlCommand command3 = new SqlCommand(delete, connection);

            command3.Parameters.AddWithValue("@musteriid", id);

            command3.ExecuteNonQuery();
        }

        public static void UserUpdate(SqlConnection connection, int musteriid ,string musteriad, string musterisoyad, string musteritelefonnumarasi, string musteriil, string musteriilce, string musteritckimliknumarasi, string musteripolicenumarasi, DateTime musterirandevutarihi)
        {
            if (!araclar.TCKimlikDogrulama(musteritckimliknumarasi)) throw new Exception("Girdiğiniz TC kimlik numarası geçersiz!");
            string update = "Update Koru_Sigorta_Randevu_Bilgileri Set musteri_ad=@musteriad, musteri_soyad=@musterisoyad, " +
            "musteri_telefon_numarasi=@musteritelefonnumarasi, musteri_il=@musteriil, musteri_ilce=@musteriilce, musteri_tc_kimlik_numarasi=@musteritckimliknumarasi, musteri_police_numarasi=@musteripolicenumarasi, musteri_randevu_tarihi=@musterirandevutarihi Where musteri_id=@musteriid";

            SqlCommand command4 = new SqlCommand(update, connection);

            command4.Parameters.AddWithValue("@musteriad", musteriad);
            command4.Parameters.AddWithValue("@musterisoyad", musterisoyad);
            command4.Parameters.AddWithValue("@musteritelefonnumarasi", musteritelefonnumarasi);
            command4.Parameters.AddWithValue("@musteriil", musteriil);
            command4.Parameters.AddWithValue("@musteriilce", musteriilce);
            command4.Parameters.AddWithValue("@musteritckimliknumarasi", musteritckimliknumarasi);
            command4.Parameters.AddWithValue("@musteripolicenumarasi", musteripolicenumarasi);
            command4.Parameters.AddWithValue("@musterirandevutarihi", musterirandevutarihi);
            command4.Parameters.AddWithValue("@musteriid", musteriid);

            command4.ExecuteNonQuery();
        }

    }
}
