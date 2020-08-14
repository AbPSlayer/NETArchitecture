using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.ViewModels
{
    public class LoanIndexPostViewModel {


        [Required]
        public decimal Salary { get; set; }
        public decimal LoanNumber { get; set; }
    }
}
