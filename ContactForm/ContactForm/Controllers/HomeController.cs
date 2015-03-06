using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace ContactForm.Controllers
{
    //[Authorize(Role="Admin")]

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(new Models.ContactForm());
        }

        [HttpPost]
        public ActionResult Contact(Models.ContactForm contactForm)
        {
            //add the form to the database
            try
            {
                //try doing something...

                //set the date created
                contactForm.DateCreated = DateTime.Now;

                //adding something to the database...
                //step 1: create the data context
                Models.ContactFormsEntities db = new Models.ContactFormsEntities();

                //step 2: add the object to the table
                db.ContactForms.Add(contactForm);

                //step 3: SAVE
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                //if it blows up do this...
                ViewBag.Error = ex.Message;
                return View("Error");
            }

            //mail us a copy
            //SMTP: Simple Mail Transfer Protocol
            //host: mail.dustinkraft.com
            //port: 587
            //user: postmaster@dustinkraft.com
            //password: techIsFun1

            MailMessage mail = new MailMessage("Robots@SeedPaths.com", "ndstephens@gmail.com");
            //mail.From = new MailAddress("Robots@SeedPaths.com");
            //mail.To.Add("ndstephens@gmail.com");
            mail.Subject = "AWESOME EMAIL FROM " + contactForm.Name;
            mail.Body = string.Format("{0} at {1} just sent you the following message: {2}", contactForm.Name, contactForm.Email, contactForm.Body);

            //connecting to actual email server
            SmtpClient client = new SmtpClient("mail.dustinkraft.com");
            //client.Host = "mail.dustinkraft.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            client.Send(mail);

            //redirect user to the Thank You page
            return RedirectToAction("ThankYou", "Home");         
        }

        //create ThankYou action and view
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}