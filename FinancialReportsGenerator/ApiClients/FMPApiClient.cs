using FinancialReportsGenerator.JsonModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinancialReportsGenerator.ApiClients
{
    public class FMPApiClient
    {
        public async Task<Tuple<HttpStatusCode, string, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker)
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
 
            return new Tuple<HttpStatusCode, string, List<CompanyProfileJson>>(HttpStatusCode.OK, "success", companyProfile);
        }

        public async Task<Tuple<HttpStatusCode, string, List<IncomeStatementJson>>> GetAllIncomeStatements(string companyTicker)
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
            return new Tuple<HttpStatusCode, string, List<IncomeStatementJson>>(HttpStatusCode.OK, "success", incomeStatements);
        }

        public async Task<Tuple<HttpStatusCode, string, List<BalanceSheetJson>>> GetAllBalanceSheets(string companyTicker)
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
            return new Tuple<HttpStatusCode, string, List<BalanceSheetJson>>(HttpStatusCode.OK, "success", balanceSheets);
        }
    }
}
