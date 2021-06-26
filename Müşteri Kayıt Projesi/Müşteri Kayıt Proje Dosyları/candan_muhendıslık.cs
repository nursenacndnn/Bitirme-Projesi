using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class candan_muhendıslık

    {


        SqlConnection baglantı = new SqlConnection("Data Source=CANDAN\\SQLEXPRESS;Initial Catalog=CANDAN_MUHENDISLIK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        DataTable tablo;
        
        public void Ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglantı.Close();

        }
        public DataTable Listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,baglantı);
            adtr.Fill(tablo);
            baglantı.Close();
            return tablo;
        }

    }
}
