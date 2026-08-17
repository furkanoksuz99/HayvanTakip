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
    public partial class HareketForm : Form
    {
        HareketManager _hareketManager;
        private object dtpHareketTarihi;

        public HareketForm()
        {
            InitializeComponent();
            _hareketManager = new HareketManager();
        }

        private void HareketForm_Load(object sender, EventArgs e)
        {
            Listele();

            using (var context = new HayvanTakipContext())
            {
                var hayvanlar = context.Hayvanlar.ToList();

                cmbHayvan.DataSource = hayvanlar;
                cmbHayvan.DisplayMember = "KupeNo";
                cmbHayvan.ValueMember = "Id";


                var isletmeler = context.Isletmeler.ToList();

                cmbKaynak.DataSource = isletmeler.ToList();
                cmbKaynak.DisplayMember = "IsletmeAdi";
                cmbKaynak.ValueMember = "Id";


                cmbHedef.DataSource = isletmeler.ToList();
                cmbHedef.DisplayMember = "IsletmeAdi";
                cmbHedef.ValueMember = "Id";


                var kaynaklar = context.Isletmeler
                    .Select(i => new
                    {
                        Id = (int?)i.Id,
                        IsletmeAdi = i.IsletmeAdi
                    })
                    .ToList();

                kaynaklar.Insert(0, new
                {
                    Id = (int?)null,
                    IsletmeAdi = ""
                });

                var hedefler = context.Isletmeler
                    .Select(i => new
                    {
                        Id = (int?)i.Id,
                        IsletmeAdi = i.IsletmeAdi
                    })
                    .ToList();

                hedefler.Insert(0, new
                {
                    Id = (int?)null,
                    IsletmeAdi = ""
                });

                cmbSearchKaynak.DataSource = kaynaklar;
                cmbSearchKaynak.DisplayMember = "IsletmeAdi";
                cmbSearchKaynak.ValueMember = "Id";


                cmbSearchHedef.DataSource = hedefler;
                cmbSearchHedef.DisplayMember = "IsletmeAdi";
                cmbSearchHedef.ValueMember = "Id";
            }

            cmbHareket.DataSource =
                Enum.GetValues(typeof(Entities.HareketTipi));

            txtSearchHareketTipi.Text = "";
        }


        private void Listele()
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var hareketler = context.Hareketler
                    .Select(h => new
                    {
                        h.Id,
                        h.HayvanId,
                        h.HareketTipi,

                        KaynakIsletmeId = h.KaynakIsletmeId,
                        KaynakIsletme = h.KaynakIsletme != null
                            ? h.KaynakIsletme.IsletmeAdi
                            : "",

                        HedefIsletmeId = h.HedefIsletmeId,
                        HedefIsletme = h.HedefIsletme != null
                            ? h.HedefIsletme.IsletmeAdi
                            : "",

                        h.HareketTarihi,
                        h.Aciklama,
                        h.KayitTarihi
                    })
                    .ToList();

                dataGridView1.DataSource = hareketler;

                if (dataGridView1.Columns["KaynakIsletmeId"] != null)
                    dataGridView1.Columns["KaynakIsletmeId"].Visible = false;

                if (dataGridView1.Columns["HedefIsletmeId"] != null)
                    dataGridView1.Columns["HedefIsletmeId"].Visible = false;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridView1.Rows[e.RowIndex];

            cmbHareket.SelectedItem =
                (Entities.HareketTipi)row.Cells["HareketTipi"].Value;

            cmbHayvan.SelectedValue =
                row.Cells["HayvanId"].Value;

            if (row.Cells["KaynakIsletmeId"].Value != DBNull.Value &&
                row.Cells["KaynakIsletmeId"].Value != null)
            {
                cmbKaynak.SelectedValue =
                    row.Cells["KaynakIsletmeId"].Value;
            }

            if (row.Cells["HedefIsletmeId"].Value != DBNull.Value &&
                row.Cells["HedefIsletmeId"].Value != null)
            {
                cmbHedef.SelectedValue =
                    row.Cells["HedefIsletmeId"].Value;
            }

            dtpHareketTarih.Value =
                Convert.ToDateTime(row.Cells["HareketTarihi"].Value);

            txtAciklama.Text =
                row.Cells["Aciklama"].Value?.ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new HayvanTakipContext())
                {
                    var hareket = new Entities.Hareket
                    {
                        HayvanId = (int)cmbHayvan.SelectedValue,
                        HareketTipi = (Entities.HareketTipi)cmbHareket.SelectedItem,
                        KaynakIsletmeId = (int)cmbKaynak.SelectedValue,
                        HedefIsletmeId = (int)cmbHedef.SelectedValue,
                        HareketTarihi = dtpHareketTarih.Value,
                        Aciklama = txtAciklama.Text,
                        KayitTarihi = DateTime.Today
                    };

                    _hareketManager.Add(hareket);

                    MessageBox.Show(
                        "Hareket kaydı başarıyla eklendi.",
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
                    var hareket = new Entities.Hareket
                    {
                        Id = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                        HayvanId = (int)cmbHayvan.SelectedValue,
                        HareketTipi = (Entities.HareketTipi)cmbHareket.SelectedItem,
                        KaynakIsletmeId = (int)cmbKaynak.SelectedValue,
                        HedefIsletmeId = (int)cmbHedef.SelectedValue,
                        HareketTarihi = dtpHareketTarih.Value,
                        Aciklama = txtAciklama.Text,
                        KayitTarihi = DateTime.Today
                    };

                    _hareketManager.Update(hareket);

                    MessageBox.Show(
                        "Hareket kaydı başarıyla güncellendi.",
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var hareketId =
                (int)dataGridView1.CurrentRow.Cells["Id"].Value;

            try
            {
                _hareketManager.Delete(hareketId);

                MessageBox.Show(
                    "Hareket kaydı başarıyla silindi.",
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
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new HayvanTakipContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                context.Configuration.ProxyCreationEnabled = false;

                var query =
                    context.Hareketler.AsQueryable();


                if (int.TryParse(
                    txtSearchHayvan.Text,
                    out int hayvanId))
                {
                    query = query.Where(
                        h => h.HayvanId == hayvanId);
                }


                string arama =
                    txtSearchHareketTipi.Text.Trim();

                if (!string.IsNullOrWhiteSpace(arama))
                {
                    if (Enum.TryParse<HareketTipi>(
                        arama,
                        true,
                        out var hareketTipi))
                    {
                        query = query.Where(
                            h => h.HareketTipi == hareketTipi);
                    }
                }


                if (cmbSearchKaynak.SelectedValue != null)
                {
                    int kaynakId =
                        (int)cmbSearchKaynak.SelectedValue;

                    query = query.Where(
                        h => h.KaynakIsletmeId == kaynakId);
                }


                if (cmbSearchHedef.SelectedValue != null)
                {
                    int hedefId =
                        (int)cmbSearchHedef.SelectedValue;

                    query = query.Where(
                        h => h.HedefIsletmeId == hedefId);
                }


                var hareketler = query
                    .Select(h => new
                    {
                        h.Id,
                        h.HayvanId,
                        h.HareketTipi,

                        KaynakIsletmeId = h.KaynakIsletmeId,
                        KaynakIsletme = h.KaynakIsletme != null
                            ? h.KaynakIsletme.IsletmeAdi
                            : "",

                        HedefIsletmeId = h.HedefIsletmeId,
                        HedefIsletme = h.HedefIsletme != null
                            ? h.HedefIsletme.IsletmeAdi
                            : "",

                        h.HareketTarihi,
                        h.Aciklama,
                        h.KayitTarihi
                    })
                    .ToList();


                dataGridView1.DataSource =
                    hareketler;


                if (dataGridView1.Columns["KaynakIsletmeId"] != null)
                    dataGridView1.Columns["KaynakIsletmeId"].Visible = false;

                if (dataGridView1.Columns["HedefIsletmeId"] != null)
                    dataGridView1.Columns["HedefIsletmeId"].Visible = false;
            }
        }


        private void cmbSearchKaynak_SelectedIndexChanged(object sender, EventArgs e)
        {

     
        }
    }
}