using MediaCollection.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class MediaController : Controller
    {
        private readonly MediaService _mediaService;

        public MediaController(MediaService mediaService)
        {
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(MediaService));
        }
        // GET: MediaController
        public ActionResult Index(string searchTitle,string mediaGenre)
        {
            if (!String.IsNullOrEmpty(searchTitle))
            { 
                return View(_mediaService.SearchMediaOnTitle(searchTitle)); 
            }
            else
            {
                if (!String.IsNullOrEmpty(mediaGenre))
                {
                     return View(_mediaService.SearchMediaOnGenre(mediaGenre));
                }
                else
                {
                    return View(_mediaService.ListMediaGenre());
                }
            }
        }

        // GET: MediaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: MediaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaController/Edit/5
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

        // GET: MediaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaController/Delete/5
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
