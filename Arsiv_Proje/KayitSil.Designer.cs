namespace Arsiv_Proje
{
    partial class KayitSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitSil));
            this.geri_gel = new System.Windows.Forms.Button();
            this.sql_kaydet = new System.Windows.Forms.Button();
            this.comboBox_rafID = new System.Windows.Forms.ComboBox();
            this.comboBox_dosyaID = new System.Windows.Forms.ComboBox();
            this.comboBox_bolumID = new System.Windows.Forms.ComboBox();
            this.comboBox_odaID = new System.Windows.Forms.ComboBox();
            this.comboBox_klasorID = new System.Windows.Forms.ComboBox();
            this.oda_ıd = new System.Windows.Forms.Label();
            this.bolum_ıd = new System.Windows.Forms.Label();
            this.raf_ıd = new System.Windows.Forms.Label();
            this.klasor_ıd = new System.Windows.Forms.Label();
            this.dosyaıd = new System.Windows.Forms.Label();
            this.evrak_adi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.evrak_ID = new System.Windows.Forms.Label();
            this.comboBox_evrakAd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri_gel
            // 
            this.geri_gel.BackColor = System.Drawing.Color.Transparent;
            this.geri_gel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_gel.Location = new System.Drawing.Point(586, 183);
            this.geri_gel.Name = "geri_gel";
            this.geri_gel.Size = new System.Drawing.Size(158, 33);
            this.geri_gel.TabIndex = 76;
            this.geri_gel.Text = "GERİ";
            this.geri_gel.UseVisualStyleBackColor = false;
            this.geri_gel.Click += new System.EventHandler(this.geri_gel_Click);
            // 
            // sql_kaydet
            // 
            this.sql_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.sql_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sql_kaydet.Location = new System.Drawing.Point(586, 135);
            this.sql_kaydet.Name = "sql_kaydet";
            this.sql_kaydet.Size = new System.Drawing.Size(158, 33);
            this.sql_kaydet.TabIndex = 75;
            this.sql_kaydet.Text = "KAYIT SİL";
            this.sql_kaydet.UseVisualStyleBackColor = false;
            this.sql_kaydet.Click += new System.EventHandler(this.sql_kaydet_Click);
            // 
            // comboBox_rafID
            // 
            this.comboBox_rafID.FormattingEnabled = true;
            this.comboBox_rafID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_rafID.Location = new System.Drawing.Point(94, 161);
            this.comboBox_rafID.Name = "comboBox_rafID";
            this.comboBox_rafID.Size = new System.Drawing.Size(151, 21);
            this.comboBox_rafID.TabIndex = 74;
            // 
            // comboBox_dosyaID
            // 
            this.comboBox_dosyaID.FormattingEnabled = true;
            this.comboBox_dosyaID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_dosyaID.Location = new System.Drawing.Point(542, 101);
            this.comboBox_dosyaID.Name = "comboBox_dosyaID";
            this.comboBox_dosyaID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_dosyaID.TabIndex = 73;
            // 
            // comboBox_bolumID
            // 
            this.comboBox_bolumID.FormattingEnabled = true;
            this.comboBox_bolumID.Items.AddRange(new object[] {
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
            this.comboBox_bolumID.Location = new System.Drawing.Point(332, 101);
            this.comboBox_bolumID.Name = "comboBox_bolumID";
            this.comboBox_bolumID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_bolumID.TabIndex = 72;
            // 
            // comboBox_odaID
            // 
            this.comboBox_odaID.FormattingEnabled = true;
            this.comboBox_odaID.Items.AddRange(new object[] {
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
            this.comboBox_odaID.Location = new System.Drawing.Point(100, 101);
            this.comboBox_odaID.Name = "comboBox_odaID";
            this.comboBox_odaID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_odaID.TabIndex = 71;
            // 
            // comboBox_klasorID
            // 
            this.comboBox_klasorID.FormattingEnabled = true;
            this.comboBox_klasorID.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.comboBox_klasorID.Location = new System.Drawing.Point(339, 161);
            this.comboBox_klasorID.Name = "comboBox_klasorID";
            this.comboBox_klasorID.Size = new System.Drawing.Size(151, 21);
            this.comboBox_klasorID.TabIndex = 70;
            // 
            // oda_ıd
            // 
            this.oda_ıd.AutoSize = true;
            this.oda_ıd.BackColor = System.Drawing.Color.Transparent;
            this.oda_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oda_ıd.Location = new System.Drawing.Point(137, 75);
            this.oda_ıd.Name = "oda_ıd";
            this.oda_ıd.Size = new System.Drawing.Size(72, 23);
            this.oda_ıd.TabIndex = 68;
            this.oda_ıd.Text = "Oda ID";
            // 
            // bolum_ıd
            // 
            this.bolum_ıd.AutoSize = true;
            this.bolum_ıd.BackColor = System.Drawing.Color.Transparent;
            this.bolum_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolum_ıd.Location = new System.Drawing.Point(339, 75);
            this.bolum_ıd.Name = "bolum_ıd";
            this.bolum_ıd.Size = new System.Drawing.Size(95, 23);
            this.bolum_ıd.TabIndex = 67;
            this.bolum_ıd.Text = "Bölüm ID";
            // 
            // raf_ıd
            // 
            this.raf_ıd.AutoSize = true;
            this.raf_ıd.BackColor = System.Drawing.Color.Transparent;
            this.raf_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raf_ıd.Location = new System.Drawing.Point(108, 135);
            this.raf_ıd.Name = "raf_ıd";
            this.raf_ıd.Size = new System.Drawing.Size(67, 23);
            this.raf_ıd.TabIndex = 66;
            this.raf_ıd.Text = "Raf ID";
            // 
            // klasor_ıd
            // 
            this.klasor_ıd.AutoSize = true;
            this.klasor_ıd.BackColor = System.Drawing.Color.Transparent;
            this.klasor_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klasor_ıd.Location = new System.Drawing.Point(339, 135);
            this.klasor_ıd.Name = "klasor_ıd";
            this.klasor_ıd.Size = new System.Drawing.Size(93, 23);
            this.klasor_ıd.TabIndex = 65;
            this.klasor_ıd.Text = "Klasör ID";
            // 
            // dosyaıd
            // 
            this.dosyaıd.AutoSize = true;
            this.dosyaıd.BackColor = System.Drawing.Color.Transparent;
            this.dosyaıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaıd.Location = new System.Drawing.Point(540, 75);
            this.dosyaıd.Name = "dosyaıd";
            this.dosyaıd.Size = new System.Drawing.Size(91, 23);
            this.dosyaıd.TabIndex = 64;
            this.dosyaıd.Text = "Dosya ID";
            // 
            // evrak_adi
            // 
            this.evrak_adi.AutoSize = true;
            this.evrak_adi.BackColor = System.Drawing.Color.Transparent;
            this.evrak_adi.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evrak_adi.Location = new System.Drawing.Point(12, 9);
            this.evrak_adi.Name = "evrak_adi";
            this.evrak_adi.Size = new System.Drawing.Size(101, 23);
            this.evrak_adi.TabIndex = 63;
            this.evrak_adi.Text = "Evrak Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 205);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(165, 51);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(396, 20);
            this.text_ID.TabIndex = 79;
            // 
            // evrak_ID
            // 
            this.evrak_ID.AutoSize = true;
            this.evrak_ID.BackColor = System.Drawing.Color.Transparent;
            this.evrak_ID.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evrak_ID.Location = new System.Drawing.Point(12, 48);
            this.evrak_ID.Name = "evrak_ID";
            this.evrak_ID.Size = new System.Drawing.Size(94, 23);
            this.evrak_ID.TabIndex = 78;
            this.evrak_ID.Text = "Evrak ID:";
            // 
            // comboBox_evrakAd
            // 
            this.comboBox_evrakAd.FormattingEnabled = true;
            this.comboBox_evrakAd.Location = new System.Drawing.Point(165, 9);
            this.comboBox_evrakAd.Name = "comboBox_evrakAd";
            this.comboBox_evrakAd.Size = new System.Drawing.Size(396, 21);
            this.comboBox_evrakAd.TabIndex = 80;
            // 
            // KayitSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_evrakAd);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.evrak_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geri_gel);
            this.Controls.Add(this.sql_kaydet);
            this.Controls.Add(this.comboBox_rafID);
            this.Controls.Add(this.comboBox_dosyaID);
            this.Controls.Add(this.comboBox_bolumID);
            this.Controls.Add(this.comboBox_odaID);
            this.Controls.Add(this.comboBox_klasorID);
            this.Controls.Add(this.oda_ıd);
            this.Controls.Add(this.bolum_ıd);
            this.Controls.Add(this.raf_ıd);
            this.Controls.Add(this.klasor_ıd);
            this.Controls.Add(this.dosyaıd);
            this.Controls.Add(this.evrak_adi);
            this.Name = "KayitSil";
            this.Text = "KayitSil";
            this.Load += new System.EventHandler(this.KayitSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_gel;
        private System.Windows.Forms.Button sql_kaydet;
        private System.Windows.Forms.ComboBox comboBox_rafID;
        private System.Windows.Forms.ComboBox comboBox_dosyaID;
        private System.Windows.Forms.ComboBox comboBox_bolumID;
        private System.Windows.Forms.ComboBox comboBox_odaID;
        private System.Windows.Forms.ComboBox comboBox_klasorID;
        private System.Windows.Forms.Label oda_ıd;
        private System.Windows.Forms.Label bolum_ıd;
        private System.Windows.Forms.Label raf_ıd;
        private System.Windows.Forms.Label klasor_ıd;
        private System.Windows.Forms.Label dosyaıd;
        private System.Windows.Forms.Label evrak_adi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label evrak_ID;
        private System.Windows.Forms.ComboBox comboBox_evrakAd;
    }
}