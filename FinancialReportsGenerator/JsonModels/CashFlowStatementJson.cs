using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.JsonModels
{
    public class CashFlowStatementJson
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

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("depreciationAndAmortization")]
        public long DepreciationAndAmortization { get; set; }

        [JsonProperty("deferredIncomeTax")]
        public long DeferredIncomeTax { get; set; }

        [JsonProperty("stockBasedCompensation")]
        public long StockBasedCompensation { get; set; }

        [JsonProperty("changeInWorkingCapital")]
        public long ChangeInWorkingCapital { get; set; }

        [JsonProperty("accountsReceivables")]
        public long AccountsReceivables { get; set; }

        [JsonProperty("inventory")]
        public long Inventory { get; set; }

        [JsonProperty("accountsPayables")]
        public long AccountsPayables { get; set; }

        [JsonProperty("otherWorkingCapital")]
        public long OtherWorkingCapital { get; set; }

        [JsonProperty("otherNonCashItems")]
        public long OtherNonCashItems { get; set; }

        [JsonProperty("netCashProvidedByOperatingActivities")]
        public long NetCashProvidedByOperatingActivities { get; set; }

        [JsonProperty("investmentsInPropertyPlantAndEquipment")]
        public long InvestmentsInPropertyPlantAndEquipment { get; set; }

        [JsonProperty("acquisitionsNet")]
        public long AcquisitionsNet { get; set; }

        [JsonProperty("purchasesOfInvestments")]
        public long PurchasesOfInvestments { get; set; }

        [JsonProperty("salesMaturitiesOfInvestments")]
        public long SalesMaturitiesOfInvestments { get; set; }

        [JsonProperty("otherInvestingActivites")]
        public long OtherInvestingActivites { get; set; }

        [JsonProperty("netCashUsedForInvestingActivites")]
        public long NetCashUsedForInvestingActivites { get; set; }

        [JsonProperty("debtRepayment")]
        public long DebtRepayment { get; set; }

        [JsonProperty("commonStockIssued")]
        public long CommonStockIssued { get; set; }

        [JsonProperty("commonStockRepurchased")]
        public long CommonStockRepurchased { get; set; }

        [JsonProperty("dividendsPaid")]
        public long DividendsPaid { get; set; }

        [JsonProperty("otherFinancingActivites")]
        public long OtherFinancingActivites { get; set; }

        [JsonProperty("netCashUsedProvidedByFinancingActivities")]
        public long NetCashUsedProvidedByFinancingActivities { get; set; }

        [JsonProperty("effectOfForexChangesOnCash")]
        public long EffectOfForexChangesOnCash { get; set; }

        [JsonProperty("netChangeInCash")]
        public long NetChangeInCash { get; set; }

        [JsonProperty("cashAtEndOfPeriod")]
        public long CashAtEndOfPeriod { get; set; }

        [JsonProperty("cashAtBeginningOfPeriod")]
        public long CashAtBeginningOfPeriod { get; set; }

        [JsonProperty("operatingCashFlow")]
        public long OperatingCashFlow { get; set; }

        [JsonProperty("capitalExpenditure")]
        public long CapitalExpenditure { get; set; }

        [JsonProperty("freeCashFlow")]
        public long FreeCashFlow { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("finalLink")]
        public Uri FinalLink { get; set; }
    }
}
