﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Models
{
    public class FinancialStatement
    {
        public List<IncomeStatement> IncomeStatement { get; set; }
        public List<BalanceSheet> BalanceSheet { get; set; }
        public CompanyProfile CompanyProfile { get; set; }

        public async void CalculateFinancialSheetRatios()
        {
            foreach (var bStatement in BalanceSheet)
            {
                CalculateNetReceivablesRatio(bStatement);
                CalculateReturnOnAssetsRatio(bStatement);
                CalculateReturnOnShareholdersEquityRatio(bStatement);
            }
        }

        private void CalculateNetReceivablesRatio(BalanceSheet balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    double netReceivablesRatio = Math.Round(((double)balanceSheet.NetReceivables / (double)iStatement.Revenue) * 100);
                    balanceSheet.NetReceivablesRatio = netReceivablesRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateReturnOnAssetsRatio(BalanceSheet balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    double returnOnAssetsRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalAssets) * 100);
                    balanceSheet.ReturnOnAssetsRatio = returnOnAssetsRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void CalculateReturnOnShareholdersEquityRatio(BalanceSheet balanceSheet)
        {
            try
            {
                foreach (var iStatement in IncomeStatement.Where(x => x.Year == balanceSheet.Year))
                {
                    double returnOnShareholdersEquityRatio = Math.Round(((double)iStatement.NetIncome / (double)balanceSheet.TotalStockholdersEquity) * 100);
                    balanceSheet.ReturnOnShareholdersEquityRatio = returnOnShareholdersEquityRatio;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}