using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Learn_Academy.Models;
using Learn_Academy.Controllers;

namespace Learn_Academy.Controllers
{
    public class MultipleModelInOneViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
        public ActionResult IndexViewModel()
        {
            ViewModel mymodel = new ViewModel();
            mymodel.Course = GetCourse();
            mymodel.Membership = GetMembership();
            return View(mymodel);
        }
        */
    }
}