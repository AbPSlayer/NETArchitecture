using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.DataAccess.DataModels
{

    public class LoanBorrowerInputDataModel {
        public decimal LoanNumber { get; set; }
        public decimal Salary { get; set; }
        public int EmployeeId { get; set; }

    }
}
