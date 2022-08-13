using FinancialReportsGenerator.JsonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Interfaces
{
    public interface IFMPApiClient
    {
        Task<Tuple<HttpStatusCode, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker);
        Task<Tuple<HttpStatusCode, string, List<IncomeStatementJson>>> GetAllIncomeStatements(string companyTicker);
        Task<Tuple<HttpStatusCode, string, List<BalanceSheetJson>>> GetAllBalanceSheets(string companyTicker);
        Task<Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>> GetAllCashFlowStatements(string companyTicker);
    }
}
