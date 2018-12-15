using InvitationV2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvitationV2.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //when the browser needs to send us back info it does that in the form of a post
        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}
