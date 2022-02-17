using WebApp.Helpers;
using WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class TeamController : Controller
    {
        // GET: TeamController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                //var response = TeamModel.Save(new TeamModel
                //{
                //    TeamName = "100 Thieves",
                //    PlayerName = "Milan",
                //    PlayerLastN = "Oleksij",
                //    Role = "Top Laner",
                //    KDA = 3,
                //    CreepScore = 191,
                //});
                //if(response)
                //{
                //    return RedirectToAction(nameof(Index));
                //}
                //ViewBag["Error"] = "Error while creating new element";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
