using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Models
{
    public class CashFlowStatement
    {
        public DateTimeOffset Date { get; set; }
        public long NetIncome { get; set; }
        public long DepreciationAndAmortization { get; set; }
        public long DeferredIncomeTax { get; set; }
        public long StockBasedCompensation { get; set; }
        public long NetCashProvidedByOperatingActivities { get; set; }
        public long AcquisitionsNet { get; set; }
        public long NetCashUsedForInvestingActivites { get; set; }
        public long DebtRepayment { get; set; }
        public long CommonStockIssued { get; set; }
        public long CommonStockRepurchased { get; set; }
        public long DividendsPaid { get; set; }
        public long NetCashUsedProvidedByFinancingActivities { get; set; }
        public long CashAtEndOfPeriod { get; set; }
        public long CashAtBeginningOfPeriod { get; set; }
        public long OperatingCashFlow { get; set; }
        public long CapitalExpenditure { get; set; }
        public long FreeCashFlow { get; set; }
    }
}
