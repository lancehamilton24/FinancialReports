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

        public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        {
            var response = await _apiClient.GetCompanyProfile(companyTicker);
            var profiles = response.Item3;
            var companyProfile = new CompanyProfile();
            foreach (var profile in profiles)
            {
                companyProfile = new CompanyProfile
                {
                    Symbol = profile.Symbol,
                    Name = profile.Name,
                    Price = profile.Price,
                    YearHigh = profile.YearHigh,
                    YearLow = profile.YearLow,
                    MarketCap = profile.MarketCap,
                    Eps = profile.Eps,
                    Pe = profile.Pe
                };
            }

            return companyProfile;
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
                    GrossProfitRatio = statement.GrossProfitRatio,
                    ResearchAndDevelopmentExpenses = statement.ResearchAndDevelopmentExpenses,
                    GeneralAndAdministrativeExpenses = statement.GeneralAndAdministrativeExpenses,
                    SellingAndMarketingExpenses = statement.SellingAndMarketingExpenses,
                    OperatingExpenses = statement.OperatingExpenses,
                    InterestExpense = statement.InterestExpense,
                    DepreciationAndAmortization = statement.DepreciationAndAmortization,
                    Ebitda = statement.Ebitda,
                    OperatingIncome = statement.OperatingIncome,
                    OperatingIncomeRatio = statement.OperatingIncomeRatio,
                    IncomeBeforeTax = statement.IncomeBeforeTax,
                    IncomeBeforeTaxRatio = statement.IncomeBeforeTaxRatio,
                    IncomeTaxExpense = statement.IncomeTaxExpense,
                    NetIncome = statement.NetIncome,
                    NetIncomeRatio = statement.NetIncomeRatio,
                    Eps = statement.Eps
                };

                incomeStatements.Add(incomeStatement);
            }

            return incomeStatements;
        }


        public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        {
            var response = await _apiClient.GetAllBalanceSheets(companyTicker);
            var balanceSheets = response.Item3;
            var balanceSheetList = new List<BalanceSheet>();
            foreach (var statement in balanceSheets)
            {
                var balanceSheet = new BalanceSheet
                {
                    Date = statement.Date,
                    CashAndCashEquivalents = statement.CashAndCashEquivalents,
                    ShortTermInvestments = statement.ShortTermInvestments,
                    CashAndShortTermInvestments = statement.CashAndShortTermInvestments,
                    NetReceivables = statement.NetReceivables,
                    Inventory = statement.Inventory,
                    TotalCurrentAssets = statement.TotalCurrentAssets,
                    PropertyPlantEquipmentNet = statement.PropertyPlantEquipmentNet,
                    Goodwill = statement.Goodwill,
                    IntangibleAssets = statement.IntangibleAssets,
                    GoodwillAndIntangibleAssets = statement.GoodwillAndIntangibleAssets,
                    LongTermInvestments = statement.LongTermInvestments,
                    TotalAssets = statement.TotalAssets,
                    AccountPayables = statement.AccountPayables,
                    ShortTermDebt = statement.ShortTermDebt,
                    TaxPayables = statement.TaxPayables,
                    TotalCurrentLiabilities = statement.TotalCurrentLiabilities,
                    LongTermDebt = statement.LongTermDebt,
                    TotalLiabilities = statement.TotalLiabilities,
                    CommonStock = statement.CommonStock,
                    RetainedEarnings = statement.RetainedEarnings,
                    TotalStockholdersEquity = statement.TotalStockholdersEquity,
                    TotalLiabilitiesAndStockholdersEquity = statement.TotalLiabilitiesAndStockholdersEquity,
                    TotalInvestments = statement.TotalInvestments,
                    TotalDebt = statement.TotalDebt,
                    NetDebt = statement.NetDebt
                };

                balanceSheetList.Add(balanceSheet);
            }

            return balanceSheetList;
        }

        public async Task<FinancialStatement> GetAllFinancialStatements(CompanyProfile companyProfile, List<IncomeStatement> incomeStatements, List<BalanceSheet> balanceSheets)
        {
            FinancialStatement financialStatements;
            financialStatements = new FinancialStatement()
            {
                CompanyProfile = companyProfile,
                IncomeStatement = incomeStatements,
                BalanceSheet = balanceSheets
            };

            financialStatements.CalculateFinancialSheetRatios();
            return financialStatements;
        }
    }
}
