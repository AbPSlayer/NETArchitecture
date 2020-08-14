using NETArchiteture.DataAccess;
using NETArchiteture.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETArchiteture.Services
{
    public class LoanService
    {

        public LoanIndexGetViewModel Get(decimal loanNUmber)
        {
            var loanDataAccess = new LoanDataAccess();

            var loanDataModel = loanDataAccess.GetInfo(loanNUmber);

            var propertyDataModel = loanDataAccess.GetPropertyInfo(loanNUmber);


            var loanViewModel = new LoanIndexGetViewModel();


            loanViewModel.BorrowerName = loanDataModel.BorrowerName;
            loanViewModel.Address = loanDataModel.Street01 + loanDataModel.Street02;
            loanViewModel.LoanNumber = loanDataModel.LoanNumber;
            loanViewModel.PropertyAddress = propertyDataModel.Street01 + propertyDataModel.Street02;
            loanViewModel.PropertyValue = propertyDataModel.PropertyValue;

            return loanViewModel;



        }

        public void Save(LoanIndexPostViewModel input)
        {
            var loanDataAccess = new LoanDataAccess();

            loanDataAccess.SaveBorrowerInfo(new DataAccess.DataModels.LoanBorrowerInputDataModel()
            {
                Salary = input.Salary,
                LoanNumber = input.LoanNumber,
                EmployeeId = 347
            });
        }
    }
}
