using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface ICashFlowStatementService
    {
        Task<List<CashFlowStatement>> CashFlowStatementsGet(string companyTicker);
    }
}