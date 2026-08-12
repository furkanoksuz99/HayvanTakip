using System;
using System.Linq;
using System.Web.Mvc;
using HayvanTakip.Business.Managers;
using HayvanTakip.Entities;

namespace HayvanTakip.Web.Controllers
{
    public class IsletmeController : Controller
    {
        private readonly IsletmeManager _manager;

        public IsletmeController()
        {
            _manager = new IsletmeManager();
        }

        [HttpGet]
        public ActionResult Index(
    string isletmeNo,
    string isletmeAdi,
    string ilKodu,
    bool? aktifMi)
        {
            var isletmeler = _manager.Search(
                isletmeNo,
                isletmeAdi,
                ilKodu,
                aktifMi
            );

            return View(isletmeler);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Isletme isletme)
        {
            try
            {
                _manager.Add(isletme);

                TempData["Success"] = "İşletme başarıyla eklendi.";

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(isletme);
            }
        }

        public ActionResult Delete(int id)
        {

            _manager.Delete(id);
            TempData["Success"] = "İşletme başarıyla silindi.";
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                var isletme = _manager.GetById(id);

                return View(isletme);
            }
            catch (Exception ex)
            {
                TempData["HataMesaji"] = ex.Message;

                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Isletme isletme)
        {
            try
            {
                _manager.Update(isletme);

                TempData["Success"] = "İşletme başarıyla güncellendi.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return View(isletme);
            }
        }

        public ActionResult Pasif()
        {
            var model = _manager.GetAll();
            return View("Index", model);
        }

        public ActionResult GetById(int id)
        {
            var detay = _manager.GetById(id);
            return View(detay);

        }
      
    }
}