﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcFoad2024.Models;
using PagedList;
namespace MvcFoad2024.Controllers
{
    public class AuteursController : Controller
    {
        private BdPartagememoireContext db = new BdPartagememoireContext();
        private int sizePage = 2;
        // GET: Auteurs
        public ActionResult Index(int? page, string searchString, string sortOrder)
        {
            page = page.HasValue ? page : 1;
            ViewBag.PageTitle = "Liste des auteurs";
            ViewBag.View = "Index";
            ViewBag.Controller = "Auteur";
            ViewBag.action = "Liste des auteurs";

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";

            var lesAuteurs = from a in db.auteurs
                             select a;

            // Recherche
            if (!String.IsNullOrEmpty(searchString))
            {
                lesAuteurs = lesAuteurs.Where(a => a.Nom.Contains(searchString) || a.Prenom.Contains(searchString));
            }

            // Tri
            switch (sortOrder)
            {
                case "name_desc":
                    lesAuteurs = lesAuteurs.OrderByDescending(a => a.Nom);
                    break;
                case "Date":
                    lesAuteurs = lesAuteurs.OrderBy(a => a.Anciennete);
                    break;
                case "date_desc":
                    lesAuteurs = lesAuteurs.OrderByDescending(a => a.Anciennete);
                    break;
                default:
                    lesAuteurs = lesAuteurs.OrderBy(a => a.Nom);
                    break;
            }

            int pageNumber = (page ?? 1);
            return View(lesAuteurs.ToPagedList(pageNumber, sizePage));
        }

        // GET: Auteurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // GET: Auteurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auteurs/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUtilisateur,Nom,Prenom,Telephone,Email,motDePasse,Matricule,Etat,Specialite,Anciennete")] Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                db.auteurs.Add(auteur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auteur);
        }

        // GET: Auteurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // POST: Auteurs/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUtilisateur,Nom,Prenom,Telephone,Email,motDePasse,Matricule,Etat,Specialite,Anciennete")] Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auteur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auteur);
        }

        // GET: Auteurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // POST: Auteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Auteur auteur = db.auteurs.Find(id);
            db.auteurs.Remove(auteur);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
