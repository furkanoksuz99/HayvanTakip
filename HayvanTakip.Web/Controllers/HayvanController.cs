using System;
using System.Web.Mvc;
using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;

namespace HayvanTakip.Web.Controllers
{
    public class HayvanController : Controller
    {
        private readonly HayvanManager _manager;
        private readonly IsletmeManager _isletmeManager;

        public HayvanController()
        {
            _manager = new HayvanManager();
            _isletmeManager = new IsletmeManager();
        }

        [HttpGet]
        public ActionResult Index(
            string kupeNo,
            string tur,
            string irk,
            int? isletmeId,
            HayvanCinsiyeti? cinsiyet,
            HayvanDurumu? durum)
        {
            var hayvanlar = _manager.Search(
                kupeNo,
                tur,
                irk,
                isletmeId,
                cinsiyet,
                durum
            );

            DropdownDoldur(isletmeId);

            return View(hayvanlar);
        }

        [HttpGet]
        public ActionResult Create()
        {
            DropdownDoldur();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hayvan hayvan)
        {
            if (!ModelState.IsValid)
            {
                DropdownDoldur(hayvan.IsletmeId);

                return View(hayvan);
            }

            try
            {
                hayvan.KayitTarihi = DateTime.Now;
                hayvan.Durum = HayvanDurumu.Aktif;

                _manager.Add(hayvan);

                TempData["Success"] = "Hayvan kaydı başarıyla eklendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                DropdownDoldur(hayvan.IsletmeId);

                return View(hayvan);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] = "Güncellenecek hayvan seçilmedi.";

                return RedirectToAction("Index");
            }

            var hayvan = _manager.GetById(id.Value);

            if (hayvan == null)
            {
                return HttpNotFound();
            }

            DropdownDoldur(hayvan.IsletmeId);

            return View(hayvan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hayvan hayvan)
        {
            if (!ModelState.IsValid)
            {
                DropdownDoldur(hayvan.IsletmeId);

                return View(hayvan);
            }

            _manager.Update(hayvan);

            TempData["Success"] = "Hayvan kaydı başarıyla güncellendi.";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult PasifAl(int? id)
        {
            if (!id.HasValue)
            {
                TempData["Error"] = "Pasife alınacak hayvan seçilmedi.";

                return RedirectToAction("Index");
            }

            _manager.PasifAl(id.Value);

            TempData["Success"] = "Hayvan pasife alındı.";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetPasif()
        {
            var hayvanlar = _manager.GetPasif();

            DropdownDoldur();

            return View("Index", hayvanlar);
        }

        [HttpGet]
        public ActionResult GetAktif()
        {
            var hayvanlar = _manager.GetAktif();

            DropdownDoldur();

            return View("Index", hayvanlar);
        }

        [HttpGet]
        public ActionResult TumVeriler()
        {
            var hayvanlar = _manager.GetAll();

            DropdownDoldur();

            return View("Index", hayvanlar);
        }

        private void DropdownDoldur(int? seciliIsletmeId = null)
        {
            var isletmeler = _isletmeManager.GetAll();

            ViewBag.Isletmeler = new SelectList(
                isletmeler,
                "Id",
                "IsletmeAdi",
                seciliIsletmeId
            );
        }
    }
}