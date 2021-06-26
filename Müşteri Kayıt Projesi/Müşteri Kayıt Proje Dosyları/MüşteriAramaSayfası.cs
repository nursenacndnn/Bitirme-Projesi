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
    public partial class MüşteriAramaSayfası : Form
    {
        candan_muhendıslık candanmuh = new candan_muhendıslık();
        public MüşteriAramaSayfası()
        {
            InitializeComponent();
        }

       
        private void MüşteriAramaSayfası_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cümle = "select *from MüsteriKayıt";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = candanmuh.Listele(adtr2,cümle);
            dataGridView1.Columns[0].HeaderText = "AD SOYAD";
            dataGridView1.Columns[1].HeaderText = "TELEFON NO";
            dataGridView1.Columns[2].HeaderText = "MAİL ADRESİ";
            dataGridView1.Columns[3].HeaderText = "PLAKA";
            dataGridView1.Columns[4].HeaderText = "ARAÇ MODEL";
            dataGridView1.Columns[5].HeaderText = "LPG KİT MARKA";
            dataGridView1.Columns[6].HeaderText = "LPG KİT MODEL";
            dataGridView1.Columns[7].HeaderText = "TANK MARKA";
            dataGridView1.Columns[8].HeaderText = "TANK MODEL";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "update  MüsteriKayıt set Adsoyad=@AdSoyad, TelefonNo=@TelefonNo, MailAdresi=@MailAdresi, Plaka=@Plaka, AracModel=@AracModel, LPGKitMarka=@LPGKitMarka, LPGKitModel=@LPGKitModel, TankMarka=@TankMarka, TankModel=@TankModel";
            
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
            candanmuh.Ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            

            

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from MüsteriKayıt where AdSoyad like '%" + textad.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();            
            dataGridView1.DataSource = candanmuh.Listele(adtr2, cümle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textad.Text = satır.Cells[0].Value.ToString();
            texttelefon.Text = satır.Cells[1].Value.ToString();
            textmail.Text = satır.Cells[2].Value.ToString();
            textplaka.Text = satır.Cells[3].Value.ToString();
            textmodel.Text = satır.Cells[4].Value.ToString();
            combokitmarka.Text = satır.Cells[5].Value.ToString();
            combokitmodel.Text = satır.Cells[6].Value.ToString();
            combotmarka.Text = satır.Cells[7].Value.ToString();
            combotmodel.Text = satır.Cells[8].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from MüsteriKayıt where Plaka='" + satır.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            candanmuh.Ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            YenileListele();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void combokitmodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combokitmarka_SelectedIndexChanged(object sender, EventArgs e)
        { try
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
            catch
            {
                ;
            }
        }

        private void combotmarka_SelectedIndexChanged(object sender, EventArgs e)
        { try {
                if (combotmarka.Text == "Atiker Tank")
                {
                    combotmodel.Items.Clear();
                    combotmodel.Items.Add("32 LT");
                    combotmodel.Items.Add("42 LT");
                    combotmodel.Items.Add("48 LT");
                    combotmodel.Items.Add("55 LT");

                }
                else if (combotmarka.Text == "Step Tank")
                {
                    combotmodel.Items.Clear();
                    combotmodel.Items.Add("32 LT");
                    combotmodel.Items.Add("42 LT");
                    combotmodel.Items.Add("48 LT");
                    combotmodel.Items.Add("55 LT");
                }
                
            }
            catch
            {
                ;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from MüsteriKayıt where AdSoyad like '%" + textad.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = candanmuh.Listele(adtr2, cümle);
        }
    }
}
