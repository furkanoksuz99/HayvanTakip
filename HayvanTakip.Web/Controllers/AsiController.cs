using System;
using System.Web.Mvc;
using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;

namespace HayvanTakip.Web.Controllers
{
    public class AsiController : Controller
    {
        private readonly AsiManager _manager;
        private readonly HayvanManager _hayvanManager;

        public AsiController()
        {
            _manager = new AsiManager();
            _hayvanManager = new HayvanManager();
        }

        [HttpGet]
        public ActionResult Index(
            string kupeNo,
            string asiAdi,
            DateTime? baslangicTarihi,
            DateTime? bitisTarihi)
        {
            var asilar = _manager.Search(
                kupeNo,
                asiAdi,
                baslangicTarihi,
                bitisTarihi
            );

            return View(asilar);
        }

        [HttpGet]
        public ActionResult Create()
        {
            HayvanDropdownDoldur();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Asi asi)
        {
            if (!ModelState.IsValid)
            {
                HayvanDropdownDoldur(asi.HayvanId);

                return View(asi);
            }

            try
            {
                asi.KayitTarihi = DateTime.Now;

                _manager.Add(asi);

                TempData["Success"] =
                    "Aşı kaydı başarıyla eklendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                HayvanDropdownDoldur(asi.HayvanId);

                return View(asi);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] =
                    "Güncellenecek aşı kaydı seçilmedi.";

                return RedirectToAction("Index");
            }

            var asi = _manager.GetById(id.Value);

            if (asi == null)
            {
                return HttpNotFound();
            }

            HayvanDropdownDoldur(asi.HayvanId);

            return View(asi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Asi asi)
        {
            if (!ModelState.IsValid)
            {
                HayvanDropdownDoldur(asi.HayvanId);

                return View(asi);
            }

            try
            {
                _manager.Update(asi);

                TempData["Success"] =
                    "Aşı kaydı başarıyla güncellendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                HayvanDropdownDoldur(asi.HayvanId);

                return View(asi);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var sonuc = _manager.Delete(id);

            if (!sonuc)
            {
                TempData["Error"] =
                    "Silinecek aşı kaydı bulunamadı.";

                return RedirectToAction("Index");
            }

            TempData["Success"] =
                "Aşı kaydı başarıyla silindi.";

            return RedirectToAction("Index");
        }

        private void HayvanDropdownDoldur(
            int? seciliHayvanId = null)
        {
            var hayvanlar = _hayvanManager.GetAktif();

            ViewBag.Hayvanlar = new SelectList(
                hayvanlar,
                "Id",
                "KupeNo",
                seciliHayvanId
            );
        }
        [HttpGet]
        public ActionResult Yaklasan()
        {
            var asilar = _manager.GetYaklasan();

            return View("Index", asilar);
        }

         
        [HttpGet]
        public ActionResult Geciken()
        {
            var asilar = _manager.GetGeciken();

            return View("Index", asilar);
        }
    }

}