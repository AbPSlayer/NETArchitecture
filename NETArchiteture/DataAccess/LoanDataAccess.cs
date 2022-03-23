using NETArchiteture.DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.DataAccess
{
    public class LoanDataAccess : ILoanDataAccess
    {

        public LoanInfoDataModel GetInfo(decimal loanNumber)
        {
            return new LoanInfoDataModel()
            {
                BorrowerName = "Abhinay Potluri",
                LoanNumber = 1099,
                Street01 = "1212 Abc ave",
                Street02 = "Apt 104"
            };

        }

        public LoanPropertyInfoDataModel GetPropertyInfo(decimal loanNumber)
        {

            return new LoanPropertyInfoDataModel()
            {
                PropertyValue = 100.00m,
                LoanNumber = 1099,
                Street01 = "1212 def ave",
                Street02 = "Apt 241"
            };
        }


        public void SaveBorrowerInfo(LoanBorrowerInputDataModel input)
        {

            //call sp

        }
    }
}
