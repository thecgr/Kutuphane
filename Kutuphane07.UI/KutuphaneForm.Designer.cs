namespace Kutuphane07.UI
{
    partial class KutuphaneForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitapImhaEt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(32, 106);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(66, 19);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click_1);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(69, 19);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click_1);
            // 
            // tsmiCikisYap
            // 
            this.tsmiCikisYap.Name = "tsmiCikisYap";
            this.tsmiCikisYap.Size = new System.Drawing.Size(66, 19);
            this.tsmiCikisYap.Text = "Çıkış Yap";
            this.tsmiCikisYap.Click += new System.EventHandler(this.tsmiCikisYap_Click_1);
            // 
            // cmbTurler
            // 
            this.cmbTurler.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(648, 150);
            this.cmbTurler.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(185, 31);
            this.cmbTurler.TabIndex = 1;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(574, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Türler";
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtArama.Location = new System.Drawing.Point(270, 153);
            this.txtArama.Margin = new System.Windows.Forms.Padding(5);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(242, 26);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(203, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(38, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kütüphane";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(32, 191);
            this.dgvKitaplar.Margin = new System.Windows.Forms.Padding(5);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(801, 262);
            this.dgvKitaplar.TabIndex = 6;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapOduncAl,
            this.tsmiKitapImhaEt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // tsmiKitapOduncAl
            // 
            this.tsmiKitapOduncAl.Name = "tsmiKitapOduncAl";
            this.tsmiKitapOduncAl.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapOduncAl.Text = "Kitabı Ödünç Al";
            this.tsmiKitapOduncAl.Click += new System.EventHandler(this.tsmiKitapOduncAl_Click_1);
            // 
            // tsmiKitapImhaEt
            // 
            this.tsmiKitapImhaEt.Name = "tsmiKitapImhaEt";
            this.tsmiKitapImhaEt.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapImhaEt.Text = "Kitabı İmha Et";
            this.tsmiKitapImhaEt.Click += new System.EventHandler(this.tsmiKitapImhaEt_Click_1);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 503);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KutuphaneForm";
            this.Padding = new System.Windows.Forms.Padding(32, 106, 32, 36);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing_1);
            this.Load += new System.EventHandler(this.KutuphaneForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikisYap;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapOduncAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapImhaEt;
    }
}