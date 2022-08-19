using FinancialReportsGenerator.Models;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface ICompanyProfileService
    {
        Task<CompanyProfile> GetCompanyProfile(string companyTicker);
    }
}