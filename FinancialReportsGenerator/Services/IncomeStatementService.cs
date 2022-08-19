using FinancialReportsGenerator.Interfaces;
using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class IncomeStatementService : IIncomeStatementService
    {
        IFMPApiClient _apiClient;

        public IncomeStatementService(IFMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<IncomeStatement>> IncomeStatementsGet(string companyTicker)
        {
            var response = await _apiClient.IncomeStatementsGet(companyTicker);
            var incomeStatements = new List<IncomeStatement>();

            if (response.Item1 == HttpStatusCode.OK)
            {
                var statements = response.Item2;
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
            }

            return new List<IncomeStatement>(incomeStatements);
        }
    }
}
