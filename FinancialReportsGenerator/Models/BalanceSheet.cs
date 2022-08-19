using System;

namespace FinancialReportsGenerator.Models
{
    public class BalanceSheet
    {
        public DateTimeOffset Date { get; set; }
        public long CashAndCashEquivalents { get; set; }
        public long ShortTermInvestments { get; set; }
        public long CashAndShortTermInvestments { get; set; }
        public long NetReceivables { get; set; }
        public long Inventory { get; set; }
        public long TotalCurrentAssets { get; set; }
        public long PropertyPlantEquipmentNet { get; set; }
        public long Goodwill { get; set; }
        public long IntangibleAssets { get; set; }
        public long GoodwillAndIntangibleAssets { get; set; }
        public long LongTermInvestments { get; set; }
        public long TotalAssets { get; set; }
        public long AccountPayables { get; set; }
        public long ShortTermDebt { get; set; }
        public long TaxPayables { get; set; }
        public long TotalCurrentLiabilities { get; set; }
        public long LongTermDebt { get; set; }
        public long TotalLiabilities { get; set; }
        public long CommonStock { get; set; }
        public long RetainedEarnings { get; set; }
        public long TotalStockholdersEquity { get; set; }
        public long TotalLiabilitiesAndStockholdersEquity { get; set; }
        public long TotalInvestments { get; set; }
        public long TotalDebt { get; set; }
        public long NetDebt { get; set; }

        public double NetReceivablesMargin { get; set; }

        public string Year { get { return Date.Year.ToString(); } }

        public double CurrAssetsToLiabilitiesMargin { get { return CalculateCurrAssetsToLiabilitiesMargin(); } }

        public double DebtToShareholdersEquityRatio { get { return CalculateDebtToShareholdersEquityRatio(); } }

        public double ReturnOnAssetsMargin { get; set; }

        public double ReturnOnShareholdersEquityMargin { get; set; }

        private double CalculateCurrAssetsToLiabilitiesMargin()
        {
            if (TotalCurrentLiabilities > 0)
            {
                double currAssetsToLiabilitiesMargin = Math.Round((double)TotalCurrentAssets / (double)TotalCurrentLiabilities);
                return currAssetsToLiabilitiesMargin;
            }
            else
            {
                return 0;
            }
        }

        private double CalculateDebtToShareholdersEquityRatio()
        {
            if (TotalStockholdersEquity > 0)
            {
                double DebtToShareholdersEquityRatio = ((double)TotalLiabilities / (double)TotalStockholdersEquity) * 100;
                return DebtToShareholdersEquityRatio;
            }
            else
            {
                return 0;
            }   
        }
    }
}
