namespace Kutuphane07.UI
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad ve Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(13, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(13, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parola Tekrar : ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(158, 230);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(232, 26);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(158, 275);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(232, 26);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(158, 331);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(232, 26);
            this.txtParola.TabIndex = 5;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(158, 371);
            this.txtParolaTekrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.PasswordChar = '*';
            this.txtParolaTekrar.Size = new System.Drawing.Size(232, 26);
            this.txtParolaTekrar.TabIndex = 7;
            this.txtParolaTekrar.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.Aquamarine;
            this.btnKayitOl.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnKayitOl.Location = new System.Drawing.Point(206, 427);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(124, 35);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane07.UI.Properties.Resources.member_card;
            this.pictureBox1.Location = new System.Drawing.Point(77, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(154, 306);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(187, 20);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı Geçersiz!";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.ForeColor = System.Drawing.Color.Red;
            this.lblParola.Location = new System.Drawing.Point(154, 402);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(141, 20);
            this.lblParola.TabIndex = 11;
            this.lblParola.Text = "Parola Geçersiz!";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 474);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtParolaTekrar);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
    }
}