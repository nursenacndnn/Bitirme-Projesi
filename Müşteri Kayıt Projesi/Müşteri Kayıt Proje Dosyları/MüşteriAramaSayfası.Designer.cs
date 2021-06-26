namespace WindowsFormsApp1
{
    partial class MüşteriAramaSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriAramaSayfası));
            this.textmail = new System.Windows.Forms.TextBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.textplaka = new System.Windows.Forms.TextBox();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cANDAN_MUHENDISLIKDataSet = new WindowsFormsApp1.CANDAN_MUHENDISLIKDataSet();
            this.müsteriKayıtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.müsteriKayıtTableAdapter = new WindowsFormsApp1.CANDAN_MUHENDISLIKDataSetTableAdapters.MüsteriKayıtTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.combotmodel = new System.Windows.Forms.ComboBox();
            this.T = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textkitmodel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combotmarka = new System.Windows.Forms.ComboBox();
            this.combokitmodel = new System.Windows.Forms.ComboBox();
            this.combokitmarka = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cANDAN_MUHENDISLIKDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriKayıtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textmail
            // 
            this.textmail.Location = new System.Drawing.Point(136, 204);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(141, 20);
            this.textmail.TabIndex = 0;
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(136, 310);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(141, 20);
            this.textmodel.TabIndex = 1;
            // 
            // textplaka
            // 
            this.textplaka.Location = new System.Drawing.Point(136, 257);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(141, 20);
            this.textplaka.TabIndex = 3;
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(136, 151);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(141, 20);
            this.texttelefon.TabIndex = 6;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(136, 98);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(141, 20);
            this.textad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Telefon No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mail Adresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plaka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Araç Model";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cANDAN_MUHENDISLIKDataSet
            // 
            this.cANDAN_MUHENDISLIKDataSet.DataSetName = "CANDAN_MUHENDISLIKDataSet";
            this.cANDAN_MUHENDISLIKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // müsteriKayıtBindingSource
            // 
            this.müsteriKayıtBindingSource.DataMember = "MüsteriKayıt";
            this.müsteriKayıtBindingSource.DataSource = this.cANDAN_MUHENDISLIKDataSet;
            // 
            // müsteriKayıtTableAdapter
            // 
            this.müsteriKayıtTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 423);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(254, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Güncelle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "9CA52DE9-3C21-4DB9-BA4B-A7EAFAC555D3.png");
            this.ımageList1.Images.SetKeyName(1, "75f3384bb457a8d02ae605211103371e.png");
            this.ımageList1.Images.SetKeyName(2, "186-1867613_trash-dustbin-delete-recycle-bin-icon-technology.png");
            this.ımageList1.Images.SetKeyName(3, "arama-butonu-png-3.png");
            this.ımageList1.Images.SetKeyName(4, "wrong-295503_960_720.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(101, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "İptal";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(865, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 54);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sil";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // combotmodel
            // 
            this.combotmodel.FormattingEnabled = true;
            this.combotmodel.Location = new System.Drawing.Point(136, 525);
            this.combotmodel.Name = "combotmodel";
            this.combotmodel.Size = new System.Drawing.Size(141, 21);
            this.combotmodel.TabIndex = 34;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.T.Location = new System.Drawing.Point(42, 475);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(72, 15);
            this.T.TabIndex = 33;
            this.T.Text = "Tank Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(42, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tank Model";
            // 
            // textkitmodel
            // 
            this.textkitmodel.AutoSize = true;
            this.textkitmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textkitmodel.Location = new System.Drawing.Point(28, 421);
            this.textkitmodel.Name = "textkitmodel";
            this.textkitmodel.Size = new System.Drawing.Size(86, 15);
            this.textkitmodel.TabIndex = 31;
            this.textkitmodel.Text = "LPG Kit Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "LPG Kit Marka";
            // 
            // combotmarka
            // 
            this.combotmarka.FormattingEnabled = true;
            this.combotmarka.Items.AddRange(new object[] {
            "Atiker Tank",
            "Step Tank"});
            this.combotmarka.Location = new System.Drawing.Point(136, 471);
            this.combotmarka.Name = "combotmarka";
            this.combotmarka.Size = new System.Drawing.Size(141, 21);
            this.combotmarka.TabIndex = 29;
            this.combotmarka.SelectedIndexChanged += new System.EventHandler(this.combotmarka_SelectedIndexChanged);
            // 
            // combokitmodel
            // 
            this.combokitmodel.FormattingEnabled = true;
            this.combokitmodel.Location = new System.Drawing.Point(136, 417);
            this.combokitmodel.Name = "combokitmodel";
            this.combokitmodel.Size = new System.Drawing.Size(141, 21);
            this.combokitmodel.TabIndex = 28;
            this.combokitmodel.SelectedIndexChanged += new System.EventHandler(this.combokitmodel_SelectedIndexChanged);
            // 
            // combokitmarka
            // 
            this.combokitmarka.FormattingEnabled = true;
            this.combokitmarka.Items.AddRange(new object[] {
            "Atiker",
            "BRC",
            "Lovato",
            "Prins"});
            this.combokitmarka.Location = new System.Drawing.Point(136, 363);
            this.combokitmarka.Name = "combokitmarka";
            this.combokitmarka.Size = new System.Drawing.Size(141, 21);
            this.combokitmarka.TabIndex = 27;
            this.combokitmarka.SelectedIndexChanged += new System.EventHandler(this.combokitmarka_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(550, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "MÜŞTERİ (AD SOYAD) ARA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MüşteriAramaSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 721);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combotmodel);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textkitmodel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combotmarka);
            this.Controls.Add(this.combokitmodel);
            this.Controls.Add(this.combokitmarka);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.texttelefon);
            this.Controls.Add(this.textplaka);
            this.Controls.Add(this.textmodel);
            this.Controls.Add(this.textmail);
            this.Name = "MüşteriAramaSayfası";
            this.Text = "MüşteriAramaSayfası";
            this.Load += new System.EventHandler(this.MüşteriAramaSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cANDAN_MUHENDISLIKDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.müsteriKayıtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CANDAN_MUHENDISLIKDataSet cANDAN_MUHENDISLIKDataSet;
        private System.Windows.Forms.BindingSource müsteriKayıtBindingSource;
        private CANDAN_MUHENDISLIKDataSetTableAdapters.MüsteriKayıtTableAdapter müsteriKayıtTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox combotmodel;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textkitmodel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combotmarka;
        private System.Windows.Forms.ComboBox combokitmodel;
        private System.Windows.Forms.ComboBox combokitmarka;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}