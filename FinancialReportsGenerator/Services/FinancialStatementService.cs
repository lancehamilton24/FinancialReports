using FinancialReportsGenerator.Interfaces;
using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class FinancialStatementService
    {
        IncomeStatementService _incomeStatementService;
        BalanceSheetService _balanceSheetService;
        CashFlowStatementService _cashFlowService;
        IFMPApiClient _apiClient;

        public FinancialStatementService(IFMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            FinancialStatement financialStatements;
            financialStatements = new FinancialStatement()
            {
                //IncomeStatement = await GetAllIncomeStatements(companyTicker),
                //BalanceSheet = await GetAllBalanceSheets(companyTicker),
                CashFlowStatement = await GetAllCashFlowStatements(companyTicker),
                CompetitiveAdvantageRatios = new List<CompetitiveAdvantageRatios>()
            };

            financialStatements.CalculateFinancialSheetMargins();
            return financialStatements;
        }

        //public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        //{
        //    _incomeStatementService = new IncomeStatementService(_apiClient);
        //    var response = await _incomeStatementService.GetAllIncomeStatements(companyTicker);
        //    return response;
        //}

        public async Task<List<BalanceSheet>> BalanceSheetsGet(string companyTicker)
        {
            _balanceSheetService = new BalanceSheetService(_apiClient);
            var response = await _balanceSheetService.BalanceSheetsGet(companyTicker);
            return response;
        }

        public async Task<List<CashFlowStatement>> GetAllCashFlowStatements(string companyTicker)
        {
            _cashFlowService = new CashFlowStatementService(_apiClient);
            var response = await _cashFlowService.CashFlowStatementsGet(companyTicker);
            return response;
        }
    }
}
