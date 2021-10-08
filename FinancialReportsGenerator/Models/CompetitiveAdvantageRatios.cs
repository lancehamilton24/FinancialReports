using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Models
{
    public class CompetitiveAdvantageRatios
    {
        public string Year { get; set;  }
        //Cross Statement Ratios
        public double NetReceivablesRatio { get; set; }
        public double ReturnOnAssetsRatio { get; set; }
        public double ReturnOnShareholdersEquityRatio { get; set; }

        //Balance Sheet Ratios
        public double CurrAssetsToLiabilitiesRatio { get; set; }
        public double DebtToShareholdersEquityRatio { get; set; }

        //Income Statement Ratios
        public double GrossProfitRatioPercentage { get; set; }
        public double NetIncomeRatioPercentage { get; set; }
        public double SgaRatioPercentage { get; set; }
        public double RAndDRatioPercentage { get; set; }
        public double DepreciationRatioPercentage { get; set; }
        public double InterestExpenseRatioPercentage { get; set; }
        public double IncomeTaxExpenseRatioPercentage { get; set; }
        public double OperatingExpenseRatio { get; set; }

        //CashFlow Statement Ratios
        public double CapExMargin { get; set; }
    }
}
