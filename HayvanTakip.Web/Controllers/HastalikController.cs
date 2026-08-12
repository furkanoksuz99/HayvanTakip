using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;
using System;
using System.Web.Mvc;

namespace HayvanTakip.Web.Controllers
{
    public class HastalikController : Controller
    {
        private readonly HastalikManager _manager;
        private readonly HayvanManager _hayvanManager;

        public HastalikController()
        {
            _manager = new HastalikManager();
            _hayvanManager = new HayvanManager();
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
            HayvanDropdownDoldur();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hastalik hastalik)
        {
            if (!ModelState.IsValid)
            {
                HayvanDropdownDoldur(hastalik.HayvanId);

                return View(hastalik);
            }

            try
            {
                hastalik.KayitTarihi = DateTime.Now;

                _manager.Add(hastalik);

                TempData["Success"] =
                    "Hastalık kaydı başarıyla eklendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                HayvanDropdownDoldur(hastalik.HayvanId);

                return View(hastalik);
            }
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
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] =
                    "Güncellenecek hastalık kaydı seçilmedi.";

                return RedirectToAction("Index");
            }

            var hastalik = _manager.GetById(id.Value);

            if (hastalik == null)
            {
                return HttpNotFound();
            }

            HayvanDropdownDoldur(hastalik.HayvanId);

            return View(hastalik);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hastalik hastalik)
        {
            if (!ModelState.IsValid)
            {
                HayvanDropdownDoldur(hastalik.HayvanId);

                return View(hastalik);
            }

            try
            {
                _manager.Update(hastalik);

                TempData["Success"] =
                    "Hastalık kaydı başarıyla güncellendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                HayvanDropdownDoldur(hastalik.HayvanId);

                return View(hastalik);
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
                    "Silinecek hastalık kaydı bulunamadı.";

                return RedirectToAction("Index");
            }

            TempData["Success"] =
                "Hastalık kaydı başarıyla silindi.";

            return RedirectToAction("Index");
        }

    }
}