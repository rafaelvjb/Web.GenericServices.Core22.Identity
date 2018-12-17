using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMultiContext.DTOs;

namespace WebMultiContext.Controllers
{
    public class EmailsController : Controller
    {
        public IActionResult NovoEmailDeLista()
        {
            return PartialView("_Email", new EmailDto());
        }


    }
}