using FinancialReportsGenerator.JsonModels;
using FinancialReportsGenerator.ApiClients;
using FinancialReportsGenerator.Models;
using FinancialReportsGenerator.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.Controllers
{
    [ApiController]
    [EnableCors("My Policy")]
    [Route("api/[controller]")]
    public class FinancialStatementsController : Controller
    {
        FMPApiClient _apiClient;
        FMPApiService _apiService;
        CompanyProfileService _profileService;
        IncomeStatementService _incomeStatementService;
        BalanceSheetService _balanceSheetService;
        CashFlowStatementService _cashFlowService;

        [HttpGet("companyprofile/{companyTicker}")]
        public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _profileService = new CompanyProfileService(_apiClient);
            var response = await _profileService.GetCompanyProfile(companyTicker);
            return response;
        }

        [HttpGet("financialstatements/{companyTicker}")]
        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _apiService = new FMPApiService(_apiClient);

            CompanyProfile companyProfile = await GetCompanyProfile(companyTicker);
            List<IncomeStatement> incomeStatements = await GetAllIncomeStatements(companyTicker);
            List<BalanceSheet> balanceSheets = await GetAllBalanceSheets(companyTicker);
            List<CashFlowStatement> cashFlowStatements = await GetAllCashFlowStatements(companyTicker);

            var response = await _apiService.GetAllFinancialStatements(companyProfile, incomeStatements, balanceSheets, cashFlowStatements);
            return response;
        }
        [HttpGet("incomestatements/{companyTicker}")]
        public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _incomeStatementService = new IncomeStatementService(_apiClient);
            var response = await _incomeStatementService.GetAllIncomeStatements(companyTicker);
            return response;
        }

        [HttpGet("balancesheets/{companyTicker}")]
        public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _balanceSheetService = new BalanceSheetService(_apiClient);
            var response = await _balanceSheetService.GetAllBalanceSheets(companyTicker);
            return response;
        }

        [HttpGet("cashflowstatements/{companyTicker}")]
        public async Task<List<CashFlowStatement>> GetAllCashFlowStatements(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _cashFlowService = new CashFlowStatementService(_apiClient);
            var response = await _cashFlowService.GetAllCashFlowStatements(companyTicker);
            return response;
        }
    }
}
