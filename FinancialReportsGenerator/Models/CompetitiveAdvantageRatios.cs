namespace FinancialReportsGenerator.Models
{
    public class CompetitiveAdvantageRatios
    {
        public string Year { get; set;  }
        //Cross Statement Margins
        public double NetReceivablesMargin { get; set; }
        public double ReturnOnAssetsMargin { get; set; }
        public double ReturnOnShareholdersEquityMargin { get; set; }

        //Balance Sheet Margins
        public double CurrAssetsToLiabilitiesMargin { get; set; }
        public double DebtToShareholdersEquityRatio { get; set; }

        //Income Statement Margins
        public double GrossProfitMargin { get; set; }
        public double NetIncomeMargin { get; set; }
        public double SgaMargin { get; set; }
        public double RAndDMargin { get; set; }
        public double DepreciationMargin { get; set; }
        public double InterestExpenseMargin { get; set; }
        public double IncomeTaxExpenseMargin { get; set; }
        public double OperatingExpenseMargin { get; set; }

        //CashFlow Statement Margins
        public double CapExMargin { get; set; }
    }
}
