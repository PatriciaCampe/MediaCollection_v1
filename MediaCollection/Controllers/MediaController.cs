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
                    return View(_mediaService.ListMedia());
                }
            }
        }
    }
}
