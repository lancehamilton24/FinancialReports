using FinancialReportsApiClient.JsonModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsApiClient.Models
{
    public class FinancialStatement
    {
        public List<IncomeStatementJson> IncomeStatement { get; set; }
        public List<BalanceSheetJson> BalanceSheet { get; set; }

        public void CalculateFinancialSheetRatios()
        {
            foreach (var bStatement in BalanceSheet)
            {
                CalculateNetReceivablesRatio(bStatement);
                CalculateReturnOnAssetsRatio(bStatement);
                CalculateReturnOnShareholdersEquityRatio(bStatement);
            }
        }

        private void CalculateNetReceivablesRatio(BalanceSheetJson balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                        double netReceivablesRatio = Math.Round(((double)balanceSheet.NetReceivables / (double)iStatement.Revenue) * 100);
                        balanceSheet.NetReceivablesRatio = netReceivablesRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateReturnOnAssetsRatio(BalanceSheetJson balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    double returnOnAssetsRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalAssets) * 100);
                    balanceSheet.ReturnOnAssetsRatio = returnOnAssetsRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateReturnOnShareholdersEquityRatio(BalanceSheetJson balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    double returnOnShareholdersEquityRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalStockholdersEquity) * 100);
                    balanceSheet.ReturnOnShareholdersEquityRatio = returnOnShareholdersEquityRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
