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
        public async Task<List<IncomeStatement>> GetAllIncomeStatements(string companyTicker)
        {
                List<IncomeStatement> incomeStatements;
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://financialmodelingprep.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync($"api/v3/income-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");
                var incomeStatementJSON = await response.Content.ReadAsStringAsync();
                incomeStatements = JsonConvert.DeserializeObject<List<IncomeStatement>>(incomeStatementJSON);
                return incomeStatements;
        }

        [HttpGet("balancesheets/{companyTicker}")]
        public async Task<List<BalanceSheet>> GetAllBalanceSheets(string companyTicker)
        {
            List<BalanceSheet> balanceSheets;
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://financialmodelingprep.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //GET Method  
            HttpResponseMessage response = await client.GetAsync($"api/v3/balance-sheet-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");
            var balanceSheetJSON = await response.Content.ReadAsStringAsync();
            balanceSheets = JsonConvert.DeserializeObject<List<BalanceSheet>>(balanceSheetJSON);
            return balanceSheets;
        }
    }
}
