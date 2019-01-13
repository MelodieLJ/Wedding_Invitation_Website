using InvitationV2.Data;
using InvitationV2.Data.Entities;
using InvitationV2.Services;
using InvitationV2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace InvitationV2.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly InvitationContext _context;

        public AppController(IMailService mailService, InvitationContext context)
        {
            _context = context;
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //when the browser needs to send us back info, it does that in the form of post
        [HttpPost]
        public IActionResult Index(RSVP model)
        {
            //if (ModelState.IsValid)
            //{
            //    _mailService.SendMessage("melodiejosartist@gmail.com", $"From: {model.Name} - {model.Email}, Message: {model.Message}");
            //    ViewBag.UserMessage = "RSVP Sent";
            //    ModelState.Clear(); //clears the form
            //}

            //AddData(model);
            SendEmail(model);
            ModelState.Clear();
            return View();
        }

        public void AddData(RSVP data)
        {
            _context.Add(data);
            _context.SaveChanges();
        }

        public void SendEmail(RSVP model)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("melartwedding@gmail.com", "F~Y)6&k4$2");
                MailMessage message = new MailMessage();
                message.To.Add("melartwedding@gmail.com");
                message.From = new MailAddress("melartwedding@gmail.com");
                message.Subject = model.Name;
                message.Body = model.DietReq;
                client.Send(message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Email not sent", ex.Message);
            }
        }
    }
}
