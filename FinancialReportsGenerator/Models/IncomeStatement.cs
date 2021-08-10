using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Models
{
    public class IncomeStatement
    {
        public DateTimeOffset Date { get; set; }
        public string Symbol { get; set; }
        public long Revenue { get; set; }
        public long CostOfRevenue { get; set; }
        public long GrossProfit { get; set; }
        public double GrossProfitRatio { get; set; }
        public long ResearchAndDevelopmentExpenses { get; set; }
        public long GeneralAndAdministrativeExpenses { get; set; }
        public long SellingAndMarketingExpenses { get; set; }
        public long OperatingExpenses { get; set; }
        public long InterestExpense { get; set; }
        public long DepreciationAndAmortization { get; set; }
        public long Ebitda { get; set; }
        public long OperatingIncome { get; set; }
        public double OperatingIncomeRatio { get; set; }
        public long IncomeBeforeTax { get; set; }
        public double IncomeBeforeTaxRatio { get; set; }
        public long IncomeTaxExpense { get; set; }
        public long NetIncome { get; set; }
        public double NetIncomeRatio { get; set; }
        public double Eps { get; set; }

        public string Year { get { return Date.Year.ToString(); } }

        public double GrossProfitRatioPercentage { get { return CalculateGrossProfitRatioPercentage(); } }

        public double NetIncomeRatioPercentage { get { return CalculateNetIncomeRatioPercentage(); } }

        public double SgaRatioPercentage { get { return CalculateSGARatioPercentage(); } }

        public double RAndDRatioPercentage { get { return CalculateRAndDRatioPercentage(); } }

        public double DepreciationRatioPercentage { get { return CalculateDepreciationRatioPercentage(); } }

        public double InterestExpenseRatioPercentage { get { return CalculateInterestRatioPercentage(); } }

        public double IncomeTaxExpenseRatioPercentage { get { return CalculateIncomeTaxRatioPercentage(); } }

        public double OperatingExpenseRatio { get { return CalculateOperatingExpenseRatio(); } }

        private double CalculateGrossProfitRatioPercentage()
        {
            double gp = Math.Round(GrossProfitRatio * 100);
            return gp;
        }

        private double CalculateNetIncomeRatioPercentage()
        {
            double ni = Math.Round(NetIncomeRatio * 100);
            return ni;
        }
        //Calculating Selling, General, and Administrative expense ratio to Gross Profit
        private double CalculateSGARatioPercentage()
        {
            if (GrossProfit > 0)
            {
                double sga = (((double)SellingAndMarketingExpenses + (double)GeneralAndAdministrativeExpenses) / (double)GrossProfit) * 100;
                sga = Math.Round(sga);
                return sga;
            }
            else
            {
                return 0;
            }
        }
        private double CalculateOperatingExpenseRatio()
        {
            if (GrossProfit > 0)
            {
                double operatingExpenseMargin = ((double)OperatingExpenses / (double)GrossProfit) * 100;
                operatingExpenseMargin = Math.Round(operatingExpenseMargin);
                return operatingExpenseMargin;
            }
            else
            {
                return 0;
            } 
        }

        private double CalculateRAndDRatioPercentage()
        {
            if (GrossProfit > 0)
            {
                double rd = Math.Round(((double)ResearchAndDevelopmentExpenses / (double)GrossProfit) * 100);
                return rd;
            }
            else
            {
                return 0;
            }
        }

        private double CalculateDepreciationRatioPercentage()
        {
            if (GrossProfit > 0)
            {
                double depreciation = Math.Round(((double)DepreciationAndAmortization / (double)GrossProfit) * 100);
                return depreciation;
            }
            else
            {
                return 0;
            }
        }

        private double CalculateInterestRatioPercentage()
        {
            if (OperatingIncome > 0)
            {
                double interestExpense = Math.Round(((double)InterestExpense / (double)OperatingIncome) * 100);
                return interestExpense;
            }
            else
            {
                return 0;
            }
            
        }

        private double CalculateIncomeTaxRatioPercentage()
        {
            if (IncomeBeforeTax > 0)
            {
                double incomeTax = Math.Round(((double)IncomeTaxExpense / (double)IncomeBeforeTax) * 100);
                return incomeTax;
            }
            else
            {
                return 0;
            }  
        }
    }
}
