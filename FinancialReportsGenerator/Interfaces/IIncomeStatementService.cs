using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface IIncomeStatementService
    {
        Task<List<IncomeStatement>> IncomeStatementsGet(string companyTicker);
    }
}