namespace Arsiv_Proje
{
    partial class Kayıtara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıtara));
            this.geri_gel = new System.Windows.Forms.Button();
            this.sql_ara = new System.Windows.Forms.Button();
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
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_evrakAd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geri_gel
            // 
            this.geri_gel.BackColor = System.Drawing.Color.Transparent;
            this.geri_gel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_gel.Location = new System.Drawing.Point(527, 163);
            this.geri_gel.Name = "geri_gel";
            this.geri_gel.Size = new System.Drawing.Size(158, 33);
            this.geri_gel.TabIndex = 62;
            this.geri_gel.Text = "GERİ";
            this.geri_gel.UseVisualStyleBackColor = false;
            this.geri_gel.Click += new System.EventHandler(this.geri_gel_Click);
            // 
            // sql_ara
            // 
            this.sql_ara.BackColor = System.Drawing.Color.Transparent;
            this.sql_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sql_ara.Location = new System.Drawing.Point(261, 163);
            this.sql_ara.Name = "sql_ara";
            this.sql_ara.Size = new System.Drawing.Size(158, 33);
            this.sql_ara.TabIndex = 61;
            this.sql_ara.Text = "ARA";
            this.sql_ara.UseVisualStyleBackColor = false;
            this.sql_ara.Click += new System.EventHandler(this.sql_ara_Click);
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
            this.comboBox_rafID.Location = new System.Drawing.Point(614, 107);
            this.comboBox_rafID.Name = "comboBox_rafID";
            this.comboBox_rafID.Size = new System.Drawing.Size(151, 21);
            this.comboBox_rafID.TabIndex = 60;
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
            this.comboBox_dosyaID.Location = new System.Drawing.Point(413, 107);
            this.comboBox_dosyaID.Name = "comboBox_dosyaID";
            this.comboBox_dosyaID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_dosyaID.TabIndex = 59;
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
            this.comboBox_bolumID.Location = new System.Drawing.Point(230, 107);
            this.comboBox_bolumID.Name = "comboBox_bolumID";
            this.comboBox_bolumID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_bolumID.TabIndex = 58;
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
            this.comboBox_odaID.Location = new System.Drawing.Point(16, 107);
            this.comboBox_odaID.Name = "comboBox_odaID";
            this.comboBox_odaID.Size = new System.Drawing.Size(145, 21);
            this.comboBox_odaID.TabIndex = 57;
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
            this.comboBox_klasorID.Location = new System.Drawing.Point(10, 175);
            this.comboBox_klasorID.Name = "comboBox_klasorID";
            this.comboBox_klasorID.Size = new System.Drawing.Size(151, 21);
            this.comboBox_klasorID.TabIndex = 56;
            // 
            // oda_ıd
            // 
            this.oda_ıd.AutoSize = true;
            this.oda_ıd.BackColor = System.Drawing.Color.Transparent;
            this.oda_ıd.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oda_ıd.Location = new System.Drawing.Point(12, 81);
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
            this.bolum_ıd.Location = new System.Drawing.Point(226, 81);
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
            this.raf_ıd.Location = new System.Drawing.Point(610, 81);
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
            this.klasor_ıd.Location = new System.Drawing.Point(6, 140);
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
            this.dosyaıd.Location = new System.Drawing.Point(409, 81);
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
            this.evrak_adi.Location = new System.Drawing.Point(148, 8);
            this.evrak_adi.Name = "evrak_adi";
            this.evrak_adi.Size = new System.Drawing.Size(101, 23);
            this.evrak_adi.TabIndex = 49;
            this.evrak_adi.Text = "Evrak Adı:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(261, 42);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(396, 20);
            this.txt_ID.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Evrak ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 245);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_evrakAd
            // 
            this.comboBox_evrakAd.FormattingEnabled = true;
            this.comboBox_evrakAd.Location = new System.Drawing.Point(261, 8);
            this.comboBox_evrakAd.Name = "comboBox_evrakAd";
            this.comboBox_evrakAd.Size = new System.Drawing.Size(396, 21);
            this.comboBox_evrakAd.TabIndex = 66;
            // 
            // Kayıtara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_evrakAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri_gel);
            this.Controls.Add(this.sql_ara);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Kayıtara";
            this.Text = "Kayıtara";
            this.Load += new System.EventHandler(this.Kayıtara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri_gel;
        private System.Windows.Forms.Button sql_ara;
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
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_evrakAd;
    }
}