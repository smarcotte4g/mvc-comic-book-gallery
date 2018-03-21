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
        // Action Methods need to be Public
        public ActionResult Detail()
        {
            return View();
            
        }
    }
}