namespace HayvanTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKupeNo = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtIrk = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIsletme = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnHareketEkle = new System.Windows.Forms.Button();
            this.btnIsletmeEkle = new System.Windows.Forms.Button();
            this.btnTedaviEkle = new System.Windows.Forms.Button();
            this.btnAsiEkle = new System.Windows.Forms.Button();
            this.btnHastalikEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHayvanId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchTur = new System.Windows.Forms.TextBox();
            this.txtSearchKupe = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSearchDurum = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.Location = new System.Drawing.Point(13, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdate.Location = new System.Drawing.Point(117, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnDelete.Location = new System.Drawing.Point(230, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(913, 376);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtKupeNo
            // 
            this.txtKupeNo.Location = new System.Drawing.Point(126, 111);
            this.txtKupeNo.Name = "txtKupeNo";
            this.txtKupeNo.Size = new System.Drawing.Size(100, 20);
            this.txtKupeNo.TabIndex = 4;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(126, 201);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 20);
            this.txtTur.TabIndex = 6;
            // 
            // txtIrk
            // 
            this.txtIrk.Location = new System.Drawing.Point(126, 240);
            this.txtIrk.Name = "txtIrk";
            this.txtIrk.Size = new System.Drawing.Size(100, 20);
            this.txtIrk.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(126, 282);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(126, 329);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Küpe No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(24, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "İşletme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(24, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(24, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Irk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(24, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(24, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Doğum Tarihi";
            // 
            // cmbIsletme
            // 
            this.cmbIsletme.FormattingEnabled = true;
            this.cmbIsletme.Location = new System.Drawing.Point(126, 155);
            this.cmbIsletme.Name = "cmbIsletme";
            this.cmbIsletme.Size = new System.Drawing.Size(121, 21);
            this.cmbIsletme.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblId.Location = new System.Drawing.Point(123, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblDurum.Location = new System.Drawing.Point(24, 375);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(54, 16);
            this.lblDurum.TabIndex = 21;
            this.lblDurum.Text = "Durum:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(126, 367);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 20;
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnHareketEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnHareketEkle.Location = new System.Drawing.Point(505, 130);
            this.btnHareketEkle.Name = "btnHareketEkle";
            this.btnHareketEkle.Size = new System.Drawing.Size(116, 56);
            this.btnHareketEkle.TabIndex = 22;
            this.btnHareketEkle.Text = "🔄 Hareketler";
            this.btnHareketEkle.UseVisualStyleBackColor = true;
            this.btnHareketEkle.Click += new System.EventHandler(this.btnHareketEkle_Click);
            // 
            // btnIsletmeEkle
            // 
            this.btnIsletmeEkle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnIsletmeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnIsletmeEkle.Location = new System.Drawing.Point(59, 124);
            this.btnIsletmeEkle.Name = "btnIsletmeEkle";
            this.btnIsletmeEkle.Size = new System.Drawing.Size(116, 56);
            this.btnIsletmeEkle.TabIndex = 23;
            this.btnIsletmeEkle.Text = "🏢 İşletmeler";
            this.btnIsletmeEkle.UseVisualStyleBackColor = true;
            this.btnIsletmeEkle.Click += new System.EventHandler(this.btnIsletmeEkle_Click);
            // 
            // btnTedaviEkle
            // 
            this.btnTedaviEkle.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.btnTedaviEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnTedaviEkle.Location = new System.Drawing.Point(299, 58);
            this.btnTedaviEkle.Name = "btnTedaviEkle";
            this.btnTedaviEkle.Size = new System.Drawing.Size(116, 56);
            this.btnTedaviEkle.TabIndex = 25;
            this.btnTedaviEkle.Text = "🩺 Tedaviler";
            this.btnTedaviEkle.UseVisualStyleBackColor = true;
            this.btnTedaviEkle.Click += new System.EventHandler(this.btnTedaviEkle_Click);
            // 
            // btnAsiEkle
            // 
            this.btnAsiEkle.Font = new System.Drawing.Font("Palatino Linotype", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnAsiEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnAsiEkle.Location = new System.Drawing.Point(59, 58);
            this.btnAsiEkle.Name = "btnAsiEkle";
            this.btnAsiEkle.Size = new System.Drawing.Size(116, 56);
            this.btnAsiEkle.TabIndex = 24;
            this.btnAsiEkle.Text = "💉 Aşılar";
            this.btnAsiEkle.UseVisualStyleBackColor = true;
            this.btnAsiEkle.Click += new System.EventHandler(this.btnAsiEkle_Click);
            // 
            // btnHastalikEkle
            // 
            this.btnHastalikEkle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnHastalikEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnHastalikEkle.Location = new System.Drawing.Point(505, 58);
            this.btnHastalikEkle.Name = "btnHastalikEkle";
            this.btnHastalikEkle.Size = new System.Drawing.Size(116, 56);
            this.btnHastalikEkle.TabIndex = 26;
            this.btnHastalikEkle.Text = "🦠 Hastalıklar";
            this.btnHastalikEkle.UseVisualStyleBackColor = true;
            this.btnHastalikEkle.Click += new System.EventHandler(this.btnHastalikEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(142, 622);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 30);
            this.btnTemizle.TabIndex = 108;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(720, 63);
            this.label6.TabIndex = 109;
            this.label6.Text = "🐄 HAYVAN TAKİP SİSTEMİ";
            // 
            // lblHayvanId
            // 
            this.lblHayvanId.AutoSize = true;
            this.lblHayvanId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHayvanId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblHayvanId.Location = new System.Drawing.Point(24, 71);
            this.lblHayvanId.Name = "lblHayvanId";
            this.lblHayvanId.Size = new System.Drawing.Size(82, 16);
            this.lblHayvanId.TabIndex = 110;
            this.lblHayvanId.Text = "Hayvan Id :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label9.Location = new System.Drawing.Point(35, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 41);
            this.label9.TabIndex = 111;
            this.label9.Text = "Hayvan Bilgileri ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHayvanId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.cmbIsletme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.txtIrk);
            this.groupBox1.Controls.Add(this.txtTur);
            this.groupBox1.Controls.Add(this.txtKupeNo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 403);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(44, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 92);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(111, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 31);
            this.label10.TabIndex = 112;
            this.label10.Text = "İşlemler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(400, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 395);
            this.groupBox3.TabIndex = 114;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnHastalikEkle);
            this.groupBox4.Controls.Add(this.btnTedaviEkle);
            this.groupBox4.Controls.Add(this.btnAsiEkle);
            this.groupBox4.Controls.Add(this.btnIsletmeEkle);
            this.groupBox4.Controls.Add(this.btnHareketEkle);
            this.groupBox4.Location = new System.Drawing.Point(452, 544);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 186);
            this.groupBox4.TabIndex = 115;
            this.groupBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(293, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 31);
            this.label11.TabIndex = 113;
            this.label11.Text = "Modüller";
            // 
            // txtSearchTur
            // 
            this.txtSearchTur.Location = new System.Drawing.Point(313, 14);
            this.txtSearchTur.Name = "txtSearchTur";
            this.txtSearchTur.Size = new System.Drawing.Size(100, 20);
            this.txtSearchTur.TabIndex = 116;
            // 
            // txtSearchKupe
            // 
            this.txtSearchKupe.Location = new System.Drawing.Point(108, 15);
            this.txtSearchKupe.Name = "txtSearchKupe";
            this.txtSearchKupe.Size = new System.Drawing.Size(100, 20);
            this.txtSearchKupe.TabIndex = 117;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnSearch.Location = new System.Drawing.Point(679, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 118;
            this.btnSearch.Text = "ARA";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnFilterClear.Location = new System.Drawing.Point(769, 12);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterClear.TabIndex = 119;
            this.btnFilterClear.Text = "TEMİZLE";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(22, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 121;
            this.label13.Text = "Küpe No :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label14.Location = new System.Drawing.Point(246, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 122;
            this.label14.Text = "Tür :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cmbSearchDurum);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.btnFilterClear);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearchKupe);
            this.groupBox5.Controls.Add(this.txtSearchTur);
            this.groupBox5.Location = new System.Drawing.Point(403, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(869, 41);
            this.groupBox5.TabIndex = 123;
            this.groupBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label15.Location = new System.Drawing.Point(456, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 125;
            this.label15.Text = "Durum :";
            // 
            // cmbSearchDurum
            // 
            this.cmbSearchDurum.FormattingEnabled = true;
            this.cmbSearchDurum.Location = new System.Drawing.Point(532, 12);
            this.cmbSearchDurum.Name = "cmbSearchDurum";
            this.cmbSearchDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchDurum.TabIndex = 124;
            this.cmbSearchDurum.SelectedIndexChanged += new System.EventHandler(this.cmbSearchDurum_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.label16.Location = new System.Drawing.Point(1180, 602);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 126;
            this.label16.Text = "TOPLAM HAYVAN :";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblTotalCount.Location = new System.Drawing.Point(1232, 636);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(15, 16);
            this.lblTotalCount.TabIndex = 127;
            this.lblTotalCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1351, 742);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTemizle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKupeNo;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtIrk;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIsletme;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnHareketEkle;
        private System.Windows.Forms.Button btnIsletmeEkle;
        private System.Windows.Forms.Button btnTedaviEkle;
        private System.Windows.Forms.Button btnAsiEkle;
        private System.Windows.Forms.Button btnHastalikEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHayvanId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchTur;
        private System.Windows.Forms.TextBox txtSearchKupe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSearchDurum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalCount;
    }
}

