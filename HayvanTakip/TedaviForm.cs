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
    public partial class TedaviForm : Form
    {
        TedaviManager _tedaviManager;
        public TedaviForm()
        {
            InitializeComponent();

            _tedaviManager = new TedaviManager();
        }

        private void Listele()
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var tedaviler = context.Tedaviler.ToList();
                dataGridView1.DataSource = tedaviler;
            }
        }
        private void TedaviForm_Load(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                var hastaliklar = context.Hastaliklar.ToList();
                cmbHastalik.DataSource = hastaliklar;
                cmbHastalik.DisplayMember = "HastalikAdi";
                cmbHastalik.ValueMember = "Id";
            }
            Listele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var tedavi = new Entities.Tedavi
                    {
                        HastalikId = (int)cmbHastalik.SelectedValue,
                        TedaviAdi = txtTedaviAdi.Text,
                        IlacAdi = txtIlacAdi.Text,
                        BaslangicTarihi = dtpBaslangicTarih.Value,
                        BitisTarihi = dtpBitisTarih.Value,
                        DozBilgisi = txtDoz.Text,
                        Aciklama = txtAciklama.Text,
                        KayitTarihi = DateTime.Today
                    };

                    _tedaviManager.Add(tedavi);
                    MessageBox.Show(
                  "Aşı kaydı başarıyla eklendi.",
                  "Başarılı",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
              );
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var tedavi = dataGridView1.Rows[e.RowIndex].DataBoundItem as Entities.Tedavi;

            if (tedavi == null)
                return;
            cmbHastalik.SelectedValue = tedavi.HastalikId;
            txtTedaviAdi.Text = tedavi.TedaviAdi;
            txtIlacAdi.Text = tedavi.IlacAdi;
            txtDoz.Text = tedavi.DozBilgisi;
            txtAciklama.Text = tedavi.Aciklama;
            dtpBaslangicTarih.Value = tedavi.BaslangicTarihi;
            dtpBitisTarih.Value = (DateTime)tedavi.BitisTarihi;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var tedavi = new Entities.Tedavi
                    {
                        DozBilgisi = txtDoz.Text,
                        Aciklama = txtAciklama.Text,
                        BaslangicTarihi = dtpBaslangicTarih.Value,
                        BitisTarihi = dtpBitisTarih.Value,
                        HastalikId = (int)cmbHastalik.SelectedValue,
                        Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                        IlacAdi = txtIlacAdi.Text,
                        TedaviAdi = txtTedaviAdi.Text
                    };
                    _tedaviManager.Update(tedavi);
                }

                MessageBox.Show(
                    "Tedavi kaydı başarıyla güncellendi.",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var tedaviId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            try
            {
                _tedaviManager.Delete(tedaviId);
                MessageBox.Show(
                    "Tedavi kaydı başarıyla silindi.",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Clear();
            txtDoz.Clear();
            txtIlacAdi.Clear();
            txtTedaviAdi.Clear();
            dtpBaslangicTarih.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var query = context.Tedaviler.AsQueryable();
                if (!string.IsNullOrWhiteSpace(txtSearchTedavi.Text))
                {
                    query = query.Where(t =>
                        t.TedaviAdi.Contains(txtSearchTedavi.Text));
                }
                if (int.TryParse(txtSearchHastalik.Text, out int hastalikId))
                {
                    query = query.Where(t =>
                        t.HastalikId == hastalikId);
                }

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            txtSearchHastalik.Clear();
            txtSearchTedavi.Clear();
        }
    }
}
           
