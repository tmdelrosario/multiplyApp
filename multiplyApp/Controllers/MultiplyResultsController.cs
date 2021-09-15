using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using multiplyApp.Models;

namespace multiplyApp.Controllers
{
    public class MultiplyResultsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //multiplyResults/PostProduct
        public ActionResult PostProduct(MultiplyId multiply)
        {
            var mult = new MultiplyController();
            var tlobj = mult.Post(multiply.id);

            return Json(tlobj);
        }
    }
}