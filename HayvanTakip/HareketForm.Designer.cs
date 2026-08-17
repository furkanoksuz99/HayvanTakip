namespace HayvanTakip
{
    partial class HareketForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbHayvan = new System.Windows.Forms.ComboBox();
            this.cmbHareket = new System.Windows.Forms.ComboBox();
            this.cmbKaynak = new System.Windows.Forms.ComboBox();
            this.cmbHedef = new System.Windows.Forms.ComboBox();
            this.dtpHareketTarih = new System.Windows.Forms.DateTimePicker();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchHayvan = new System.Windows.Forms.TextBox();
            this.txtSearchHareketTipi = new System.Windows.Forms.TextBox();
            this.cmbSearchKaynak = new System.Windows.Forms.ComboBox();
            this.cmbSearchHedef = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(72, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Hareket Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(72, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Hedef İşletme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(72, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(195, 425);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(134, 51);
            this.txtAciklama.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(72, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Kaynak İşletme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(72, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Hareket Tipi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(72, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 91;
            this.label1.Text = "Hayvan Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 378);
            this.dataGridView1.TabIndex = 89;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(277, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnUpdate.Location = new System.Drawing.Point(180, 522);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 87;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(75, 522);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbHayvan
            // 
            this.cmbHayvan.FormattingEnabled = true;
            this.cmbHayvan.Location = new System.Drawing.Point(195, 218);
            this.cmbHayvan.Name = "cmbHayvan";
            this.cmbHayvan.Size = new System.Drawing.Size(121, 21);
            this.cmbHayvan.TabIndex = 102;
            // 
            // cmbHareket
            // 
            this.cmbHareket.FormattingEnabled = true;
            this.cmbHareket.Location = new System.Drawing.Point(195, 263);
            this.cmbHareket.Name = "cmbHareket";
            this.cmbHareket.Size = new System.Drawing.Size(121, 21);
            this.cmbHareket.TabIndex = 103;
            // 
            // cmbKaynak
            // 
            this.cmbKaynak.FormattingEnabled = true;
            this.cmbKaynak.Location = new System.Drawing.Point(195, 303);
            this.cmbKaynak.Name = "cmbKaynak";
            this.cmbKaynak.Size = new System.Drawing.Size(121, 21);
            this.cmbKaynak.TabIndex = 104;
            // 
            // cmbHedef
            // 
            this.cmbHedef.FormattingEnabled = true;
            this.cmbHedef.Location = new System.Drawing.Point(195, 340);
            this.cmbHedef.Name = "cmbHedef";
            this.cmbHedef.Size = new System.Drawing.Size(121, 21);
            this.cmbHedef.TabIndex = 105;
            // 
            // dtpHareketTarih
            // 
            this.dtpHareketTarih.Location = new System.Drawing.Point(195, 377);
            this.dtpHareketTarih.Name = "dtpHareketTarih";
            this.dtpHareketTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpHareketTarih.TabIndex = 106;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnTemizle.Location = new System.Drawing.Point(125, 573);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 30);
            this.btnTemizle.TabIndex = 107;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(81, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 41);
            this.label9.TabIndex = 129;
            this.label9.Text = "Hareket Bilgileri ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 63);
            this.label5.TabIndex = 128;
            this.label5.Text = "🔄 Hareketler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cmbSearchHedef);
            this.groupBox5.Controls.Add(this.cmbSearchKaynak);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.btnFilterClear);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearchHayvan);
            this.groupBox5.Controls.Add(this.txtSearchHareketTipi);
            this.groupBox5.Location = new System.Drawing.Point(418, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(945, 74);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label14.Location = new System.Drawing.Point(208, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Hareket Tipi :";
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnFilterClear.Location = new System.Drawing.Point(870, 45);
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
            this.btnSearch.Location = new System.Drawing.Point(774, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchHayvan
            // 
            this.txtSearchHayvan.Location = new System.Drawing.Point(89, 49);
            this.txtSearchHayvan.Name = "txtSearchHayvan";
            this.txtSearchHayvan.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHayvan.TabIndex = 117;
            // 
            // txtSearchHareketTipi
            // 
            this.txtSearchHareketTipi.Location = new System.Drawing.Point(306, 47);
            this.txtSearchHareketTipi.Name = "txtSearchHareketTipi";
            this.txtSearchHareketTipi.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHareketTipi.TabIndex = 116;
            // 
            // cmbSearchKaynak
            // 
            this.cmbSearchKaynak.FormattingEnabled = true;
            this.cmbSearchKaynak.Location = new System.Drawing.Point(437, 46);
            this.cmbSearchKaynak.Name = "cmbSearchKaynak";
            this.cmbSearchKaynak.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchKaynak.TabIndex = 131;
            this.cmbSearchKaynak.SelectedIndexChanged += new System.EventHandler(this.cmbSearchKaynak_SelectedIndexChanged);
            // 
            // cmbSearchHedef
            // 
            this.cmbSearchHedef.FormattingEnabled = true;
            this.cmbSearchHedef.Location = new System.Drawing.Point(592, 45);
            this.cmbSearchHedef.Name = "cmbSearchHedef";
            this.cmbSearchHedef.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchHedef.TabIndex = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(3, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Hayvan Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(434, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 133;
            this.label8.Text = "Kaynak İşletme ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label10.Location = new System.Drawing.Point(589, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 134;
            this.label10.Text = "Hedef İşletme";
            // 
            // HareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 739);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dtpHareketTarih);
            this.Controls.Add(this.cmbHedef);
            this.Controls.Add(this.cmbKaynak);
            this.Controls.Add(this.cmbHareket);
            this.Controls.Add(this.cmbHayvan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "HareketForm";
            this.Text = "HareketForm";
            this.Load += new System.EventHandler(this.HareketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbHayvan;
        private System.Windows.Forms.ComboBox cmbHareket;
        private System.Windows.Forms.ComboBox cmbKaynak;
        private System.Windows.Forms.ComboBox cmbHedef;
        private System.Windows.Forms.DateTimePicker dtpHareketTarih;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchHayvan;
        private System.Windows.Forms.TextBox txtSearchHareketTipi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSearchHedef;
        private System.Windows.Forms.ComboBox cmbSearchKaynak;
        private System.Windows.Forms.Label label13;
    }
}