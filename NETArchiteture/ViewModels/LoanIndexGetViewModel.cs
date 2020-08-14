using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.ViewModels
{
    public class LoanIndexGetViewModel
    {
        public decimal LoanNumber { get; set; }

        public string BorrowerName { get; set; }

        public string Address { get; set; }

        public decimal PropertyValue { get; set; }
        public string PropertyAddress { get; set; }
    }
}
