using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.DataAccess.DataModels
{
    public class LoanPropertyInfoDataModel
    {

        public decimal LoanNumber { get; set; }
        public string Street01 { get; set; }
        public string Street02 { get; set; }
        public decimal PropertyValue { get; set; }
    }
}
