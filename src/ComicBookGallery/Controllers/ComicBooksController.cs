﻿using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    // Controller classes need to be public
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        // Action Methods need to be Public
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
            
        }
    }
}