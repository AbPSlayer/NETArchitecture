using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETArchiteture.Services;
using NETArchiteture.ViewModels;

namespace NETArchiteture.Controllers
{
    public class LoanController : Controller
    {
        private readonly ILoanService loanService;

        public LoanController(ILoanService loanService)
        {
            this.loanService = loanService;
        }
        [HttpGet]
        public IActionResult Index(decimal loanNumber)
        {

            
            var vm = loanService.Get(loanNumber);

            

            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(LoanIndexPostViewModel input)
        {
            //var input = new LoanIndexPostViewModel();
            //input.Salary = lblSalary.Text;
            //input.LoanNumber = lblLoanNumber.Text;

            

            if (ModelState.IsValid)
            {
                
                loanService.Save(input);
            }
            return View();
        }
    }
}
