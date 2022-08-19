using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface IBalanceSheetService
    {
        Task<List<BalanceSheet>> BalanceSheetsGet(string companyTicker);
    }
}