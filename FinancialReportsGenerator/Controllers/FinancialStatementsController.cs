using FinancialReportsApiClient.JsonModels;
using FinancialReportsApiClient.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FinancialReportsApiClient.Controllers
{
    [ApiController]
    [EnableCors("My Policy")]
    [Route("api/[controller]")]
    public class FinancialStatementsController : Controller
    {
        [HttpGet("incomestatements/{companyTicker}")]
        public async Task<List<IncomeStatementJson>> GetAllIncomeStatements(string companyTicker)
        {
                List<IncomeStatementJson> incomeStatements;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/income-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");
                var incomeStatementJSON = await response.Content.ReadAsStringAsync();
                incomeStatements = JsonConvert.DeserializeObject<List<IncomeStatementJson>>(incomeStatementJSON);
                return incomeStatements;
        }

        [HttpGet("financialstatements/{companyTicker}")]
        public async Task<FinancialStatement> GetAllFinancialStatements(string companyTicker)
        {
            FinancialStatement financialStatements;
            financialStatements = new FinancialStatement();
            //financialStatements.CompanyProfile = await GetCompanyProfile(companyTicker);
            financialStatements.IncomeStatement = await GetAllIncomeStatements(companyTicker);
            financialStatements.BalanceSheet = await GetAllBalanceSheets(companyTicker);
            financialStatements.CalculateFinancialSheetRatios();
            return financialStatements;
        }

        [HttpGet("balancesheets/{companyTicker}")]
        public async Task<List<BalanceSheetJson>> GetAllBalanceSheets(string companyTicker)
        {
            List<BalanceSheetJson> balanceSheets;
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://financialmodelingprep.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //GET Method  
            HttpResponseMessage response = await client.GetAsync($"api/v3/balance-sheet-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");
            var balanceSheetJSON = await response.Content.ReadAsStringAsync();
            balanceSheets = JsonConvert.DeserializeObject<List<BalanceSheetJson>>(balanceSheetJSON);
            return balanceSheets;
        }

        [HttpGet("companyprofile/{companyTicker}")]
         public async Task<List<CompanyProfileJson>> GetCompanyProfile(string companyTicker)
         {
             List<CompanyProfileJson> companyProfile;
             var client = new HttpClient();
             client.BaseAddress = new Uri("https://financialmodelingprep.com/");
             client.DefaultRequestHeaders.Accept.Clear();
             client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             //GET Method  
             HttpResponseMessage response = await client.GetAsync($"api/v3/quote/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

             var companyProfileJSON = await response.Content.ReadAsStringAsync();
            companyProfile = JsonConvert.DeserializeObject<List<CompanyProfileJson>>(companyProfileJSON);
             return companyProfile;
         }
    }
}
