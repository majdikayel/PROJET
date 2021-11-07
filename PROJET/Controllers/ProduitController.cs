using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PROJET.Models;
using System.IO;

namespace PROJET.Controllers
{
    public class ProduitController : Controller
    {
        Entities db = new Entities();
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AjoutProduit()
        {
            try
            {
                ViewBag.listeProduit = db.CAT_PRODUIT.ToList();
                ViewBag.listeCategorie = db.CAT_CATEGORIE.ToList();
                
                return View();

            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult AjoutProduit(CAT_PRODUIT  produit)
        {
            try
            {
                if (ModelState.IsValid)
                    {
                    if (Request.Files.Count > 0)
                    {
                        var file = Request.Files[0];//le nom de notre fichier
                        if(file !=null && file.ContentLength>0)
                        {
                            var fileName = Path.GetFileName(file.FileName);
                            var path = Path.Combine(Server.MapPath("~/Fichier"), fileName);
                            file.SaveAs(path);

                            produit.IMAGE_PRODUIT = fileName;
                            produit.URL_IMAGE_PRODUIT = "/Fichier";
                            
                        }
                    }
                    produit.DATE_SAISIE = DateTime.Now;
                    db.CAT_PRODUIT.Add(produit);
                    db.SaveChanges();

                }
                return RedirectToAction("AjoutProduit");

            }
            catch (Exception ex)
            {

                return HttpNotFound();
            }
        }
    }
}