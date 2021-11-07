using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PROJET.Models;

namespace PROJET.Controllers
{
    public class CategorieController : Controller
    {
        Entities db = new Entities();
        // GET: Categorie
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AjoutCategorie()
        {
            try
            {
                ViewBag.listeCategorie = db.CAT_CATEGORIE.ToList();
                return View();

            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
        }
        [HttpPost]
        public ActionResult AjoutCategorie(CAT_CATEGORIE categorie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    categorie.DATE_SAISIE = DateTime.Now;
                    db.CAT_CATEGORIE.Add(categorie);
                    db.SaveChanges();

                }
                return RedirectToAction("AjoutCategorie");

            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
        }
    }

}