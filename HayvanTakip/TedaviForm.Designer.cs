namespace HayvanTakip
{
    partial class TedaviForm
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
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbHastalik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTedaviAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoz = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchTedavi = new System.Windows.Forms.TextBox();
            this.txtSearchHastalik = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(205, 466);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(265, 64);
            this.txtAciklama.TabIndex = 57;
            // 
            // dtpBitisTarih
            // 
            this.dtpBitisTarih.Location = new System.Drawing.Point(205, 363);
            this.dtpBitisTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBitisTarih.Name = "dtpBitisTarih";
            this.dtpBitisTarih.Size = new System.Drawing.Size(265, 23);
            this.dtpBitisTarih.TabIndex = 56;
            // 
            // dtpBaslangicTarih
            // 
            this.dtpBaslangicTarih.Location = new System.Drawing.Point(205, 315);
            this.dtpBaslangicTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBaslangicTarih.Name = "dtpBaslangicTarih";
            this.dtpBaslangicTarih.Size = new System.Drawing.Size(265, 23);
            this.dtpBaslangicTarih.TabIndex = 55;
            // 
            // cmbHastalik
            // 
            this.cmbHastalik.FormattingEnabled = true;
            this.cmbHastalik.Location = new System.Drawing.Point(205, 168);
            this.cmbHastalik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHastalik.Name = "cmbHastalik";
            this.cmbHastalik.Size = new System.Drawing.Size(160, 24);
            this.cmbHastalik.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(71, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(71, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(71, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(71, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tedavi Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(71, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "HastalıkId:";
            // 
            // txtTedaviAdi
            // 
            this.txtTedaviAdi.Location = new System.Drawing.Point(205, 219);
            this.txtTedaviAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTedaviAdi.Name = "txtTedaviAdi";
            this.txtTedaviAdi.Size = new System.Drawing.Size(132, 23);
            this.txtTedaviAdi.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 465);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(345, 573);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnUpdate.Location = new System.Drawing.Point(215, 573);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(75, 573);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(71, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "İlaç Adı:";
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(205, 265);
            this.txtIlacAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(132, 23);
            this.txtIlacAdi.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(71, 423);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Doz Bilgisi:";
            // 
            // txtDoz
            // 
            this.txtDoz.Location = new System.Drawing.Point(205, 419);
            this.txtDoz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoz.Name = "txtDoz";
            this.txtDoz.Size = new System.Drawing.Size(132, 23);
            this.txtDoz.TabIndex = 60;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnTemizle.Location = new System.Drawing.Point(195, 638);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(171, 37);
            this.btnTemizle.TabIndex = 108;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(105, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 41);
            this.label9.TabIndex = 127;
            this.label9.Text = "Tedavi Bilgileri ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 63);
            this.label8.TabIndex = 126;
            this.label8.Text = "🩺 Tedaviler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.btnFilterClear);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearchTedavi);
            this.groupBox5.Controls.Add(this.txtSearchHastalik);
            this.groupBox5.Location = new System.Drawing.Point(495, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(869, 41);
            this.groupBox5.TabIndex = 128;
            this.groupBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label14.Location = new System.Drawing.Point(234, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Hastalık Id :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(22, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Tedavi Adı :";
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnFilterClear.Location = new System.Drawing.Point(571, 13);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterClear.TabIndex = 119;
            this.btnFilterClear.Text = "TEMİZLE";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnSearch.Location = new System.Drawing.Point(470, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchTedavi
            // 
            this.txtSearchTedavi.Location = new System.Drawing.Point(108, 15);
            this.txtSearchTedavi.Name = "txtSearchTedavi";
            this.txtSearchTedavi.Size = new System.Drawing.Size(100, 23);
            this.txtSearchTedavi.TabIndex = 117;
            // 
            // txtSearchHastalik
            // 
            this.txtSearchHastalik.Location = new System.Drawing.Point(324, 14);
            this.txtSearchHastalik.Name = "txtSearchHastalik";
            this.txtSearchHastalik.Size = new System.Drawing.Size(100, 23);
            this.txtSearchHastalik.TabIndex = 116;
            // 
            // TedaviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1371, 714);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIlacAdi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtpBitisTarih);
            this.Controls.Add(this.dtpBaslangicTarih);
            this.Controls.Add(this.cmbHastalik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTedaviAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TedaviForm";
            this.Text = "TedaviForm";
            this.Load += new System.EventHandler(this.TedaviForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpBitisTarih;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarih;
        private System.Windows.Forms.ComboBox cmbHastalik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTedaviAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoz;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchTedavi;
        private System.Windows.Forms.TextBox txtSearchHastalik;
    }
}