using FinancialReportsGenerator.JsonModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface IFMPApiClient
    {
        Task<Tuple<HttpStatusCode, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker);
        Task<Tuple<HttpStatusCode, List<IncomeStatementJson>>> IncomeStatementsGet(string companyTicker);
        Task<Tuple<HttpStatusCode, List<BalanceSheetJson>>> BalanceSheetsGet(string companyTicker);
        Task<Tuple<HttpStatusCode, List<CashFlowStatementJson>>> CashFlowStatementsGet(string companyTicker);
    }
}
