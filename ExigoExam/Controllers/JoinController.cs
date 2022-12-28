using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExigoExam.Models;

namespace ExigoExam.Controllers
{
    public class JoinController : Controller
    {
        public ActionResult Index()
        {
            var model = new CandidateModel();
            return View();
        }

        [HttpPost]
        public ActionResult Index(CandidateModel model)
        {
            return View("Index", model);
        }
    }
}
