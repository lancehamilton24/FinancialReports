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
        public List<CompanyProfile> CompanyProfile { get; set; }
        public List<IncomeStatement> IncomeStatement { get; set; }
        public List<BalanceSheet> BalanceSheet { get; set; }
        
        //private void CalculatePercentage()
        //{
        //    foreach (var iStatement in IncomeStatement)
        //    {
        //        CalculateNetReceivablesRatioPercentage(iStatement);
        //    }
        //}

        public void CalculateNetReceivablesRatioPercentage()
        {
            try
            {
                foreach (var iStatement in IncomeStatement)
                {
                    foreach (var bStatement in BalanceSheet.Where(x => x.Year == iStatement.Year))
                    {
                        double netReceivablesRatio = Math.Round(((double)bStatement.NetReceivables / (double)iStatement.Revenue) * 100);
                        bStatement.NetReceivablesRatioPercentage = netReceivablesRatio;
                    }
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
