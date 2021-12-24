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
        FMPApiService _apiService;

        [HttpGet("financialstatements/{companyTicker}")]
        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            _apiService = new FMPApiService();

            var response = await _apiService.GetAllFinancialStatements(companyTicker);
            return response;
        }

        //[HttpGet("companyprofile/{companyTicker}")]
        //public async Task<CompanyProfile> GetCompanyProfile(string companyTicker)
        //{
        //    _profileService = new CompanyProfileService();
        //    var response = await _profileService.GetCompanyProfile(companyTicker);
        //    return response;
        //}

        //[HttpGet("incomestatements/{companyTicker}")]
        //public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        //{
        //    _incomeStatementService = new IncomeStatementService();
        //    var response = await _incomeStatementService.GetAllIncomeStatements(companyTicker);
        //    return response;
        //}

        //[HttpGet("balancesheets/{companyTicker}")]
        //public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        //{
        //    _balanceSheetService = new BalanceSheetService();
        //    var response = await _balanceSheetService.GetAllBalanceSheets(companyTicker);
        //    return response;
        //}

        //[HttpGet("cashflowstatements/{companyTicker}")]
        //public async Task<List<CashFlowStatement>> GetAllCashFlowStatements(string companyTicker)
        //{
        //    _cashFlowService = new CashFlowStatementService();
        //    var response = await _cashFlowService.GetAllCashFlowStatements(companyTicker);
        //    return response;
        //}
    }
}
