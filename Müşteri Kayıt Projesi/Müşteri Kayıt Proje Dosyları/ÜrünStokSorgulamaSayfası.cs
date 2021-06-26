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
    public partial class ÜrünStokSorgulamaSayfası : Form
    {
        candan_muhendıslık candanmuh = new candan_muhendıslık();
        public ÜrünStokSorgulamaSayfası()
        {
            InitializeComponent();
        }

        private void ÜrünStokSorgulamaSayfası_Load(object sender, EventArgs e)
        {
            YenileÜrün();
        }

        private void YenileÜrün()
        {
            String cümle = "select *from Ürün";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=candanmuh.Listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ÜRÜN ADI";
            dataGridView1.Columns[1].HeaderText = "MARKA";
            dataGridView1.Columns[2].HeaderText = "MODEL";
            dataGridView1.Columns[3].HeaderText = "MİKTAR";
            dataGridView1.Columns[4].HeaderText = "TARİH";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            comboürün.Text = satır.Cells["ürünadı"].Value.ToString();
            combomarka.Text = satır.Cells["marka"].Value.ToString();
            combomodel.Text = satır.Cells["model"].Value.ToString();
            textmiktar.Text = satır.Cells["miktar"].Value.ToString();
            
        }

        private void comboürün_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboürün.Text == "LPG KİT")
            {
                combomarka.Items.Clear();
                combomarka.Items.Add("Atiker");
                combomarka.Items.Add("BRC");
                combomarka.Items.Add("Lovato");
                combomarka.Items.Add("Lovato");

            }
            else if (comboürün.Text == "TANK")
            {
                combomarka.Items.Clear();
                combomarka.Items.Add("Atiker Tank");
                combomarka.Items.Add("Step Tank");


            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "update Ürün set ürünadı=@ürünadı,marka=@marka,model=@model,miktar=@miktar";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@ürünadı", comboürün.Text);
            komut2.Parameters.AddWithValue("@marka", combomarka.Text);
            komut2.Parameters.AddWithValue("@model", combomodel.Text);
            komut2.Parameters.AddWithValue("@miktar", textmiktar.Text);                     
            candanmuh.Ekle_sil_güncelle(komut2, cümle);          
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileÜrün();



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

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from Ürün where model='" + satır.Cells["model"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            candanmuh.Ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

            YenileÜrün();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from Ürün where model like '%" + combomodel.Text + "%'";
            SqlDataAdapter adtr3 = new SqlDataAdapter();
            dataGridView1.DataSource = candanmuh.Listele(adtr3, cümle);
        }
    }
    }



//string cümle = "select *from MüsteriKayıt where AdSoyad like '%" + textad.Text + "%'";
//SqlDataAdapter adtr2 = new SqlDataAdapter();
//dataGridView1.DataSource = candanmuh.Listele(adtr2, cümle)