using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.JsonModels
{
    public class IncomeStatementJson
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

        [JsonProperty("revenue")]
        public long Revenue { get; set; }

        [JsonProperty("costOfRevenue")]
        public long CostOfRevenue { get; set; }

        [JsonProperty("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonProperty("grossProfitRatio")]
        public double GrossProfitRatio { get; set; }

        [JsonProperty("researchAndDevelopmentExpenses")]
        public long ResearchAndDevelopmentExpenses { get; set; }

        [JsonProperty("generalAndAdministrativeExpenses")]
        public long GeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("sellingAndMarketingExpenses")]
        public long SellingAndMarketingExpenses { get; set; }

        [JsonProperty("otherExpenses")]
        public long OtherExpenses { get; set; }

        [JsonProperty("operatingExpenses")]
        public long OperatingExpenses { get; set; }

        [JsonProperty("costAndExpenses")]
        public long CostAndExpenses { get; set; }

        [JsonProperty("interestExpense")]
        public long InterestExpense { get; set; }

        [JsonProperty("depreciationAndAmortization")]
        public long DepreciationAndAmortization { get; set; }

        [JsonProperty("ebitda")]
        public long Ebitda { get; set; }

        [JsonProperty("ebitdaratio")]
        public double Ebitdaratio { get; set; }

        [JsonProperty("operatingIncome")]
        public long OperatingIncome { get; set; }

        [JsonProperty("operatingIncomeRatio")]
        public double OperatingIncomeRatio { get; set; }

        [JsonProperty("totalOtherIncomeExpensesNet")]
        public long TotalOtherIncomeExpensesNet { get; set; }

        [JsonProperty("incomeBeforeTax")]
        public long IncomeBeforeTax { get; set; }

        [JsonProperty("incomeBeforeTaxRatio")]
        public double IncomeBeforeTaxRatio { get; set; }

        [JsonProperty("incomeTaxExpense")]
        public long IncomeTaxExpense { get; set; }

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("netIncomeRatio")]
        public double NetIncomeRatio { get; set; }

        [JsonProperty("eps")]
        public double Eps { get; set; }

        [JsonProperty("epsdiluted")]
        public double Epsdiluted { get; set; }

        [JsonProperty("weightedAverageShsOut")]
        public long WeightedAverageShsOut { get; set; }

        [JsonProperty("weightedAverageShsOutDil")]
        public long WeightedAverageShsOutDil { get; set; }

        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("finalLink")]
        public Uri FinalLink { get; set; }
    }
}
