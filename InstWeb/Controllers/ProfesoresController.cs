using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using InstWeb.Models;

namespace InstWeb.Controllers
{
    public class ProfesoresController : Controller
    {
        public ProfesoresController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}