using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace signalR_MVC.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }
        // GET: Chat/Welcome
        public ActionResult Welcome()
        {
            return View("Welcome");
        }
    }
}