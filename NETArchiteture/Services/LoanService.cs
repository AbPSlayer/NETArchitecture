using NETArchiteture.DataAccess;
using NETArchiteture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.Services
{
    public class LoanService : ILoanService
    {
        
        private readonly ILoanDataAccess loanDataAccess;

        public LoanService(ILoanDataAccess loanDataAccess)
        {
        
            this.loanDataAccess = loanDataAccess;
        }
        public LoanIndexGetViewModel Get(decimal loanNUmber)
        {
            

            var loanDataModel = loanDataAccess.GetInfo(loanNUmber);

            var propertyDataModel = loanDataAccess.GetPropertyInfo(loanNUmber);


            var loanViewModel = new LoanIndexGetViewModel
            {
                BorrowerName = loanDataModel.BorrowerName,
                Address = loanDataModel.Street01 + loanDataModel.Street02,
                LoanNumber = loanDataModel.LoanNumber,
                PropertyAddress = propertyDataModel.Street01 + propertyDataModel.Street02,
                PropertyValue = propertyDataModel.PropertyValue
            };

            return loanViewModel;



        }

        public void Save(LoanIndexPostViewModel input)
        {
            

            loanDataAccess.SaveBorrowerInfo(new DataAccess.DataModels.LoanBorrowerInputDataModel()
            {
                Salary = input.Salary,
                LoanNumber = input.LoanNumber,
                EmployeeId = 347
            });
        }
    }
}
