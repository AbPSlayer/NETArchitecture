using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NETArchiteture.Loan
{
    public class LoanConcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
