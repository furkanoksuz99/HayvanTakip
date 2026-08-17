using HayvanTakip.Business.Managers;
using HayvanTakip.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanTakip
{
    public partial class HastalikForm : Form
    {
        HastalikManager _hastalikManager;
        public HastalikForm()
        {
            InitializeComponent();

            _hastalikManager = new HastalikManager();

        }

        private void Listele()
        {
            using (var context = new HayvanTakip.DataAccess.Context.HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var hastaliklar = context.Hastaliklar.ToList();
                dataGridView1.DataSource = hastaliklar;
            }
        }
        private void HastalikForm_Load(object sender, EventArgs e)
        {
            using (var context = new HayvanTakip.DataAccess.Context.HayvanTakipContext())
            {
                var hayvanlar = context.Hayvanlar.ToList();
                cmbHayvan.DataSource = hayvanlar;
                cmbHayvan.DisplayMember = "KupeNo";
                cmbHayvan.ValueMember = "Id";
            }
            Listele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var hastalik = new Entities.Hastalik
                {
                    HayvanId = (int)cmbHayvan.SelectedValue,
                    HastalikAdi = txtHastalikAdi.Text,
                    TeshisTarihi = dtpTeshisTarihi.Value,
                    Belirtiler = txtBelirtiler.Text,
                    Aciklama = txtAciklama.Text,
                    DevamEdiyorMu = cbDevam.Checked,
                    KayitTarihi = DateTime.Today

                };
                _hastalikManager.Add(hastalik);
                MessageBox.Show("Hastalık başarıyla eklendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException?.InnerException?.Message ?? ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var hastalik = new Entities.Hastalik
                {
                    Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                    HayvanId = (int)cmbHayvan.SelectedValue,
                    HastalikAdi = txtHastalikAdi.Text,
                    TeshisTarihi = dtpTeshisTarihi.Value,
                    Belirtiler = txtBelirtiler.Text,
                    Aciklama = txtAciklama.Text,
                    DevamEdiyorMu = cbDevam.Checked,
                    KayitTarihi = DateTime.Today

                };
                _hastalikManager.Update(hastalik);
                MessageBox.Show("Hastalık başarıyla güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.InnerException?.InnerException?.Message ?? ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var hastalik = dataGridView1.Rows[e.RowIndex].DataBoundItem as Entities.Hastalik;

            if (hastalik == null)
                return;

            cmbHayvan.SelectedValue = hastalik.HayvanId;
            txtHastalikAdi.Text = hastalik.HastalikAdi;
            dtpTeshisTarihi.Value = hastalik.TeshisTarihi;
            txtBelirtiler.Text = hastalik.Belirtiler;
            txtAciklama.Text = hastalik.Aciklama;
            cbDevam.Checked = hastalik.DevamEdiyorMu;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var hastalikId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            try
            {
                _hastalikManager.Delete(hastalikId);
                MessageBox.Show(
                       "Hastalık kaydı başarıyla silindi.",
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                var query = context.Hastaliklar.AsQueryable();

                if (!string.IsNullOrEmpty(txtSearchHastalik.Text))
                {
                    query = query.Where(i => i.HastalikAdi.Contains(txtSearchHastalik.Text));
                }

                if (int.TryParse(txtSearchHayvan.Text, out int hayvanId))
                {
                    query = query.Where(i => i.HayvanId == hayvanId);
                }

                if (dtpSearhTeshis.Checked)
                {
                    var selectedDate = dtpSearhTeshis.Value.Date;
                    query = query.Where(i => DbFunctions.TruncateTime(i.TeshisTarihi) == selectedDate);
                }

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}