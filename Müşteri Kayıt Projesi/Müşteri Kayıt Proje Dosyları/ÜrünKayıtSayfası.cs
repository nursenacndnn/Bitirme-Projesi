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
    public partial class ÜrünKayıtSayfası : Form
    {
        candan_muhendıslık candanmuh = new candan_muhendıslık();
        public ÜrünKayıtSayfası()
        {
            InitializeComponent();
        }

        private void comboürün_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comboürün.Text == "LPG KİT")
            {
                combomarka.Items.Clear();
                combomarka.Items.Add("Atiker");
                combomarka.Items.Add("BRC");
                combomarka.Items.Add("Lovato");
                combomarka.Items.Add("Prins");
            }
             else if (comboürün.Text == "TANK")
            {
                combomarka.Items.Clear();
                combomarka.Items.Add("Atiker Tank");
                combomarka.Items.Add("Step Tank");
                
            }

         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combomarka.Text == "Atiker")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("Atikfast");
                combomodel.Items.Add("Gold");
                combomodel.Items.Add("Grand");

            }
            else if (combomarka.Text == "BRC")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("Comfort");
                combomodel.Items.Add("Platinum");

            }
            else if (combomarka.Text == "Lovato")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("OBD 2");
                combomodel.Items.Add("Smart");

            }
            else if (combomarka.Text == "Prins")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("Ecomax");
                combomodel.Items.Add("Silverline");
                combomodel.Items.Add("tecnomax");
                combomodel.Items.Add("VSI 2");

            }
            if (combomarka.Text == "Atiker Tank")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("32 LT");
                combomodel.Items.Add("42 LT");
                combomodel.Items.Add("48 LT");
                combomodel.Items.Add("55 LT");

            }
            else if (combomarka.Text == "Step Tank")
            {
                combomodel.Items.Clear();
                combomodel.Items.Add("32 LT");
                combomodel.Items.Add("42 LT");
                combomodel.Items.Add("48 LT");
                combomodel.Items.Add("55 LT");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Ürün(ürünadı,marka,model,miktar,tarih) values(@ürünadı,@marka,@model,@miktar,@tarih)";

            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ürünadı", comboürün.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@model", combomodel.Text);
            komut2.Parameters.AddWithValue("@miktar",int.Parse(textmiktar.Text));
            komut2.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
            candanmuh.Ekle_sil_güncelle(komut2, cümle);
            comboürün.Items.Clear();
            combomodel.Items.Clear();
            combomarka.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            
        }

        private void ÜrünKayıtSayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
