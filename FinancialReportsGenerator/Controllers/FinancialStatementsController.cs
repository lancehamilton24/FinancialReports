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
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
