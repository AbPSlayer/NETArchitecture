using NETArchiteture.DataAccess.DataModels;

namespace NETArchiteture.DataAccess
{
    public interface ILoanDataAccess
    {
        LoanInfoDataModel GetInfo(decimal loanNumber);
        LoanPropertyInfoDataModel GetPropertyInfo(decimal loanNumber);
        void SaveBorrowerInfo(LoanBorrowerInputDataModel input);
    }
}