namespace Arsiv_Proje
{
    partial class ArsivProjesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArsivProjesi));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARŞİV PROJESİNE HOŞGELDİNİZ";
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisyap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_girisyap.Location = new System.Drawing.Point(79, 138);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(177, 52);
            this.btn_girisyap.TabIndex = 1;
            this.btn_girisyap.Text = "GİRİŞ YAP";
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayitol.Location = new System.Drawing.Point(79, 240);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(177, 48);
            this.btn_kayitol.TabIndex = 2;
            this.btn_kayitol.Text = "KAYIT OL";
            this.btn_kayitol.UseVisualStyleBackColor = false;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // ArsivProjesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.label1);
            this.Name = "ArsivProjesi";
            this.Text = "Arşiv Projesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_kayitol;
    }
}