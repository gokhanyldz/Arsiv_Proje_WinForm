namespace Arsiv_Proje
{
    partial class KayitGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitGuncelle));
            this.geri_gel = new System.Windows.Forms.Button();
            this.sql_guncelle = new System.Windows.Forms.Button();
            this.combobox_rafID = new System.Windows.Forms.ComboBox();
            this.combobox_dosyaID = new System.Windows.Forms.ComboBox();
            this.combobox_bolumID = new System.Windows.Forms.ComboBox();
            this.combobox_odaID = new System.Windows.Forms.ComboBox();
            this.combobox_klasorID = new System.Windows.Forms.ComboBox();
            this.yenievrakadi = new System.Windows.Forms.TextBox();
            this.oda_ıd = new System.Windows.Forms.Label();
            this.bolum_ıd = new System.Windows.Forms.Label();
            this.raf_ıd = new System.Windows.Forms.Label();
            this.klasor_ıd = new System.Windows.Forms.Label();
            this.dosyaıd = new System.Windows.Forms.Label();
            this.evrak_adi = new System.Windows.Forms.Label();
            this.evrak_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_evrakID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri_gel
            // 
            this.geri_gel.BackColor = System.Drawing.Color.Transparent;
            this.geri_gel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_gel.Location = new System.Drawing.Point(541, 175);
            this.geri_gel.Name = "geri_gel";
            this.geri_gel.Size = new System.Drawing.Size(158, 33);
            this.geri_gel.TabIndex = 62;
            this.geri_gel.Text = "GERİ";
            this.geri_gel.UseVisualStyleBackColor = false;
            this.geri_gel.Click += new System.EventHandler(this.geri_gel_Click);
            // 
            // sql_guncelle
            // 
            this.sql_guncelle.BackColor = System.Drawing.Color.Transparent;
            this.sql_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sql_guncelle.Location = new System.Drawing.Point(233, 175);
            this.sql_guncelle.Name = "sql_guncelle";
            this.sql_guncelle.Size = new System.Drawing.Size(158, 33);
            this.sql_guncelle.TabIndex = 61;
            this.sql_guncelle.Text = "GÜNCELLE";
            this.sql_guncelle.UseVisualStyleBackColor = false;
            this.sql_guncelle.Click += new System.EventHandler(this.sql_guncelle_Click);
            // 
            // combobox_rafID
            // 
            this.combobox_rafID.FormattingEnabled = true;
            this.combobox_rafID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.combobox_rafID.Location = new System.Drawing.Point(592, 123);
            this.combobox_rafID.Name = "combobox_rafID";
            this.combobox_rafID.Size = new System.Drawing.Size(151, 21);
            this.combobox_rafID.TabIndex = 60;
            // 
            // combobox_dosyaID
            // 
            this.combobox_dosyaID.FormattingEnabled = true;
            this.combobox_dosyaID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.combobox_dosyaID.Location = new System.Drawing.Point(402, 123);
            this.combobox_dosyaID.Name = "combobox_dosyaID";
            this.combobox_dosyaID.Size = new System.Drawing.Size(145, 21);
            this.combobox_dosyaID.TabIndex = 59;
            // 
            // combobox_bolumID
            // 
            this.combobox_bolumID.FormattingEnabled = true;
            this.combobox_bolumID.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14"});
            this.combobox_bolumID.Location = new System.Drawing.Point(204, 123);
            this.combobox_bolumID.Name = "combobox_bolumID";
            this.combobox_bolumID.Size = new System.Drawing.Size(145, 21);
            this.combobox_bolumID.TabIndex = 58;
            // 
            // combobox_odaID
            // 
            this.combobox_odaID.FormattingEnabled = true;
            this.combobox_odaID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 ",
            "6",
            "7",
            "8",
            "9",
            "10\t\t"});
            this.combobox_odaID.Location = new System.Drawing.Point(12, 123);
            this.combobox_odaID.Name = "combobox_odaID";
            this.combobox_odaID.Size = new System.Drawing.Size(145, 21);
            this.combobox_odaID.TabIndex = 57;
            // 
            // combobox_klasorID
            // 
            this.combobox_klasorID.FormattingEnabled = true;
            this.combobox_klasorID.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.combobox_klasorID.Location = new System.Drawing.Point(12, 187);
            this.combobox_klasorID.Name = "combobox_klasorID";
            this.combobox_klasorID.Size = new System.Drawing.Size(151, 21);
            this.combobox_klasorID.TabIndex = 56;
            // 
            // yenievrakadi
            // 
            this.yenievrakadi.Location = new System.Drawing.Point(261, 9);
            this.yenievrakadi.Name = "yenievrakadi";
            this.yenievrakadi.Size = new System.Drawing.Size(396, 20);
            this.yenievrakadi.TabIndex = 55;
            // 
            // oda_ıd
            // 
            this.oda_ıd.AutoSize = true;
            this.oda_ıd.BackColor = System.Drawing.Color.Transparent;
            this.oda_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oda_ıd.Location = new System.Drawing.Point(12, 82);
            this.oda_ıd.Name = "oda_ıd";
            this.oda_ıd.Size = new System.Drawing.Size(72, 23);
            this.oda_ıd.TabIndex = 54;
            this.oda_ıd.Text = "Oda ID";
            // 
            // bolum_ıd
            // 
            this.bolum_ıd.AutoSize = true;
            this.bolum_ıd.BackColor = System.Drawing.Color.Transparent;
            this.bolum_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolum_ıd.Location = new System.Drawing.Point(200, 82);
            this.bolum_ıd.Name = "bolum_ıd";
            this.bolum_ıd.Size = new System.Drawing.Size(95, 23);
            this.bolum_ıd.TabIndex = 53;
            this.bolum_ıd.Text = "Bölüm ID";
            // 
            // raf_ıd
            // 
            this.raf_ıd.AutoSize = true;
            this.raf_ıd.BackColor = System.Drawing.Color.Transparent;
            this.raf_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raf_ıd.Location = new System.Drawing.Point(606, 82);
            this.raf_ıd.Name = "raf_ıd";
            this.raf_ıd.Size = new System.Drawing.Size(67, 23);
            this.raf_ıd.TabIndex = 52;
            this.raf_ıd.Text = "Raf ID";
            // 
            // klasor_ıd
            // 
            this.klasor_ıd.AutoSize = true;
            this.klasor_ıd.BackColor = System.Drawing.Color.Transparent;
            this.klasor_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klasor_ıd.Location = new System.Drawing.Point(8, 161);
            this.klasor_ıd.Name = "klasor_ıd";
            this.klasor_ıd.Size = new System.Drawing.Size(93, 23);
            this.klasor_ıd.TabIndex = 51;
            this.klasor_ıd.Text = "Klasör ID";
            // 
            // dosyaıd
            // 
            this.dosyaıd.AutoSize = true;
            this.dosyaıd.BackColor = System.Drawing.Color.Transparent;
            this.dosyaıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaıd.Location = new System.Drawing.Point(400, 82);
            this.dosyaıd.Name = "dosyaıd";
            this.dosyaıd.Size = new System.Drawing.Size(91, 23);
            this.dosyaıd.TabIndex = 50;
            this.dosyaıd.Text = "Dosya ID";
            // 
            // evrak_adi
            // 
            this.evrak_adi.AutoSize = true;
            this.evrak_adi.BackColor = System.Drawing.Color.Transparent;
            this.evrak_adi.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evrak_adi.Location = new System.Drawing.Point(144, 9);
            this.evrak_adi.Name = "evrak_adi";
            this.evrak_adi.Size = new System.Drawing.Size(101, 23);
            this.evrak_adi.TabIndex = 49;
            this.evrak_adi.Text = "Evrak Adı:";
            // 
            // evrak_ID
            // 
            this.evrak_ID.AutoSize = true;
            this.evrak_ID.BackColor = System.Drawing.Color.Transparent;
            this.evrak_ID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evrak_ID.Location = new System.Drawing.Point(151, 44);
            this.evrak_ID.Name = "evrak_ID";
            this.evrak_ID.Size = new System.Drawing.Size(94, 23);
            this.evrak_ID.TabIndex = 63;
            this.evrak_ID.Text = "Evrak ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 220);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // text_evrakID
            // 
            this.text_evrakID.Location = new System.Drawing.Point(261, 44);
            this.text_evrakID.Name = "text_evrakID";
            this.text_evrakID.Size = new System.Drawing.Size(396, 20);
            this.text_evrakID.TabIndex = 66;
            // 
            // KayitGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_evrakID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.evrak_ID);
            this.Controls.Add(this.geri_gel);
            this.Controls.Add(this.sql_guncelle);
            this.Controls.Add(this.combobox_rafID);
            this.Controls.Add(this.combobox_dosyaID);
            this.Controls.Add(this.combobox_bolumID);
            this.Controls.Add(this.combobox_odaID);
            this.Controls.Add(this.combobox_klasorID);
            this.Controls.Add(this.yenievrakadi);
            this.Controls.Add(this.oda_ıd);
            this.Controls.Add(this.bolum_ıd);
            this.Controls.Add(this.raf_ıd);
            this.Controls.Add(this.klasor_ıd);
            this.Controls.Add(this.dosyaıd);
            this.Controls.Add(this.evrak_adi);
            this.Name = "KayitGuncelle";
            this.Text = "KayitGuncelle";
            this.Load += new System.EventHandler(this.KayitGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_gel;
        private System.Windows.Forms.Button sql_guncelle;
        private System.Windows.Forms.ComboBox combobox_rafID;
        private System.Windows.Forms.ComboBox combobox_dosyaID;
        private System.Windows.Forms.ComboBox combobox_bolumID;
        private System.Windows.Forms.ComboBox combobox_odaID;
        private System.Windows.Forms.ComboBox combobox_klasorID;
        private System.Windows.Forms.TextBox yenievrakadi;
        private System.Windows.Forms.Label oda_ıd;
        private System.Windows.Forms.Label bolum_ıd;
        private System.Windows.Forms.Label raf_ıd;
        private System.Windows.Forms.Label klasor_ıd;
        private System.Windows.Forms.Label dosyaıd;
        private System.Windows.Forms.Label evrak_adi;
        private System.Windows.Forms.Label evrak_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_evrakID;
    }
}