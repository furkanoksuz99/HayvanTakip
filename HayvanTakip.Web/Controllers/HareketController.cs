using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;
using System;
using System.Linq;
using System.Web.Mvc;

namespace HayvanTakip.Web.Controllers
{
    public class HareketController : Controller
    {
        private readonly HareketManager _manager;
        private readonly HayvanManager _hayvanManager;
        private readonly IsletmeManager _isletmeManager;

        public HareketController()
        {
            _manager = new HareketManager();
            _hayvanManager = new HayvanManager();
            _isletmeManager = new IsletmeManager();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var veriler = _manager.GetAll();

            return View(veriler);
        }

        // CREATE GET
        [HttpGet]
        public ActionResult Create()
        {
            DropdownlariDoldur();

            return View();
        }

        // CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hareket hareket)
        {
            if (!ModelState.IsValid)
            {
                DropdownlariDoldur(
                    hareket.HayvanId,
                    hareket.KaynakIsletmeId,
                    hareket.HedefIsletmeId
                );

                return View(hareket);
            }

            try
            {
                hareket.KayitTarihi = DateTime.Now;

                _manager.Add(hareket);

                TempData["Success"] =
                    "Hareket kaydı başarıyla eklendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                DropdownlariDoldur(
                    hareket.HayvanId,
                    hareket.KaynakIsletmeId,
                    hareket.HedefIsletmeId
                );

                return View(hareket);
            }
        }

        // EDIT GET
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] =
                    "Güncellenecek hareket kaydı seçilmedi.";

                return RedirectToAction("Index");
            }

            var hareket = _manager.GetById(id.Value);

            if (hareket == null)
            {
                return HttpNotFound();
            }

            DropdownlariDoldur(
                hareket.HayvanId,
                hareket.KaynakIsletmeId,
                hareket.HedefIsletmeId
            );

            return View(hareket);
        }

        // EDIT POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hareket hareket)
        {
            if (!ModelState.IsValid)
            {
                DropdownlariDoldur(
                    hareket.HayvanId,
                    hareket.KaynakIsletmeId,
                    hareket.HedefIsletmeId
                );

                return View(hareket);
            }

            try
            {
                _manager.Update(hareket);

                TempData["Success"] =
                    "Hareket kaydı başarıyla güncellendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                DropdownlariDoldur(
                    hareket.HayvanId,
                    hareket.KaynakIsletmeId,
                    hareket.HedefIsletmeId
                );

                return View(hareket);
            }
        }

        // DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var sonuc = _manager.Delete(id);

            if (!sonuc)
            {
                TempData["Error"] =
                    "Silinecek hareket kaydı bulunamadı.";

                return RedirectToAction("Index");
            }

            TempData["Success"] =
                "Hareket kaydı başarıyla silindi.";

            return RedirectToAction("Index");
        }

        private void DropdownlariDoldur(
            int? seciliHayvanId = null,
            int? seciliKaynakIsletmeId = null,
            int? seciliHedefIsletmeId = null)
        {
            var hayvanlar = _hayvanManager.GetAktif();

            var isletmeler = _isletmeManager.GetAktif();

            ViewBag.Hayvanlar = new SelectList(
                hayvanlar,
                "Id",
                "KupeNo",
                seciliHayvanId
            );

            ViewBag.KaynakIsletmeler = new SelectList(
                isletmeler,
                "Id",
                "IsletmeAdi",
                seciliKaynakIsletmeId
            );

            ViewBag.HedefIsletmeler = new SelectList(
                isletmeler,
                "Id",
                "IsletmeAdi",
                seciliHedefIsletmeId
            );
        }
    }
}