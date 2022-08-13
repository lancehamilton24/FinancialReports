using FinancialReportsGenerator.Interfaces;
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
    public class FMPApiClient : IFMPApiClient
    {
        private static HttpClient _httpClient;
        public FMPApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Tuple<HttpStatusCode, List<CompanyProfileJson>>> GetCompanyProfile(string companyTicker)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/profile/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new Tuple<HttpStatusCode, List<CompanyProfileJson>>(response.StatusCode, null);
            }

            var companyProfileContent = response.Content.ReadAsStringAsync().Result;
            List<CompanyProfileJson> companyProfileJSON = JsonConvert.DeserializeObject<List<CompanyProfileJson>>(companyProfileContent);
            return new Tuple<HttpStatusCode, List<CompanyProfileJson>>(response.StatusCode, companyProfileJSON);
        }

        public async Task<Tuple<HttpStatusCode, string, List<IncomeStatementJson>>> GetAllIncomeStatements(string companyTicker)
        {
            List<IncomeStatementJson> incomeStatements;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/income-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            var incomeStatementJSON = await response.Content.ReadAsStringAsync();
            incomeStatements = JsonConvert.DeserializeObject<List<IncomeStatementJson>>(incomeStatementJSON);
            return new Tuple<HttpStatusCode, string, List<IncomeStatementJson>>(HttpStatusCode.OK, "Success", incomeStatements);
        }

        public async Task<Tuple<HttpStatusCode, string, List<BalanceSheetJson>>> GetAllBalanceSheets(string companyTicker)
        {
            List<BalanceSheetJson> balanceSheets;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/balance-sheet-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            var balanceSheetJSON = await response.Content.ReadAsStringAsync();
            balanceSheets = JsonConvert.DeserializeObject<List<BalanceSheetJson>>(balanceSheetJSON);
            return new Tuple<HttpStatusCode, string, List<BalanceSheetJson>>(HttpStatusCode.OK, "Success", balanceSheets);

        }

        public async Task<Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>> GetAllCashFlowStatements(string companyTicker)
        {

            List<CashFlowStatementJson> cashFlowStatements;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await _httpClient.GetAsync($"/api/v3/cash-flow-statement/{companyTicker}?limit=120&apikey=be1ce41dccee923dcd1484989bc6384b");

            var cashFlowStatmentJSON = await response.Content.ReadAsStringAsync();
            cashFlowStatements = JsonConvert.DeserializeObject<List<CashFlowStatementJson>>(cashFlowStatmentJSON);
            return new Tuple<HttpStatusCode, string, List<CashFlowStatementJson>>(HttpStatusCode.OK, "success", cashFlowStatements);
        }
    }
}
