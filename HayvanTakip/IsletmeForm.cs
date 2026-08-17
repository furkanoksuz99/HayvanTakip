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
    public partial class IsletmeForm: Form
    {
        IsletmeManager _isletmeManager;
        public IsletmeForm()
        {
            InitializeComponent();
            _isletmeManager = new IsletmeManager();
        }

        private void IsletmeForm_Load(object sender, EventArgs e)
        {
         Listele();

        }
        private void Listele()
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var isletmeler = context.Isletmeler.ToList();
                dataGridView1.DataSource = isletmeler;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var isletme = new Entities.Isletme
                    {
                        IsletmeNo = txtIsletmeNo.Text,
                        IsletmeAdi = txtIsletmeAdı.Text,
                        IlKodu = txtIlKodu.Text,
                        IlceKodu = txtIlceKodu.Text,
                        Adres = txtAdres.Text,
                        YetkiliTckn = txtTc.Text,
                        AktifMi = cbAktif.Checked,
                        KayitTarihi = DateTime.Today
                    };

                    _isletmeManager.Add(isletme);
                    MessageBox.Show(
                     "İşletme kaydı başarıyla eklendi.",
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var selectedRow = dataGridView1.CurrentRow;
                    if (selectedRow != null)
                    {
                        int isletmeId = (int)selectedRow.Cells["Id"].Value;
                        var isletme = context.Isletmeler.Find(isletmeId);
                        if (isletme != null)
                        {
                            isletme.IsletmeNo = txtIsletmeNo.Text;
                            isletme.IsletmeAdi = txtIsletmeAdı.Text;
                            isletme.IlKodu = txtIlKodu.Text;
                            isletme.IlceKodu = txtIlceKodu.Text;
                            isletme.Adres = txtAdres.Text;
                            isletme.YetkiliTckn = txtTc.Text;
                            isletme.AktifMi = cbAktif.Checked;
                            _isletmeManager.Update(isletme);
                            MessageBox.Show(
                                "İşletme kaydı başarıyla güncellendi.",
                                "Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            Listele();
                        }
         
                    }
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

            var isletme = dataGridView1.Rows[e.RowIndex].DataBoundItem as Entities.Isletme;

            if (isletme == null)
                return;
           
            txtAdres.Text = isletme.Adres;
            txtIlceKodu.Text = isletme.IlceKodu;
            txtIlKodu.Text = isletme.IlKodu;
            txtIsletmeAdı.Text = isletme.IsletmeAdi;
            txtIsletmeNo.Text = isletme.IsletmeNo;
            txtTc.Text = isletme.YetkiliTckn;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var isletmeId  = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            try
            {
                _isletmeManager.Delete(isletmeId);
                MessageBox.Show(
                    "İşletme kaydı başarıyla pasife alındı.",
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
            txtAdres.Clear();
            txtIlceKodu.Clear();
            txtIlKodu.Clear();
            txtIsletmeAdı.Clear();
            txtIsletmeNo.Clear();
            txtTc.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var query = context.Isletmeler.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtSearchIsletme.Text))
                {
                    query = query.Where(i =>
                        i.IsletmeAdi.Contains(txtSearchIsletme.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtSearchIl.Text))
                {
                    query = query.Where(i =>
                        i.IlKodu == txtSearchIl.Text);
                }

                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
