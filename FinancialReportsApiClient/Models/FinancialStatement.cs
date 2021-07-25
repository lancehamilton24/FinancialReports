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
        public List<IncomeStatement> IncomeStatement { get; set; }
        public List<BalanceSheet> BalanceSheet { get; set; }

        public void CalculateFinancialSheetRatios()
        {
            foreach (var bStatement in BalanceSheet)
            {
                CalculateNetReceivablesRatioPercentage(bStatement);
            }
        }

        private void CalculateNetReceivablesRatioPercentage(BalanceSheet balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                        double netReceivablesRatio = Math.Round(((double)balanceSheet.NetReceivables / (double)iStatement.Revenue) * 100);
                        balanceSheet.NetReceivablesRatioPercentage = netReceivablesRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
