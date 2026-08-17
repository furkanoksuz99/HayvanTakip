using HayvanTakip.Business.Managers;
using HayvanTakip.DataAccess.Context;
using HayvanTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanTakip
{
    public partial class AsiForm: Form
    {

        private AsiManager _asiManager;
        public AsiForm()
        {
            InitializeComponent();

            _asiManager = new AsiManager();
        }

        private void Listele()
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var asilar = context.Asilar.ToList();
                dataGridView1.DataSource = asilar;
            }
        }

        private void AsiForm_Load(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
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
                var asi = new Entities.Asi
                {
                    HayvanId = (int)cmbHayvan.SelectedValue,
                    AsiAdi = txtAsiAdi.Text,
                    AsiTarihi = dtpAsiTarihi.Value,
                    SonrakiAsiTarihi = dtpSonrakiAsi.Value,
                    Aciklama = txtAciklama.Text,
                    KayitTarihi = DateTime.Today
                };

                _asiManager.Add(asi);

                MessageBox.Show(
                    "Aşı kaydı başarıyla eklendi.",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var asi = new Entities.Asi
                    {
                        Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                        HayvanId = (int)cmbHayvan.SelectedValue,
                        AsiAdi = txtAsiAdi.Text,
                        AsiTarihi = dtpAsiTarihi.Value,
                        SonrakiAsiTarihi = dtpSonrakiAsi.Value,
                        Aciklama = txtAciklama.Text
                    };
                    _asiManager.Update(asi);
                    MessageBox.Show(
                        "Aşı kaydı başarıyla güncellendi.",
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

            var asi = dataGridView1.Rows[e.RowIndex].DataBoundItem as Entities.Asi;

            if (asi == null)
                return;
            cmbHayvan.SelectedValue = asi.HayvanId;
            txtAsiAdi.Text = asi.AsiAdi;
            dtpAsiTarihi.Value = asi.AsiTarihi;
            dtpSonrakiAsi.Value = (DateTime)asi.SonrakiAsiTarihi;
            txtAciklama.Text = asi.Aciklama;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var AsiId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                _asiManager.Delete(AsiId);                   
                 MessageBox.Show(
                        "Aşı kaydı başarıyla güncellendi.",
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
            txtAsiAdi.Clear();
            dtpAsiTarihi.Value = DateTime.Today;
            dtpSonrakiAsi.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {    
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;
                var searchText = txtSearchAsi.Text.Trim().ToLower();

                int.TryParse(txtSearchHayvan.Text, out int searchHayvanId);

                var filteredAsilar = context.Asilar
                    .Where(a =>
                        a.AsiAdi.ToLower().Contains(searchText) ||
                        (searchHayvanId > 0 && a.HayvanId == searchHayvanId)
                    )
                    .ToList();

                dataGridView1.DataSource = filteredAsilar;
            }
        }
    }
}
