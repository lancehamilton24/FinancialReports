using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.JsonModels
{
    public class BalanceSheetJson
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("reportedCurrency")]
        public string ReportedCurrency { get; set; }

        [JsonProperty("fillingDate")]
        public DateTimeOffset FillingDate { get; set; }

        [JsonProperty("acceptedDate")]
        public DateTimeOffset AcceptedDate { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("cashAndCashEquivalents")]
        public long CashAndCashEquivalents { get; set; }

        [JsonProperty("shortTermInvestments")]
        public long ShortTermInvestments { get; set; }

        [JsonProperty("cashAndShortTermInvestments")]
        public long CashAndShortTermInvestments { get; set; }

        [JsonProperty("netReceivables")]
        public long NetReceivables { get; set; }

        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        [JsonProperty("otherCurrentAssets")]
        public long OtherCurrentAssets { get; set; }

        [JsonProperty("totalCurrentAssets")]
        public long TotalCurrentAssets { get; set; }

        [JsonProperty("propertyPlantEquipmentNet")]
        public long PropertyPlantEquipmentNet { get; set; }

        [JsonProperty("goodwill")]
        public long Goodwill { get; set; }

        [JsonProperty("intangibleAssets")]
        public long IntangibleAssets { get; set; }

        [JsonProperty("goodwillAndIntangibleAssets")]
        public long GoodwillAndIntangibleAssets { get; set; }

        [JsonProperty("longTermInvestments")]
        public long LongTermInvestments { get; set; }

        [JsonProperty("taxAssets")]
        public long TaxAssets { get; set; }

        [JsonProperty("otherNonCurrentAssets")]
        public long OtherNonCurrentAssets { get; set; }

        [JsonProperty("totalNonCurrentAssets")]
        public long TotalNonCurrentAssets { get; set; }

        [JsonProperty("otherAssets")]
        public long OtherAssets { get; set; }

        [JsonProperty("totalAssets")]
        public long TotalAssets { get; set; }

        [JsonProperty("accountPayables")]
        public long AccountPayables { get; set; }

        [JsonProperty("shortTermDebt")]
        public long ShortTermDebt { get; set; }

        [JsonProperty("taxPayables")]
        public long TaxPayables { get; set; }

        [JsonProperty("deferredRevenue")]
        public long DeferredRevenue { get; set; }

        [JsonProperty("otherCurrentLiabilities")]
        public long OtherCurrentLiabilities { get; set; }

        [JsonProperty("totalCurrentLiabilities")]
        public long TotalCurrentLiabilities { get; set; }

        [JsonProperty("longTermDebt")]
        public long LongTermDebt { get; set; }

        [JsonProperty("deferredRevenueNonCurrent")]
        public long DeferredRevenueNonCurrent { get; set; }

        [JsonProperty("deferredTaxLiabilitiesNonCurrent")]
        public long DeferredTaxLiabilitiesNonCurrent { get; set; }

        [JsonProperty("otherNonCurrentLiabilities")]
        public long OtherNonCurrentLiabilities { get; set; }

        [JsonProperty("totalNonCurrentLiabilities")]
        public long TotalNonCurrentLiabilities { get; set; }

        [JsonProperty("otherLiabilities")]
        public long OtherLiabilities { get; set; }

        [JsonProperty("totalLiabilities")]
        public long TotalLiabilities { get; set; }

        [JsonProperty("commonStock")]
        public long CommonStock { get; set; }

        [JsonProperty("retainedEarnings")]
        public long RetainedEarnings { get; set; }

        [JsonProperty("accumulatedOtherComprehensiveIncomeLoss")]
        public long AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        [JsonProperty("othertotalStockholdersEquity")]
        public long OthertotalStockholdersEquity { get; set; }

        [JsonProperty("totalStockholdersEquity")]
        public long TotalStockholdersEquity { get; set; }

        [JsonProperty("totalLiabilitiesAndStockholdersEquity")]
        public long TotalLiabilitiesAndStockholdersEquity { get; set; }

        [JsonProperty("totalInvestments")]
        public long TotalInvestments { get; set; }

        [JsonProperty("totalDebt")]
        public long TotalDebt { get; set; }

        [JsonProperty("netDebt")]
        public long NetDebt { get; set; }

        public double NetReceivablesMargin { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("finalLink")]
        public Uri FinalLink { get; set; }
    }
}
