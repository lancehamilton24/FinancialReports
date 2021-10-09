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
        public double GrossProfitMargin { get; set; }
        public long ResearchAndDevelopmentExpenses { get; set; }
        public long GeneralAndAdministrativeExpenses { get; set; }
        public long SellingAndMarketingExpenses { get; set; }
        public long OperatingExpenses { get; set; }
        public long InterestExpense { get; set; }
        public long DepreciationAndAmortization { get; set; }
        public long Ebitda { get; set; }
        public long OperatingIncome { get; set; }
        public double OperatingIncomeMargin { get; set; }
        public long IncomeBeforeTax { get; set; }
        public double IncomeBeforeTaxMargin { get; set; }
        public long IncomeTaxExpense { get; set; }
        public long NetIncome { get; set; }
        public double NetIncomeMargin { get; set; }
        public double Eps { get; set; }

        public string Year { get { return Date.Year.ToString(); } }

        public double GrossProfitRatio { get { return CalculateGrossProfitMargin(); } }

        public double NetIncomeRatio { get { return CalculateNetIncomeMargin(); } }

        public double SgaMargin { get { return CalculateSGAMargin(); } }

        public double RAndDMargin { get { return CalculateRAndDMargin(); } }

        public double DepreciationMargin { get { return CalculateDepreciationMargin(); } }

        public double InterestExpenseMargin { get { return CalculateInterestMargin(); } }

        public double IncomeTaxExpenseMargin { get { return CalculateIncomeTaxMargin(); } }

        public double OperatingExpenseMargin { get { return CalculateOperatingExpenseMargin(); } }

        private double CalculateGrossProfitMargin()
        {
            double gp = Math.Round(GrossProfitMargin * 100);
            return gp;
        }

        private double CalculateNetIncomeMargin()
        {
            double ni = Math.Round(NetIncomeMargin * 100);
            return ni;
        }
        //Calculating Selling, General, and Administrative expense Margin to Gross Profit
        private double CalculateSGAMargin()
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
        private double CalculateOperatingExpenseMargin()
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

        private double CalculateRAndDMargin()
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

        private double CalculateDepreciationMargin()
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

        private double CalculateInterestMargin()
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

        private double CalculateIncomeTaxMargin()
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
