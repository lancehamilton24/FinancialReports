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

        [HttpGet("companyprofile/{companyTicker}")]
        public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _apiService = new FMPApiService(_apiClient);
            var response = await _apiService.GetCompanyProfile(companyTicker);
            return response;
        }

        [HttpGet("financialstatements/{companyTicker}")]
        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _apiService = new FMPApiService(_apiClient);

            List<IncomeStatement> incomeStatements = await GetAllIncomeStatements(companyTicker);
            List<BalanceSheet> balanceSheets = await GetAllBalanceSheets(companyTicker);

            var response = await _apiService.GetAllFinancialStatements(incomeStatements, balanceSheets);
            return response;
        }
        [HttpGet("incomestatements/{companyTicker}")]
        public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _apiService = new FMPApiService(_apiClient);
            var response = await _apiService.GetAllIncomeStatements(companyTicker);
            return response;
        }

        [HttpGet("balancesheets/{companyTicker}")]
        public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        {
            _apiClient = new FMPApiClient();
            _apiService = new FMPApiService(_apiClient);
            var response = await _apiService.GetAllBalanceSheets(companyTicker);
            return response;
        }
    }
}
