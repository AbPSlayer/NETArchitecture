using NETArchiteture.ViewModels;

namespace NETArchiteture.Services
{
    public interface ILoanService
    {
        LoanIndexGetViewModel Get(decimal loanNUmber);
        void Save(LoanIndexPostViewModel input);
    }
}