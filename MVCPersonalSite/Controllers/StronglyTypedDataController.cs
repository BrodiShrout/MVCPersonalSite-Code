using Microsoft.AspNetCore.Mvc;
using MVCPersonalSite.Models;
using MimeKit;
using MailKit.Net.Smtp; 
using System.ComponentModel.DataAnnotations;
using MVCPersonalSite.Models;
namespace MVCPersonalSite.Controllers
{
    public class StronglyTypedDataController : Controller
    {


        private readonly IConfiguration _config;

        public StronglyTypedDataController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel cvm)
        {
            //Check if the model is valid before you do anything else.
            if (!ModelState.IsValid)
            {
                //Send them back to the form. We can pass the object to the View so the form wwill contain the original information they provided
                return View(cvm);
            }

            //create the format for the message content we will resive from the contact form.
            string message = $"You have recived a new email from your sites contact form! <br>" +
                $"Sender: {cvm.Name} <br>" +
                $"Email: {cvm.Email} <br>" +
                $"Subject: {cvm.Subject} <br>" +
                $"Message: {cvm.Message}";
            #region Setting up the message
            //Create a MimeMessage object to assist with storing/transfering the email information from the contact form.
            var mm = new MimeMessage();

            //Even though the user is the one attempting to send a message to us, the actual sender of the email is the "email user" we set up is SmarterASP.

            mm.From.Add(new MailboxAddress("Sender", _config.GetValue<string>("Credentials:Email:User")));

            //string client = _config.GetValue<string>("Credentials:Email:Client");

            //string password = _config.GetValue<string>("Credentials:Email:Password");

            //The recipient of this email will be our personal address, also stored in appsettings.json
            mm.To.Add(new MailboxAddress("Personal", _config.GetValue<string>("Credentials:Email:Recipient")));

            //We can add the users email address to the list of ReplyTo addresses so our replies can be sent directly to them instead of the "email user" on smarter asp
            mm.ReplyTo.Add(new MailboxAddress("User", cvm.Email));

            //can be sent directly to them instead of the "Email user" on smart asp.
            mm.Subject = cvm.Subject;
            //If we dont have any HTML w can assign the body as mm.Body = message.
            mm.Body = new TextPart("HTML") { Text = message };

            //We can set the priority of the message so it will be flagged in our email client
            mm.Priority = MessagePriority.Urgent;
            #endregion

            #region Making The send email info(?)

            using (var Client = new SmtpClient())
            {
                Client.Connect(_config.GetValue<string>("Credentials:Email:Client"), 8889);
                //Client.Connect(_config.GetValue<string>("Credentials:Email:Client"), 25);
                try
                {
                    //login to the mail server using the cradentials for our email user
                    Client.Authenticate(
                        //username
                        _config.GetValue<string>("Credentials:Email:User"),
                        _config.GetValue<string>("Credentials:Email:Password")
                        );
                    Client.Send(mm);
                }
                catch (Exception ex)
                {
                    //if there is an issue, we can store a message in a ViewBag variable to be displayed in the view
                    ViewBag.ErrorMessage = $"There was an issue processing your request. Please try again later. <br> Error Message: {ex.Message}";
                    return View(cvm);
                }
                // if all goes well, return a View that displays a confirmation to the user that their Email was sent successfully
                return View("EmailConfirmation", cvm);
            }
            #endregion

        }
    }
}
