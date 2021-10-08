using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Models
{
    public class FinancialStatement
    {
        public List<IncomeStatement> IncomeStatement { get; set; }
        public List<BalanceSheet> BalanceSheet { get; set; }
        public List<CashFlowStatement> CashFlowStatement { get; set; }
        public CompanyProfile CompanyProfile { get; set; }
        public List<CompetitiveAdvantageRatios> Ratios { get; set; }

        public async void CalculateFinancialSheetRatios()
        {
            try
            {

                foreach (var bStatement in BalanceSheet)
                {
                    CompetitiveAdvantageRatios ratios = new CompetitiveAdvantageRatios();
                    CalculateCrossStatementRatios(bStatement, ratios);

                }
            }
            catch (Exception e)
            {

            }
        }

        private void CalculateCrossStatementRatios(BalanceSheet balanceSheet, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                ratios.Year = balanceSheet.Year;
                ratios.CurrAssetsToLiabilitiesRatio = balanceSheet.CurrAssetsToLiabilitiesRatio;
                ratios.DebtToShareholdersEquityRatio = balanceSheet.DebtToShareholdersEquityRatio;

                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    //CalculateNetReceivablesRatio
                    if ((double)iStatement.Revenue > 0)
                    {
                        double netReceivablesRatio = ((double)balanceSheet.NetReceivables / (double)iStatement.Revenue) * 100;
                        ratios.NetReceivablesRatio = netReceivablesRatio;
                    }

                    //CalculateReturnOnAssetsRatio
                    if ((double)balanceSheet.TotalAssets > 0)
                    {
                        double returnOnAssetsRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalAssets) * 100);
                        ratios.ReturnOnAssetsRatio = returnOnAssetsRatio;
                    }

                    //CalculateReturnOnShareholdersEquityRatio
                    if ((double)balanceSheet.TotalStockholdersEquity > 0)
                    {
                        double returnOnShareholdersEquityRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalStockholdersEquity) * 100);
                        ratios.ReturnOnShareholdersEquityRatio = returnOnShareholdersEquityRatio;
                    }

                    ratios.GrossProfitRatioPercentage = iStatement.GrossProfitRatioPercentage;
                    ratios.NetIncomeRatioPercentage = iStatement.NetIncomeRatioPercentage;
                    ratios.SgaRatioPercentage = iStatement.SgaRatioPercentage;
                    ratios.RAndDRatioPercentage = iStatement.RAndDRatioPercentage;
                    ratios.DepreciationRatioPercentage = iStatement.DepreciationRatioPercentage;
                    ratios.InterestExpenseRatioPercentage = iStatement.InterestExpenseRatioPercentage;
                    ratios.IncomeTaxExpenseRatioPercentage = iStatement.IncomeTaxExpenseRatioPercentage;
                    ratios.OperatingExpenseRatio = iStatement.OperatingExpenseRatio;
                }

                foreach (var cFStatement in CashFlowStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    ratios.CapExMargin = cFStatement.CapExMargin;
                }

                Ratios.Add(ratios);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateBalanceSheetRatios(CashFlowStatement cashFlowStatement, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                //CalculateCapitalExpenditureToNetIncomeRatio
                ratios.NetReceivablesRatio = cashFlowStatement.CapExMargin;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateCashFlowRatios(CashFlowStatement cashFlowStatement, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                //CalculateCapitalExpenditureToNetIncomeRatio
                   ratios.CapExMargin = cashFlowStatement.CapExMargin;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
