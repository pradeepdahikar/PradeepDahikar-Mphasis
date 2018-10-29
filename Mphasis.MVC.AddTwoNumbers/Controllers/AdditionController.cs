using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mphasis.MVC.AddTwoNumbers.Models;

namespace Mphasis.MVC.AddTwoNumbers.Controllers
{
    public class AdditionController : Controller
    {
        // GET: Addition
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Add the numbers
        /// </summary>
        /// <param name="requestmodel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(AdditionModel requestmodel)
        {
            AdditionModel model = new AdditionModel();// create an object of AdditionModel
            model.Result = model.Add(requestmodel);
            return View(model);
        }
    }
}