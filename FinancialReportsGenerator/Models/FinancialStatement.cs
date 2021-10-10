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
        public List<CompetitiveAdvantageRatios> CompetitiveAdvantageRatios { get; set; }

        public async void CalculateFinancialSheetMargins()
        {
            try
            {

                foreach (var bStatement in BalanceSheet)
                {
                    CompetitiveAdvantageRatios ratios = new CompetitiveAdvantageRatios();
                    CalculateCrossStatementMargins(bStatement, ratios);

                }
            }
            catch (Exception e)
            {

            }
        }

        private void CalculateCrossStatementMargins(BalanceSheet balanceSheet, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                ratios.Year = balanceSheet.Year;
                ratios.CurrAssetsToLiabilitiesMargin = balanceSheet.CurrAssetsToLiabilitiesMargin;
                ratios.DebtToShareholdersEquityRatio = balanceSheet.DebtToShareholdersEquityRatio;

                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    //CalculateNetReceivablesMargin
                    if ((double)iStatement.Revenue > 0)
                    {
                        double netReceivablesMargin = ((double)balanceSheet.NetReceivables / (double)iStatement.Revenue) * 100;
                        ratios.NetReceivablesMargin = netReceivablesMargin;
                    }

                    //CalculateReturnOnAssetsMargin
                    if ((double)balanceSheet.TotalAssets > 0)
                    {
                        double returnOnAssetsMargin = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalAssets) * 100);
                        ratios.ReturnOnAssetsMargin = returnOnAssetsMargin;
                    }

                    //CalculateReturnOnShareholdersEquityMargin
                    if ((double)balanceSheet.TotalStockholdersEquity > 0)
                    {
                        double returnOnShareholdersEquityMargin = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalStockholdersEquity) * 100);
                        ratios.ReturnOnShareholdersEquityMargin = returnOnShareholdersEquityMargin;
                    }

                    ratios.GrossProfitMargin = iStatement.GrossProfitRatio;
                    ratios.NetIncomeMargin = iStatement.NetIncomeRatio;
                    ratios.SgaMargin = iStatement.SgaMargin;
                    ratios.RAndDMargin = iStatement.RAndDMargin;
                    ratios.DepreciationMargin = iStatement.DepreciationMargin;
                    ratios.InterestExpenseMargin = iStatement.InterestExpenseMargin;
                    ratios.IncomeTaxExpenseMargin = iStatement.IncomeTaxExpenseMargin;
                    ratios.OperatingExpenseMargin = iStatement.OperatingExpenseMargin;
                }

                foreach (var cFStatement in CashFlowStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    ratios.CapExMargin = cFStatement.CapExMargin;
                }

                CompetitiveAdvantageRatios.Add(ratios);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateBalanceSheetMargins(CashFlowStatement cashFlowStatement, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                //CalculateCapitalExpenditureToNetIncomeMargin
                ratios.NetReceivablesMargin = cashFlowStatement.CapExMargin;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateCashFlowMargins(CashFlowStatement cashFlowStatement, CompetitiveAdvantageRatios ratios)
        {
            try
            {
                //CalculateCapitalExpenditureToNetIncomeMargin
                   ratios.CapExMargin = cashFlowStatement.CapExMargin;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
