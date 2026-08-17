using HayvanTakip.Business.Managers;
using HayvanTakip.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HayvanTakip
{
    public partial class Form1 : Form
    {
        private HayvanManager _hayvanManager;
        public Form1()
        {
            InitializeComponent();

            _hayvanManager = new HayvanManager();
        }

        private void Listele()
        {
            using (var context = new HayvanTakipContext())
            {
               
                context.Configuration.LazyLoadingEnabled = false;

                var hayvanlar = context.Hayvanlar.ToList();

                dataGridView1.DataSource = hayvanlar;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            using (var context = new HayvanTakipContext())
            {

                var isletmeler = context.Isletmeler.ToList();

                cmbIsletme.DataSource = isletmeler;
                cmbIsletme.DisplayMember = "IsletmeAdi";
                cmbIsletme.ValueMember = "Id";

            }

            lblHayvanId.Visible = false;
            lblId.Visible = false;

            cmbDurum.DataSource =
                Enum.GetValues(typeof(Entities.HayvanDurumu));

            cmbCinsiyet.DataSource =
                Enum.GetValues(typeof(Entities.HayvanCinsiyeti));

            cmbSearchDurum.DataSource =
                Enum.GetValues(typeof(Entities.HayvanDurumu));

            cmbSearchDurum.SelectedIndex = -1;

            totalCount();

            

        }

        private void totalCount()
        {
            using (var context = new HayvanTakipContext())
            {
                int totalCount = context.Hayvanlar.Count();
                lblTotalCount.Text = totalCount.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var hayvan = new Entities.Hayvan
                {
                    KupeNo = txtKupeNo.Text,
                    Tur = txtTur.Text,
                    Irk = txtIrk.Text,
                    Cinsiyet = (Entities.HayvanCinsiyeti)cmbCinsiyet.SelectedItem,
                    DogumTarihi = dtpDogumTarihi.Value,
                    IsletmeId = (int)cmbIsletme.SelectedValue,
                    KayitTarihi = DateTime.Today,
                    Durum = (Entities.HayvanDurumu)cmbDurum.SelectedItem
                };

                _hayvanManager.Add(hayvan);
                MessageBox.Show("Hayvan başarıyla eklendi.");
                Listele();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var hayvan = dataGridView1.Rows[e.RowIndex].DataBoundItem as Entities.Hayvan;

            if (hayvan == null)
                return;
            lblHayvanId.Visible = true;
            lblId.Visible = true;
            txtIrk.Text = hayvan.Irk;
            txtKupeNo.Text = hayvan.KupeNo;
            cmbIsletme.SelectedValue = hayvan.IsletmeId;
            txtTur.Text = hayvan.Tur;
            dtpDogumTarihi.Value = hayvan.DogumTarihi;
            lblId.Text = hayvan.Id.ToString();
            cmbDurum.SelectedItem = hayvan.Durum;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var hayvan = new Entities.Hayvan
            {
                Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                KupeNo = txtKupeNo.Text,
                Tur = txtTur.Text,
                Irk = txtIrk.Text,
                Cinsiyet = (Entities.HayvanCinsiyeti)cmbCinsiyet.SelectedItem,
                DogumTarihi = dtpDogumTarihi.Value,
                IsletmeId = (int)cmbIsletme.SelectedValue,
                KayitTarihi = DateTime.Today,
                Durum = (Entities.HayvanDurumu)cmbDurum.SelectedItem
            };

            _hayvanManager.Update(hayvan);
            MessageBox.Show("Hayvan başarıyla güncellendi.");
            Listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var hayvanId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            _hayvanManager.PasifAl(hayvanId);
            MessageBox.Show("Hayvan pasif duruma alındı.");
            Listele();
        }

       

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtIrk.Clear();
            txtKupeNo.Clear();
            txtTur.Clear();
            dtpDogumTarihi.Value = DateTime.Today;
            lblHayvanId.Visible = false;
            lblId.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var query = context.Hayvanlar.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearchKupe.Text))
                {
                    query = query.Where(h =>
                        h.KupeNo.Contains(txtSearchKupe.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtSearchTur.Text))
                {
                    query = query.Where(h =>
                        h.Tur.Contains(txtSearchTur.Text));
                }
         
                var filteredHayvanlar = query.ToList();

                dataGridView1.DataSource = filteredHayvanlar;
            }
        }

        private void cmbSearchDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var query = context.Hayvanlar.AsQueryable();

                if (cmbSearchDurum.SelectedItem != null)
                {
                    var selectedDurum =
                        (Entities.HayvanDurumu)cmbSearchDurum.SelectedItem;

                    query = query.Where(h => h.Durum == selectedDurum);
                }

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            var form = new AsiForm();
            form.ShowDialog();
        }

        private void btnTedaviEkle_Click(object sender, EventArgs e)
        {
            var form = new TedaviForm();
            form.ShowDialog();
        }

        private void btnHastalikEkle_Click(object sender, EventArgs e)
        {
            var form = new HastalikForm();
            form.ShowDialog();
        }

        private void btnIsletmeEkle_Click(object sender, EventArgs e)
        {
            var form = new IsletmeForm();
            form.ShowDialog();
        }

        private void btnHareketEkle_Click(object sender, EventArgs e)
        {
            var form = new HareketForm();
            form.ShowDialog();
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            txtSearchKupe.Clear();
            txtSearchTur.Clear();
        }
    }
}
