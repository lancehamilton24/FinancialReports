using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class CashFlowStatementService
    {
        FMPApiClient _apiClient;

        public CashFlowStatementService(FMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<CashFlowStatement>> GetAllCashFlowStatements(string companyTicker)
        {
            var response = await _apiClient.GetAllCashFlowStatements(companyTicker);
            var cashFlowStatements = response.Item3;
            var cashFlowStatementList = new List<CashFlowStatement>();
            foreach (var statement in cashFlowStatements)
            {
                var cashFlowStatement = new CashFlowStatement
                {
                    Date = statement.Date,
                    NetIncome = statement.NetIncome,
                    DepreciationAndAmortization = statement.DepreciationAndAmortization,
                    DeferredIncomeTax = statement.DeferredIncomeTax,
                    StockBasedCompensation = statement.StockBasedCompensation,
                    NetCashProvidedByOperatingActivities = statement.NetCashProvidedByOperatingActivities,
                    AcquisitionsNet = statement.AcquisitionsNet,
                    NetCashUsedForInvestingActivites = statement.NetCashUsedForInvestingActivites,
                    DebtRepayment = statement.DebtRepayment,
                    CommonStockIssued = statement.CommonStockIssued,
                    CommonStockRepurchased = statement.CommonStockRepurchased,
                    DividendsPaid = statement.DividendsPaid,
                    NetCashUsedProvidedByFinancingActivities = statement.NetCashUsedProvidedByFinancingActivities,
                    CashAtEndOfPeriod = statement.CashAtEndOfPeriod,
                    CashAtBeginningOfPeriod = statement.CashAtBeginningOfPeriod,
                    OperatingCashFlow = statement.OperatingCashFlow,
                    CapitalExpenditure = statement.CapitalExpenditure,
                    FreeCashFlow = statement.FreeCashFlow
                };

                cashFlowStatementList.Add(cashFlowStatement);
            }

            return cashFlowStatementList;
        }
    }
}
