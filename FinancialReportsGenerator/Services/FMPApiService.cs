using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class FMPApiService
    {
        FMPApiClient _apiClient;

        public FMPApiService(FMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<FinancialStatement> GetAllFinancialStatements(CompanyProfile companyProfile, List<IncomeStatement> incomeStatements, List<BalanceSheet> balanceSheets, List<CashFlowStatement> cashFlowStatements)
        {
            FinancialStatement financialStatements;
            financialStatements = new FinancialStatement()
            {
                CompanyProfile = companyProfile,
                IncomeStatement = incomeStatements,
                BalanceSheet = balanceSheets,
                CashFlowStatement = cashFlowStatements,
                Ratios = new List<CompetitiveAdvantageRatios>()
            };

            financialStatements.CalculateFinancialSheetRatios();
            return financialStatements;
        }
    }
}
