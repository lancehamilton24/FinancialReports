using FinancialReportsGenerator.Models;
using FinancialReportsGenerator.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialReportsGenerator.Interfaces;

namespace FinancialReportsGenerator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinancialStatementsController : Controller
    {
        ICompanyProfileService _companyProfileService;
        IIncomeStatementService _incomeStatementService;
        IBalanceSheetService _balanceSheetService;
        ICashFlowStatementService _cashFlowStatementService;

        public FinancialStatementsController(ICompanyProfileService companyProfileService, IIncomeStatementService incomeStatementService,
            IBalanceSheetService balanceSheetService, ICashFlowStatementService cashFlowStatementService)
        {
            _companyProfileService = companyProfileService;
            _incomeStatementService = incomeStatementService;
            _balanceSheetService = balanceSheetService;
            _cashFlowStatementService = cashFlowStatementService;
        }

        [HttpGet("companyprofile/{companyTicker}")]
        public async Task<CompanyProfile> CompanyProfileGet(string companyTicker)
        {
            try
            {
                var response = await _companyProfileService.GetCompanyProfile(companyTicker);
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
            try
            {
                var response = await _incomeStatementService.IncomeStatementsGet(companyTicker);
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
            try
            {
                var response = await _balanceSheetService.BalanceSheetsGet(companyTicker);
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
            try
            {
                var response = await _cashFlowStatementService.CashFlowStatementsGet(companyTicker);
                return response;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
