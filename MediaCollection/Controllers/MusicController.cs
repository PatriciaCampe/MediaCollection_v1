using MediaCollection.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class MusicController : Controller
    {
        private readonly MediaService _mediaService;
        //private readonly MusicService _movieService;
        //private readonly AddMovieViewModel _addMovieViewModel;

        public MusicController(MediaService mediaService, MovieService movieService)
        {
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(MediaService));
            //_musicService = movieService ?? throw new ArgumentNullException(nameof(MusicService));
        }

        // GET: MovieController
        public ActionResult Index()
        {
            return View(_mediaService.ListMusic());
        }
    }
}
