using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MüşteriKayıtSayfası : Form
    {
        candan_muhendıslık cnd_muh = new candan_muhendıslık();

        public MüşteriKayıtSayfası()
        {
            InitializeComponent();
        }

        private void MüşteriKayıtSayfası_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "insert into MüsteriKayıt(Adsoyad, TelefonNo, MailAdresi, Plaka, AracModel, LPGKitMarka,LPGKitModel,TankMarka,TankModel) values(@AdSoyad, @TelefonNo, @MailAdresi, @Plaka, @AracModel, @LPGKitMarka,@LPGKitModel,@TankMarka,@TankModel)";
            SqlCommand komut2 = new SqlCommand();


            komut2.Parameters.AddWithValue("@AdSoyad", textad.Text);
            komut2.Parameters.AddWithValue("@TelefonNo", texttelefon.Text);
            komut2.Parameters.AddWithValue("@MailAdresi", textmail.Text);
            komut2.Parameters.AddWithValue("@Plaka", textplaka.Text);
            komut2.Parameters.AddWithValue("@AracModel", textmodel.Text);
            komut2.Parameters.AddWithValue("@LPGKitMarka", combokitmarka.Text);
            komut2.Parameters.AddWithValue("@LPGKitModel", combokitmodel.Text);
            komut2.Parameters.AddWithValue("@TankMarka", combotmarka.Text);
            komut2.Parameters.AddWithValue("@TankModel", combotmodel.Text);
            cnd_muh.Ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            string cümle2 = "update Ürün set miktar=miktar-1 where model='" + combokitmodel.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            cnd_muh.Ekle_sil_güncelle(komut3, cümle2);
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

           string cümle3 = "update Ürün set miktar=miktar-1 where model='" + combotmodel.Text + "'";
           SqlCommand komut4 = new SqlCommand();
           cnd_muh.Ekle_sil_güncelle(komut4, cümle3);
           foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

        }

        private void combokitmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combokitmarka.Text == "Atiker")
            {
                combokitmodel.Items.Clear();
                combokitmodel.Items.Add("Atikfast");
                combokitmodel.Items.Add("Gold");
                combokitmodel.Items.Add("Grand");

            }
            else if (combokitmarka.Text == "BRC")
            {
                combokitmodel.Items.Clear();
                combokitmodel.Items.Add("Comfort");
                combokitmodel.Items.Add("Platinum");

            }
            else if (combokitmarka.Text == "Lovato")
            {
                combokitmodel.Items.Clear();
                combokitmodel.Items.Add("OBD 2");
                combokitmodel.Items.Add("Smart");

            }
            else if (combokitmarka.Text == "Prins")
            {
                combokitmodel.Items.Clear();
                combokitmodel.Items.Add("Ecomax");
                combokitmodel.Items.Add("Silverline");
                combokitmodel.Items.Add("tecnomax");
                combokitmodel.Items.Add("VSI 2");

            }
        }

        private void combotmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combotmarka.Text == "Atiker Tank")
            {
                combotmodel.Items.Clear();
                combotmodel.Items.Add("32 LT");
                combotmodel.Items.Add("42 LT");
                combotmodel.Items.Add("48 LT");
                combotmodel.Items.Add("55 LT");

            }
            else if (combotmodel.Text == "Step Tank")
            {
                combotmodel.Items.Clear();
                combotmodel.Items.Add("32 LT");
                combotmodel.Items.Add("42 LT");
                combotmodel.Items.Add("48 LT");
                combotmodel.Items.Add("55 LT");
            }
        }
    }
}
