namespace Kutuphane07.UI
{
    partial class HesabimForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapTeslimEt = new System.Windows.Forms.Button();
            this.dtpSonTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(28, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(437, 340);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Gill Sans MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblParola.Location = new System.Drawing.Point(9, 256);
            this.lblParola.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(71, 27);
            this.lblParola.TabIndex = 0;
            this.lblParola.Text = "Parola:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Gill Sans MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(9, 192);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(120, 27);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Gill Sans MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdSoyad.Location = new System.Drawing.Point(9, 114);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(94, 27);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Gill Sans MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblId.Location = new System.Drawing.Point(9, 46);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 27);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapTeslimEt);
            this.groupBox2.Controls.Add(this.dtpSonTeslimTarihi);
            this.groupBox2.Controls.Add(this.dgvKitaplar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(489, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(688, 340);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Alınan Kitaplar";
            // 
            // btnKitapTeslimEt
            // 
            this.btnKitapTeslimEt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnKitapTeslimEt.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapTeslimEt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnKitapTeslimEt.Location = new System.Drawing.Point(425, 293);
            this.btnKitapTeslimEt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnKitapTeslimEt.Name = "btnKitapTeslimEt";
            this.btnKitapTeslimEt.Size = new System.Drawing.Size(247, 38);
            this.btnKitapTeslimEt.TabIndex = 3;
            this.btnKitapTeslimEt.Text = "Kitap Teslim Et";
            this.btnKitapTeslimEt.UseVisualStyleBackColor = false;
            this.btnKitapTeslimEt.Click += new System.EventHandler(this.btnKitapTeslimEt_Click);
            // 
            // dtpSonTeslimTarihi
            // 
            this.dtpSonTeslimTarihi.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpSonTeslimTarihi.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpSonTeslimTarihi.Location = new System.Drawing.Point(21, 295);
            this.dtpSonTeslimTarihi.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpSonTeslimTarihi.Name = "dtpSonTeslimTarihi";
            this.dtpSonTeslimTarihi.Size = new System.Drawing.Size(219, 36);
            this.dtpSonTeslimTarihi.TabIndex = 2;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(14, 35);
            this.dgvKitaplar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(658, 233);
            this.dgvKitaplar.TabIndex = 0;
            this.dgvKitaplar.SelectionChanged += new System.EventHandler(this.dgvKitaplar_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Son Teslim Tarihi:";
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "HesabimForm";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapTeslimEt;
        private System.Windows.Forms.DateTimePicker dtpSonTeslimTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKitaplar;
    }
}