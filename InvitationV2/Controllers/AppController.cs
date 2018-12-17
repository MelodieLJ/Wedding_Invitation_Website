using InvitationV2.Services;
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
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //when the browser needs to send us back info, it does that in the form of post
        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("melodiejosartist@gmail.com", $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "RSVP Sent";
                ModelState.Clear(); //clears the form
            }

            return View();
        }
    }
}
