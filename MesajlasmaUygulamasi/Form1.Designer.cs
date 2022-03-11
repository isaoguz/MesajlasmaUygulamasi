namespace MesajlasmaUygulamasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnGiris = new System.Windows.Forms.Button();
            this.MskNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.LblNumara1 = new System.Windows.Forms.Label();
            this.LblSifre1 = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(146, 146);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(133, 36);
            this.BtnGiris.TabIndex = 0;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // MskNumara
            // 
            this.MskNumara.Location = new System.Drawing.Point(146, 53);
            this.MskNumara.Mask = "0000";
            this.MskNumara.Name = "MskNumara";
            this.MskNumara.Size = new System.Drawing.Size(133, 31);
            this.MskNumara.TabIndex = 1;
            this.MskNumara.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(146, 108);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(133, 31);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // LblNumara1
            // 
            this.LblNumara1.AutoSize = true;
            this.LblNumara1.Location = new System.Drawing.Point(48, 56);
            this.LblNumara1.Name = "LblNumara1";
            this.LblNumara1.Size = new System.Drawing.Size(82, 23);
            this.LblNumara1.TabIndex = 3;
            this.LblNumara1.Text = "Numara: ";
            // 
            // LblSifre1
            // 
            this.LblSifre1.AutoSize = true;
            this.LblSifre1.Location = new System.Drawing.Point(76, 111);
            this.LblSifre1.Name = "LblSifre1";
            this.LblSifre1.Size = new System.Drawing.Size(54, 23);
            this.LblSifre1.TabIndex = 4;
            this.LblSifre1.Text = "Şifre: ";
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(146, 188);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(133, 36);
            this.BtnKayit.TabIndex = 5;
            this.BtnKayit.Text = "Kayıt Ol";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.LblSifre1);
            this.Controls.Add(this.LblNumara1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskNumara);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.MaskedTextBox MskNumara;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label LblNumara1;
        private System.Windows.Forms.Label LblSifre1;
        private System.Windows.Forms.Button BtnKayit;
    }
}

