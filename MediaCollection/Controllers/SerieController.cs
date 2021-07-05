using MediaCollection.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class SerieController : Controller
    {
        private readonly MediaService _mediaService;

        public SerieController(MediaService mediaService)
        {
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(MediaService));
        }
        // GET: MovieController
        public ActionResult Index()
        {
            return View(_mediaService.ListSeries());
        }
    }
}
