using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class IncomeStatementService
    {
        FMPApiClient _apiClient;

        public IncomeStatementService(FMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        {
            var response = await _apiClient.GetAllIncomeStatements(companyTicker);
            var statements = response.Item3;
            var incomeStatements = new List<IncomeStatement>();
            foreach (var statement in statements)
            {
                var incomeStatement = new IncomeStatement
                {
                    Date = statement.Date,
                    Symbol = statement.Symbol,
                    Revenue = statement.Revenue,
                    CostOfRevenue = statement.CostOfRevenue,
                    GrossProfit = statement.GrossProfit,
                    GrossProfitMargin = statement.GrossProfitRatio,
                    ResearchAndDevelopmentExpenses = statement.ResearchAndDevelopmentExpenses,
                    GeneralAndAdministrativeExpenses = statement.GeneralAndAdministrativeExpenses,
                    SellingAndMarketingExpenses = statement.SellingAndMarketingExpenses,
                    OperatingExpenses = statement.OperatingExpenses,
                    InterestExpense = statement.InterestExpense,
                    DepreciationAndAmortization = statement.DepreciationAndAmortization,
                    Ebitda = statement.Ebitda,
                    OperatingIncome = statement.OperatingIncome,
                    OperatingIncomeMargin = statement.OperatingIncomeRatio,
                    IncomeBeforeTax = statement.IncomeBeforeTax,
                    IncomeBeforeTaxMargin = statement.IncomeBeforeTaxRatio,
                    IncomeTaxExpense = statement.IncomeTaxExpense,
                    NetIncome = statement.NetIncome,
                    NetIncomeMargin = statement.NetIncomeRatio,
                    Eps = statement.Eps
                };

                incomeStatements.Add(incomeStatement);
            }

            return incomeStatements;
        }
    }
}
