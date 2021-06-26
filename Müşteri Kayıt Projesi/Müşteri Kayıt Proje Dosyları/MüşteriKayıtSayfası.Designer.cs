namespace WindowsFormsApp1
{
    partial class MüşteriKayıtSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriKayıtSayfası));
            this.textad = new System.Windows.Forms.TextBox();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.textmail = new System.Windows.Forms.TextBox();
            this.textplaka = new System.Windows.Forms.TextBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.combokitmarka = new System.Windows.Forms.ComboBox();
            this.combokitmodel = new System.Windows.Forms.ComboBox();
            this.combotmarka = new System.Windows.Forms.ComboBox();
            this.combotmodel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(193, 72);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(171, 20);
            this.textad.TabIndex = 0;
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(193, 149);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(171, 20);
            this.texttelefon.TabIndex = 1;
            // 
            // textmail
            // 
            this.textmail.Location = new System.Drawing.Point(193, 226);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(171, 20);
            this.textmail.TabIndex = 2;
            // 
            // textplaka
            // 
            this.textplaka.Location = new System.Drawing.Point(193, 303);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(171, 20);
            this.textplaka.TabIndex = 3;
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(193, 380);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(171, 20);
            this.textmodel.TabIndex = 4;
            // 
            // combokitmarka
            // 
            this.combokitmarka.FormattingEnabled = true;
            this.combokitmarka.Items.AddRange(new object[] {
            "Atiker",
            "BRC",
            "Lovato",
            "Prins"});
            this.combokitmarka.Location = new System.Drawing.Point(569, 72);
            this.combokitmarka.Name = "combokitmarka";
            this.combokitmarka.Size = new System.Drawing.Size(175, 21);
            this.combokitmarka.TabIndex = 5;
            this.combokitmarka.SelectedIndexChanged += new System.EventHandler(this.combokitmarka_SelectedIndexChanged);
            // 
            // combokitmodel
            // 
            this.combokitmodel.FormattingEnabled = true;
            this.combokitmodel.Location = new System.Drawing.Point(569, 148);
            this.combokitmodel.Name = "combokitmodel";
            this.combokitmodel.Size = new System.Drawing.Size(175, 21);
            this.combokitmodel.TabIndex = 6;
            // 
            // combotmarka
            // 
            this.combotmarka.FormattingEnabled = true;
            this.combotmarka.Items.AddRange(new object[] {
            "Atiker Tank",
            "Step Tank"});
            this.combotmarka.Location = new System.Drawing.Point(569, 226);
            this.combotmarka.Name = "combotmarka";
            this.combotmarka.Size = new System.Drawing.Size(175, 21);
            this.combotmarka.TabIndex = 7;
            this.combotmarka.SelectedIndexChanged += new System.EventHandler(this.combotmarka_SelectedIndexChanged);
            // 
            // combotmodel
            // 
            this.combotmodel.FormattingEnabled = true;
            this.combotmodel.Location = new System.Drawing.Point(569, 302);
            this.combotmodel.Name = "combotmodel";
            this.combotmodel.Size = new System.Drawing.Size(175, 21);
            this.combotmodel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefon No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Araç Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(450, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "LPG Kit Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(451, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "LPG Kit Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(461, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tank Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(462, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tank Model";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(494, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "İptal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(639, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 19;
            this.button2.Text = "Kaydet";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kişi.png");
            this.ımageList1.Images.SetKeyName(1, "wrong-295503_960_720.png");
            // 
            // MüşteriKayıtSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combotmodel);
            this.Controls.Add(this.combotmarka);
            this.Controls.Add(this.combokitmodel);
            this.Controls.Add(this.combokitmarka);
            this.Controls.Add(this.textmodel);
            this.Controls.Add(this.textplaka);
            this.Controls.Add(this.textmail);
            this.Controls.Add(this.texttelefon);
            this.Controls.Add(this.textad);
            this.Name = "MüşteriKayıtSayfası";
            this.Text = "MüşteriKayıtSayfası";
            this.Load += new System.EventHandler(this.MüşteriKayıtSayfası_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.ComboBox combokitmarka;
        private System.Windows.Forms.ComboBox combokitmodel;
        private System.Windows.Forms.ComboBox combotmarka;
        private System.Windows.Forms.ComboBox combotmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
    }
}