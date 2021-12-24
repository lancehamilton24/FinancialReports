﻿using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Services
{
    public class FMPApiService
    {
        CompanyProfileService _profileService;
        IncomeStatementService _incomeStatementService;
        BalanceSheetService _balanceSheetService;
        CashFlowStatementService _cashFlowService;

        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            FinancialStatement financialStatements;
            financialStatements = new FinancialStatement()
            {
                CompanyProfile = await GetCompanyProfile(companyTicker),
                IncomeStatement = await GetAllIncomeStatements(companyTicker),
                BalanceSheet = await GetAllBalanceSheets(companyTicker),
                CashFlowStatement = await GetAllCashFlowStatements(companyTicker),
                CompetitiveAdvantageRatios = new List<CompetitiveAdvantageRatios>()
            };

            financialStatements.CalculateFinancialSheetMargins();
            return financialStatements;
        }

        public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        {
            _profileService = new CompanyProfileService();
            var response = await _profileService.GetCompanyProfile(companyTicker);
            return response;
        }

        public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        {
            _incomeStatementService = new IncomeStatementService();
            var response = await _incomeStatementService.GetAllIncomeStatements(companyTicker);
            return response;
        }

        public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        {
            _balanceSheetService = new BalanceSheetService();
            var response = await _balanceSheetService.GetAllBalanceSheets(companyTicker);
            return response;
        }

        public async Task<List<CashFlowStatement>> GetAllCashFlowStatements(string companyTicker)
        {
            _cashFlowService = new CashFlowStatementService();
            var response = await _cashFlowService.GetAllCashFlowStatements(companyTicker);
            return response;
        }
    }
}
