using FinancialReportsGenerator.Interfaces;
using FinancialReportsGenerator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class BalanceSheetService : IBalanceSheetService
    {
        IFMPApiClient _apiClient;

        public BalanceSheetService(IFMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public async Task<List<BalanceSheet>> BalanceSheetsGet(string companyTicker)
        {
            var response = await _apiClient.BalanceSheetsGet(companyTicker);
            var balanceSheets = response.Item2;
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
    }
}
