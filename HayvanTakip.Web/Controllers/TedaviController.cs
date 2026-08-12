using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;
using System;
using System.Web.Mvc;

namespace HayvanTakip.Web.Controllers
{
    public class TedaviController : Controller
    {
        private readonly TedaviManager _manager;
        private readonly HastalikManager _hastalikManager;

        public TedaviController()
        {
            _manager = new TedaviManager();
            _hastalikManager = new HastalikManager();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var veriler = _manager.GetAll();

            return View(veriler);
        }

        [HttpGet]
        public ActionResult Create()
        {
            TedaviDropdownDoldur();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tedavi tedavi)

        {
            if (!ModelState.IsValid)
            {
                TedaviDropdownDoldur(tedavi.Id);

                return View(tedavi);
            }

            try
            {
                tedavi.KayitTarihi = DateTime.Now;

                _manager.Add(tedavi);

                TempData["Success"] =
                    "Hastalık kaydı başarıyla eklendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                TedaviDropdownDoldur(tedavi.Id);

                return View(tedavi);
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
                    "Silinecek tedavi kaydı bulunamadı.";

                return RedirectToAction("Index");
            }

            TempData["Success"] =
                "Tedavi kaydı başarıyla silindi.";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] =
                    "Güncellenecek hastalık kaydı seçilmedi.";

                return RedirectToAction("Index");
            }

            var tedavi = _manager.GetById(id.Value);

            if (tedavi == null)
            {
                return HttpNotFound();
            }

            TedaviDropdownDoldur(tedavi.Id);

            return View(tedavi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tedavi tedavi)
        {
            if (!ModelState.IsValid)
            {
                TedaviDropdownDoldur(tedavi.Id);

                return View(tedavi);
            }

            try
            {
                _manager.Update(tedavi);

                TempData["Success"] =
                    "Hastalık kaydı başarıyla güncellendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                TedaviDropdownDoldur(tedavi.Id);

                return View(tedavi);
            }
        }

        private void TedaviDropdownDoldur(
            int? seciliHastalikId = null)
        {
            var hastaliklar = _hastalikManager.GetAll();

            ViewBag.Hastaliklar = new SelectList(
                hastaliklar,
                "Id",
                "HastalikAdi",
                seciliHastalikId
            );
        }


    }
}