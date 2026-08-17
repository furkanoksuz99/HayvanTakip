namespace HayvanTakip
{
    partial class IsletmeForm
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
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIlKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsletmeAdı = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIlceKodu = new System.Windows.Forms.TextBox();
            this.cbAktif = new System.Windows.Forms.CheckBox();
            this.txtIsletmeNo = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSearchIsletme = new System.Windows.Forms.Label();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchIsletme = new System.Windows.Forms.TextBox();
            this.txtSearchIl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(192, 466);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(132, 23);
            this.txtTc.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(59, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "İl Kodu:";
            // 
            // txtIlKodu
            // 
            this.txtIlKodu.Location = new System.Drawing.Point(192, 313);
            this.txtIlKodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlKodu.Name = "txtIlKodu";
            this.txtIlKodu.Size = new System.Drawing.Size(132, 23);
            this.txtIlKodu.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(59, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "İşletme Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(59, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "İşletme No:";
            // 
            // txtIsletmeAdı
            // 
            this.txtIsletmeAdı.Location = new System.Drawing.Point(192, 267);
            this.txtIsletmeAdı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsletmeAdı.Name = "txtIsletmeAdı";
            this.txtIsletmeAdı.Size = new System.Drawing.Size(132, 23);
            this.txtIsletmeAdı.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 464);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(254, 574);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnUpdate.Location = new System.Drawing.Point(160, 574);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(64, 574);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(59, 470);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = "Yetkili TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(59, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(192, 404);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(132, 23);
            this.txtAdres.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(59, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "İlçe Kodu:";
            // 
            // txtIlceKodu
            // 
            this.txtIlceKodu.Location = new System.Drawing.Point(192, 358);
            this.txtIlceKodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlceKodu.Name = "txtIlceKodu";
            this.txtIlceKodu.Size = new System.Drawing.Size(132, 23);
            this.txtIlceKodu.TabIndex = 80;
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.cbAktif.Location = new System.Drawing.Point(63, 522);
            this.cbAktif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(57, 20);
            this.cbAktif.TabIndex = 84;
            this.cbAktif.Text = "Aktif";
            this.cbAktif.UseVisualStyleBackColor = true;
            // 
            // txtIsletmeNo
            // 
            this.txtIsletmeNo.Location = new System.Drawing.Point(192, 215);
            this.txtIsletmeNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsletmeNo.Name = "txtIsletmeNo";
            this.txtIsletmeNo.Size = new System.Drawing.Size(132, 23);
            this.txtIsletmeNo.TabIndex = 85;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnTemizle.Location = new System.Drawing.Point(152, 737);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(171, 37);
            this.btnTemizle.TabIndex = 108;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(42, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 41);
            this.label9.TabIndex = 113;
            this.label9.Text = "İşletme Bilgileri ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 63);
            this.label5.TabIndex = 112;
            this.label5.Text = "🏢 İşletmeler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lblSearchIsletme);
            this.groupBox5.Controls.Add(this.btnFilterClear);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearchIsletme);
            this.groupBox5.Controls.Add(this.txtSearchIl);
            this.groupBox5.Location = new System.Drawing.Point(388, 116);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(869, 41);
            this.groupBox5.TabIndex = 124;
            this.groupBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label14.Location = new System.Drawing.Point(255, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "İl Kodu :";
            // 
            // lblSearchIsletme
            // 
            this.lblSearchIsletme.AutoSize = true;
            this.lblSearchIsletme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchIsletme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblSearchIsletme.Location = new System.Drawing.Point(13, 18);
            this.lblSearchIsletme.Name = "lblSearchIsletme";
            this.lblSearchIsletme.Size = new System.Drawing.Size(89, 16);
            this.lblSearchIsletme.TabIndex = 121;
            this.lblSearchIsletme.Text = "İşletme Adı :";
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnFilterClear.Location = new System.Drawing.Point(566, 11);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterClear.TabIndex = 119;
            this.btnFilterClear.Text = "TEMİZLE";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnSearch.Location = new System.Drawing.Point(468, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchIsletme
            // 
            this.txtSearchIsletme.Location = new System.Drawing.Point(108, 15);
            this.txtSearchIsletme.Name = "txtSearchIsletme";
            this.txtSearchIsletme.Size = new System.Drawing.Size(100, 23);
            this.txtSearchIsletme.TabIndex = 117;
            // 
            // txtSearchIl
            // 
            this.txtSearchIl.Location = new System.Drawing.Point(321, 14);
            this.txtSearchIl.Name = "txtSearchIl";
            this.txtSearchIl.Size = new System.Drawing.Size(100, 23);
            this.txtSearchIl.TabIndex = 116;
            // 
            // IsletmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 705);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtIsletmeNo);
            this.Controls.Add(this.cbAktif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIlceKodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIlKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsletmeAdı);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IsletmeForm";
            this.Text = "IsletmeForm";
            this.Load += new System.EventHandler(this.IsletmeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIlKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsletmeAdı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIlceKodu;
        private System.Windows.Forms.CheckBox cbAktif;
        private System.Windows.Forms.TextBox txtIsletmeNo;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSearchIsletme;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchIsletme;
        private System.Windows.Forms.TextBox txtSearchIl;
    }
}