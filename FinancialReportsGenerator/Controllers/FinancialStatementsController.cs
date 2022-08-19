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
using FinancialReportsGenerator.Interfaces;

namespace FinancialReportsGenerator.Controllers
{
    [ApiController]
    [EnableCors("My Policy")]
    [Route("api/[controller]")]
    public class FinancialStatementsController : Controller
    {
        FinancialStatementService _apiService;
        IFMPApiClient _apiClient;

        public FinancialStatementsController(IFMPApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        [HttpGet("financialstatements/{companyTicker}")]
        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            _apiService = new FinancialStatementService(_apiClient);

            try
            {
                var response = await _apiService.GetAllFinancialStatements(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("companyprofile/{companyTicker}")]
        public async Task<CompanyProfile> CompanyProfileGet(string companyTicker)
        {
            CompanyProfileService _apiService = new CompanyProfileService(_apiClient);

            try
            {
                var response = await _apiService.GetCompanyProfile(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("incomestatements/{companyTicker}")]
        public async Task<List<IncomeStatement>> IncomeStatementsGet(string companyTicker)
        {
            IncomeStatementService _apiService = new IncomeStatementService(_apiClient);

            try
            {
                var response = await _apiService.IncomeStatementsGet(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("balancesheets/{companyTicker}")]
        public async Task<List<BalanceSheet>> BalanceSheetsGet(string companyTicker)
        {
            BalanceSheetService _apiService = new BalanceSheetService(_apiClient);

            try
            {
                var response = await _apiService.BalanceSheetsGet(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("cashflows/{companyTicker}")]
        public async Task<List<CashFlowStatement>> CashFlowStatementsGet(string companyTicker)
        {
            CashFlowStatementService _apiService = new CashFlowStatementService(_apiClient);

            try
            {
                var response = await _apiService.CashFlowStatementsGet(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
