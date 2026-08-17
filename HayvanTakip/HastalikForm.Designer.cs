namespace HayvanTakip
{
    partial class HastalikForm
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
            this.dtpTeshisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbHayvan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastalikAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBelirtiler = new System.Windows.Forms.TextBox();
            this.cbDevam = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchHayvan = new System.Windows.Forms.TextBox();
            this.txtSearchHastalik = new System.Windows.Forms.TextBox();
            this.dtpSearhTeshis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(133, 413);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(175, 70);
            this.txtAciklama.TabIndex = 57;
            // 
            // dtpTeshisTarihi
            // 
            this.dtpTeshisTarihi.Location = new System.Drawing.Point(133, 332);
            this.dtpTeshisTarihi.Name = "dtpTeshisTarihi";
            this.dtpTeshisTarihi.Size = new System.Drawing.Size(212, 20);
            this.dtpTeshisTarihi.TabIndex = 55;
            // 
            // cmbHayvan
            // 
            this.cmbHayvan.FormattingEnabled = true;
            this.cmbHayvan.Location = new System.Drawing.Point(133, 248);
            this.cmbHayvan.Name = "cmbHayvan";
            this.cmbHayvan.Size = new System.Drawing.Size(133, 21);
            this.cmbHayvan.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(33, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(33, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Teşhis Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(33, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hastalık Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(33, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "HayvanId";
            // 
            // txtHastalikAdi
            // 
            this.txtHastalikAdi.Location = new System.Drawing.Point(133, 290);
            this.txtHastalikAdi.Name = "txtHastalikAdi";
            this.txtHastalikAdi.Size = new System.Drawing.Size(112, 20);
            this.txtHastalikAdi.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 460);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(238, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 47);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnUpdate.Location = new System.Drawing.Point(141, 555);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 47);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(36, 555);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(33, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Belirtiler:";
            // 
            // txtBelirtiler
            // 
            this.txtBelirtiler.Location = new System.Drawing.Point(133, 376);
            this.txtBelirtiler.Name = "txtBelirtiler";
            this.txtBelirtiler.Size = new System.Drawing.Size(112, 20);
            this.txtBelirtiler.TabIndex = 58;
            // 
            // cbDevam
            // 
            this.cbDevam.AutoSize = true;
            this.cbDevam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbDevam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.cbDevam.Location = new System.Drawing.Point(36, 506);
            this.cbDevam.Name = "cbDevam";
            this.cbDevam.Size = new System.Drawing.Size(169, 20);
            this.cbDevam.TabIndex = 62;
            this.cbDevam.Text = "Hastalık Devam Ediyor";
            this.cbDevam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(60, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 41);
            this.label9.TabIndex = 127;
            this.label9.Text = "Hastalık Bilgileri ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 63);
            this.label6.TabIndex = 126;
            this.label6.Text = "🦠 Hastalıklar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpSearhTeshis);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.btnFilterClear);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearchHayvan);
            this.groupBox5.Controls.Add(this.txtSearchHastalik);
            this.groupBox5.Location = new System.Drawing.Point(387, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(945, 41);
            this.groupBox5.TabIndex = 128;
            this.groupBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label15.Location = new System.Drawing.Point(439, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 125;
            this.label15.Text = "Teşhis Tarihi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label14.Location = new System.Drawing.Point(227, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Hastalık Adı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(22, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Hayvan Id :";
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnFilterClear.Location = new System.Drawing.Point(870, 12);
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
            this.btnSearch.Location = new System.Drawing.Point(774, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchHayvan
            // 
            this.txtSearchHayvan.Location = new System.Drawing.Point(108, 15);
            this.txtSearchHayvan.Name = "txtSearchHayvan";
            this.txtSearchHayvan.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHayvan.TabIndex = 117;
            // 
            // txtSearchHastalik
            // 
            this.txtSearchHastalik.Location = new System.Drawing.Point(325, 13);
            this.txtSearchHastalik.Name = "txtSearchHastalik";
            this.txtSearchHastalik.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHastalik.TabIndex = 116;
            // 
            // dtpSearhTeshis
            // 
            this.dtpSearhTeshis.Location = new System.Drawing.Point(540, 14);
            this.dtpSearhTeshis.Name = "dtpSearhTeshis";
            this.dtpSearhTeshis.Size = new System.Drawing.Size(200, 20);
            this.dtpSearhTeshis.TabIndex = 126;
            // 
            // HastalikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1358, 726);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDevam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBelirtiler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtpTeshisTarihi);
            this.Controls.Add(this.cmbHayvan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastalikAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "HastalikForm";
            this.Text = "HastalikForm";
            this.Load += new System.EventHandler(this.HastalikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTeshisTarihi;
        private System.Windows.Forms.ComboBox cmbHayvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastalikAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBelirtiler;
        private System.Windows.Forms.CheckBox cbDevam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpSearhTeshis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchHayvan;
        private System.Windows.Forms.TextBox txtSearchHastalik;
    }
}