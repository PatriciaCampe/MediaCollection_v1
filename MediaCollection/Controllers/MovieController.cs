using MediaCollection.ServiceLayer;
using MediaCollection.ServiceLayer.ViewModels;
using MediaCollection.ServiceLayer.ViewModels.MovieViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCollection.Controllers
{
    public class MovieController : Controller
    {
        private readonly MediaService _mediaService;
        private readonly MovieService _movieService;
        //private readonly AddMovieViewModel _addMovieViewModel;

        public MovieController(MediaService mediaService, MovieService movieService)
        {
            _mediaService = mediaService ?? throw new ArgumentNullException(nameof(MediaService));
            _movieService = movieService ?? throw new ArgumentNullException(nameof(MediaService));
        }

        // GET: MovieController
        public ActionResult Index()
        {
            return View(_mediaService.ListMovies());
        }

        public IActionResult Create()
        {
            return View(_movieService.GetMovieGenres());
        }

        [HttpPost]
        public IActionResult Create([FromForm] AddMovieViewModel addMovieViewModel)
        {
            if (!TryValidateModel(addMovieViewModel))
            {
                return View(addMovieViewModel);
            }

            _movieService.AddMovie(addMovieViewModel);
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var movie = _movieService.GetMovie(id);
            
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            return View(_movieService.GetMovie4Update(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, [FromForm] UpdateMovieViewModel updMovieViewModel)
        {

            if (!TryValidateModel(updMovieViewModel))
            {
                return View(updMovieViewModel);
            }

            _movieService.UpdateMovie(id, updMovieViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            return View(_movieService.GetMovieToDelete(id));
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            bool result = _movieService.DeleteMovie(id);
            ViewData["result"] = result.ToString();
            return RedirectToAction(nameof(Index));
        }


        //[HttpGet]

        //public async Task<IActionResult> Create()
        //{
        //    AddMovieViewModel vm = new AddMovieViewModel();
        //    vm.ReleaseDate = DateTime.Now;
        //    return View(vm);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([FromForm] AddMovieViewModel addMovieViewModel)
        //{
        //    _movieservice.AddMovie(addMovieViewModel);
        //    return RedirectToAction(nameof(Index));
        //}

    }
}




// TO DELETE //
///////////////
// GET: MediaController/Details/5
//public ActionResult Details(int id)
//{
//    return View();
//}

//// GET: MediaController/Create
//public ActionResult Create()
//{
//    return View();
//}

//// POST: MediaController/Create
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Create(IFormCollection collection)
//{
//    try
//    {
//        return RedirectToAction(nameof(Index));
//    }
//    catch
//    {
//        return View();
//    }
//}

//// GET: MediaController/Edit/5
//public ActionResult Edit(int id)
//{
//    return View();
//}

//// POST: MediaController/Edit/5
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Edit(int id, IFormCollection collection)
//{
//    try
//    {
//        return RedirectToAction(nameof(Index));
//    }
//    catch
//    {
//        return View();
//    }
//}

//// GET: MediaController/Delete/5
//public ActionResult Delete(int id)
//{
//    return View();
//}

//// POST: MediaController/Delete/5
//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult Delete(int id, IFormCollection collection)
//{
//    try
//    {
//        return RedirectToAction(nameof(Index));
//    }
//    catch
//    {
//        return View();
//    }
//}
