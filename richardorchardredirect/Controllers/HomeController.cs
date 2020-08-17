using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using richardorchardredirect.Models;

namespace richardorchardredirect.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public RedirectResult Index()
        {
            return RedirectPermanent("http://www.richardorchard.com/");
        }

      
    }
}
